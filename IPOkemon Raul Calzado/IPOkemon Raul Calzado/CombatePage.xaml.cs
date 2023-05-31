using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.ApplicationModel.VoiceCommands;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemon_Raul_Calzado
{
    public class CombateViewModel
    {
        public Control Luchador1 { get; set; }
        public Control Luchador2 { get; set; }
    }
    public sealed partial class CombatePage : Page
    {
        ResourceLoader resourceLoader;
        public Control luchador1;
        public Control luchador2;
        public InPokemon iLuchador1;
        public InPokemon iLuchador2;
        public bool protegido;
        public bool multi;

        public CombatePage()
        {
            this.InitializeComponent();
            protegido = false;
            var viewModel = new CombateViewModel()
            {
                Luchador1 = luchador1,
                Luchador2 = luchador2
            };

            DataContext = viewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Obtener el control de usuario pasado como parámetro
            object[] luchadores = e.Parameter as object[];

            luchador1 = (Control)luchadores[0];
            luchador2 = (Control)luchadores[1];
            multi = (bool)luchadores[2];
            iLuchador1 = (InPokemon)luchador1;
            iLuchador2 = (InPokemon)luchador2;

            string defaultLanguage = Windows.Globalization.ApplicationLanguages.Languages[0];

            // Crear un ResourceContext utilizando el idioma predeterminado
            var resourceContext = ResourceContext.GetForCurrentView();
            resourceContext.Languages = new List<string> { defaultLanguage };

            // Obtener el ResourceLoader utilizando el ResourceContext
            resourceLoader = ResourceLoader.GetForCurrentView();

            comenzarCombate();

            var viewModel = new CombateViewModel()
            {
                Luchador1 = luchador1,
                Luchador2 = luchador2
            };
            DataContext = viewModel;
            iLuchador1.ataqueRealizado += ataque_realizado;
            iLuchador2.ataqueRealizado += ataque_realizado_2;
            iLuchador1.debilitado += debilitado;
            iLuchador2.debilitado += debilitado;
            iLuchador1.muerteSubita += muerteSubita;
            iLuchador2.muerteSubita += muerteSubita;
            iLuchador1.ataqueFallado += ataque_fallado;
            iLuchador2.ataqueFallado += ataque_fallado_2;

            
        }

        public void comenzarCombate()
        {
            luchador1.GetType().GetProperty("Vida").SetValue(luchador1, 100);
            luchador2.GetType().GetProperty("Vida").SetValue(luchador2, 100);
            luchador1.GetType().GetProperty("Escudo").SetValue(luchador1, 100);
            luchador2.GetType().GetProperty("Escudo").SetValue(luchador2, 100);
            luchador2.GetType().GetMethod("verAcciones")?.Invoke(luchador2, new object[] { false });
            string nombre1 = (string)luchador1.GetType().GetProperty("Nombre").GetValue((object)luchador1, null);
            string nombre2 = (string)luchador2.GetType().GetProperty("Nombre").GetValue((object)luchador2, null);

            string comienzo = resourceLoader.GetString("comienzoCombate");

            Texto.Text = comienzo + " " + nombre1 + " vs " + nombre2 + ".";
        }

        public string obtenerAtaque(string nombre)
        {
            string nombreCorrecto = "";
            switch (nombre)
            {
                case "Ataque ala":
                    nombreCorrecto = resourceLoader.GetString("ataqueAla");
                    break;
                case "Lanzarrocas":
                    nombreCorrecto = resourceLoader.GetString("lanzarrocas");
                    break;
                case "Burbuja":
                    nombreCorrecto = resourceLoader.GetString("burbuja");
                    break;
                case "Descanso":
                    nombreCorrecto = resourceLoader.GetString("descanso");
                    break;
                case "Protección":
                    nombreCorrecto = resourceLoader.GetString("proteccion");
                    break;
                case "Psíquico":
                    nombreCorrecto = resourceLoader.GetString("psiquico");
                    break;
                case "Muerte súbita":
                    nombreCorrecto = resourceLoader.GetString("muerteSubita");
                    break;
            }
            return nombreCorrecto;
        }

        public void ataque_realizado(object sender, Ataque e)
        {
            if (protegido)
            {
                protegido = false;
                fallo(sender, e, true, false);
                if (multi)
                {
                    cambiarTurnoA(2);
                }
                else
                {
                    cambiarTurnoMaquina();
                }
            }
            else
            {
                escribirAtaque(sender, e);
                double vida = (double)luchador2.GetType().GetProperty("Vida").GetValue(luchador2, null);
                luchador2.GetType().GetProperty("Vida").SetValue(luchador2, vida - e.dano);
                if (multi)
                {
                    if (e.nombre != "Muerte súbita")
                        cambiarTurnoA(2);
                }
                else
                {
                    if (vida != 0)
                        cambiarTurnoMaquina();
                }
                if (e.nombre == "Protección")
                    protegido = true;
            }
        }

        public void ataque_realizado_2(object sender, Ataque e)
        {
            if (protegido)
            {
                protegido = false;
                fallo2(sender, e, true, false);
                cambiarTurnoA(1);
            }
            else
            {
                escribirAtaque(sender, e);
                double vida = (double)luchador1.GetType().GetProperty("Vida").GetValue(luchador1, null);
                luchador1.GetType().GetProperty("Vida").SetValue(luchador1, vida - e.dano);
                if (e.nombre != "Muerte súbita")
                    cambiarTurnoA(1);
                if (e.nombre == "Protección")
                    protegido = true;
            }
        }

        public void ataque_fallado(object sender, Ataque e)
        {
            fallo(sender, e, false, true);
        }
        public void fallo(object sender, Ataque e, bool protegido, bool fallo)
        {
            if ((e.nombre == "Descanso" && protegido == true && fallo == false) || (e.nombre == "Descanso" && protegido == false && fallo == false))
                escribirAtaque(sender, e);
            else
            {
                string dialogoFallo = resourceLoader.GetString("dialogoFallo");
                string nombre = (string)sender.GetType().GetProperty("Nombre").GetValue((object)sender, null);
                string ataque = obtenerAtaque(e.nombre);
                Texto.Text = nombre + " " + dialogoFallo + " " + ataque;
            }
            if (multi)
                cambiarTurnoA(2);
            else
                cambiarTurnoMaquina();
        }

        public void ataque_fallado_2(object sender, Ataque e)
        {
            fallo2(sender, e, false, true);
        }
        public void fallo2(object sender, Ataque e, bool protegido, bool fallo)
        {
            if ((e.nombre == "Descanso" && protegido == true && fallo == false) || (e.nombre == "Descanso" && protegido == false && fallo == false))
                escribirAtaque(sender, e);
            else
            {
                string dialogoFallo = resourceLoader.GetString("dialogoFallo");
                string nombre = (string)sender.GetType().GetProperty("Nombre").GetValue((object)sender, null);
                string ataque = obtenerAtaque(e.nombre);
                Texto.Text = nombre + " " + dialogoFallo + " " + ataque;
            }
            cambiarTurnoA(1);
        }


        public void cambiarTurnoA(int luchador)
        {
            if (luchador == 1)
            {
                luchador1.GetType().GetMethod("verAcciones")?.Invoke(luchador1, new object[] { true });
                luchador2.GetType().GetMethod("verAcciones")?.Invoke(luchador2, new object[] { false });
            }
            else if (luchador == 2)
            {
                luchador1.GetType().GetMethod("verAcciones")?.Invoke(luchador1, new object[] { false });
                luchador2.GetType().GetMethod("verAcciones")?.Invoke(luchador2, new object[] { true });
            }
            else
            {
                luchador1.GetType().GetMethod("verAcciones")?.Invoke(luchador1, new object[] { false });
            }
        }

        public void escribirAtaque(object luchador, Ataque e)
        {
            string nombre = (string)luchador.GetType().GetProperty("Nombre").GetValue((object)luchador, null);
            string dialogoAtaque = resourceLoader.GetString("dialogoAtaque");
            string ataque = obtenerAtaque(e.nombre);
            Texto.Text = nombre + " " + dialogoAtaque + " " + ataque;
        }

        public void debilitado(object sender, string e)
        {
            string debilitado = resourceLoader.GetString("dialogoDebilitado");
            Texto.Text = e + " " + debilitado;
            Esperar(4);
        }

        public async Task Esperar(int segundos)
        {
            await Task.Delay(segundos * 1000);
            Frame aux = (Frame)this.Parent;
            if (aux != null)
                aux.Navigate(typeof(JugadoresPage));
        }

        public void muerteSubita(object sender, object e)
        {
            string nombre1 = (string)luchador1.GetType().GetProperty("Nombre").GetValue((object)luchador1, null);
            string nombre2 = (string)luchador2.GetType().GetProperty("Nombre").GetValue((object)luchador2, null);
            string senderName = (string)sender.GetType().GetProperty("Nombre").GetValue((object)sender, null);

            string muerteSubita = resourceLoader.GetString("dialogoMuerteSubita");
            string y = resourceLoader.GetString("y");
            string debilitados = resourceLoader.GetString("dialogoDebilitados");

            Texto.Text = senderName + " " + muerteSubita + " " + nombre1 + " " + y + " " + nombre2 + " " + debilitados;
            Esperar(4);
        }

        public async Task cambiarTurnoMaquina()
        {
            cambiarTurnoA(3);
            await Task.Delay(2000);
            double vida = (double)luchador2.GetType().GetProperty("Vida").GetValue(luchador2, null);
            double escudo = (double)luchador2.GetType().GetProperty("Escudo").GetValue(luchador2, null);
            string nombre = (string)luchador2.GetType().GetProperty("Nombre").GetValue(luchador2, null);

            if (nombre == "Piplup")
            {
                comportamientoPiplup(vida, escudo);
            }
            if (nombre == "Gengar")
            {
                comportamientoGengar(vida, escudo);
            }
            await Task.Delay(1000);
            cambiarTurnoA(1);
        }
        public void comportamientoPiplup(double vida, double escudo)
        {
            Random random = new Random();

            if (vida <= 10 && vida != 0)
            {
                luchador2.GetType().GetMethod("descansoclick")?.Invoke(luchador2, null);
            }
            else if (vida > 10 && vida < 50 && escudo < 30)
            {
                luchador2.GetType().GetMethod("descansoclick")?.Invoke(luchador2, null);
            }
            else if ((vida > 10 && vida < 50 && escudo >= 30) || (vida >= 50 && escudo < 40))
            {
                int randomNumber = random.Next(0, 3);  // Genera un número aleatorio entre 0 y 1

                if (randomNumber == 0 || randomNumber == 1)
                {
                    // Burbuja
                    luchador2.GetType().GetMethod("burbuja")?.Invoke(luchador2, null);
                }
                else
                {
                    // Ataque ala
                    luchador2.GetType().GetMethod("ataqueAla")?.Invoke(luchador2, null);
                }
            }
            else if (vida >= 50 && escudo >= 40)
            {
                int randomNumber = random.Next(0, 6);
                if (randomNumber == 0 || randomNumber == 1 || randomNumber == 2)
                {
                    // Lanzarrocas
                    luchador2.GetType().GetMethod("lanzarrocas")?.Invoke(luchador2, null);
                }
                else if (randomNumber == 3 || randomNumber == 4)
                {
                    // Burbuja
                    luchador2.GetType().GetMethod("burbuja")?.Invoke(luchador2, null);
                }
                else
                {
                    //Ataque ala
                    luchador2.GetType().GetMethod("ataqueAla")?.Invoke(luchador2, null);
                }
            }
        }
        public void comportamientoGengar(double vida, double escudo)
        {
            Random random = new Random();

            if (vida <= 10 && vida != 0)
            {
                int randomNumber = random.Next(0, 3);
                if (randomNumber == 0 || randomNumber == 1)
                {
                    // Muerte
                    luchador2.GetType().GetMethod("muerte")?.Invoke(luchador2, null);
                }
                else
                {
                    // Descanso
                    luchador2.GetType().GetMethod("descansoclick")?.Invoke(luchador2, null);
                }
            }
            else if (vida > 10 && vida < 50 && escudo < 30)
            {
                int randomNumber = random.Next(0, 7);
                if (randomNumber == 0 || randomNumber == 1 || randomNumber == 2)
                {
                    // Descanso
                    luchador2.GetType().GetMethod("descansoclick")?.Invoke(luchador2, null);
                }
                else if (randomNumber == 3 || randomNumber == 4)
                {
                    // Descanso
                    luchador2.GetType().GetMethod("proteccion")?.Invoke(luchador2, null);
                }
                else
                {
                    // Psíquico
                    luchador2.GetType().GetMethod("ataque")?.Invoke(luchador2, null);
                }
            }
            else if ((vida > 10 && vida < 50 && escudo >= 30) || (vida >= 50 && escudo < 40))
            {
                int randomNumber = random.Next(0, 4);

                if (randomNumber == 0 || randomNumber == 1)
                {
                    // Proteccion
                    luchador2.GetType().GetMethod("proteccion")?.Invoke(luchador2, null);
                }
                else if (randomNumber == 2)
                {
                    // Psíquico
                    luchador2.GetType().GetMethod("ataque")?.Invoke(luchador2, null);
                }
                else
                {
                    // Descanso
                    luchador2.GetType().GetMethod("descansoclick")?.Invoke(luchador2, null);
                }
            }
            else if (vida >= 50 && escudo >= 40)
            {
                int randomNumber = random.Next(0, 8);
                if (randomNumber == 0 || randomNumber == 1 || randomNumber == 2 || randomNumber == 3 || randomNumber == 4)
                {
                    // Psíquico
                    luchador2.GetType().GetMethod("ataque")?.Invoke(luchador2, null);
                }
                else if (randomNumber == 5 || randomNumber == 6)
                {
                    // Protección
                    luchador2.GetType().GetMethod("proteccion")?.Invoke(luchador2, null);
                }
                else
                {
                    // Descanso
                    luchador2.GetType().GetMethod("descansoclick")?.Invoke(luchador2, null);
                }
            }
        }
    }
}
