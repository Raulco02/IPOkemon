using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PokedexPage : Page
    {

        List<UserControl> listaPokemon = new List<UserControl>();
        ResourceLoader resourceLoader;

    public PokedexPage()
        {
            this.InitializeComponent();
            this.ucGengar.verAcciones(false);
            this.ucGengar.verBarras(false);
            this.ucGengar4.verAcciones(false);
            this.ucGengar4.verBarras(false);
            this.ucGengar6.verAcciones(false);
            this.ucGengar6.verBarras(false);
            this.ucPiplup.verBarraEscudo(false);
            this.ucPiplup.verBarraVida(false);
            this.ucPiplup.verAcciones(false);
            this.ucPiplup3.verBarraEscudo(false);
            this.ucPiplup3.verBarraVida(false);
            this.ucPiplup3.verAcciones(false);
            this.ucPiplup5.verBarraEscudo(false);
            this.ucPiplup5.verBarraVida(false);
            this.ucPiplup5.verAcciones(false);

            foreach (var item in pokemonGridView.Items)
            {
                listaPokemon.Add((UserControl) item);
            }

            string defaultLanguage = Windows.Globalization.ApplicationLanguages.Languages[0];

            // Crear un ResourceContext utilizando el idioma predeterminado
            var resourceContext = ResourceContext.GetForCurrentView();
            resourceContext.Languages = new List<string> { defaultLanguage };

            // Obtener el ResourceLoader utilizando el ResourceContext
            resourceLoader = ResourceLoader.GetForCurrentView();
        }

        private void ucPiplup1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Obtener la cadena de texto utilizando el ResourceLoader
            string descripcion = resourceLoader.GetString("descripcionPiplup");
            string tipo = resourceLoader.GetString("tipoPiplup");

            Pokemon piplup = new Pokemon("Piplup", descripcion, 0.4, 5.2, tipo, "Assets/piplup.png");
            Frame aux = (Frame)this.Parent;
            aux.Navigate(typeof(InfoPage), piplup);
        }

        private void ucGengar_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            string descripcion = resourceLoader.GetString("descripcionGengar");
            string tipo = resourceLoader.GetString("tipoGengar");

            Pokemon gengar = new Pokemon("Gengar", descripcion, 1.5, 40.5, tipo, "Assets/gengar.png");
            Frame aux = (Frame)this.Parent;
            aux.Navigate(typeof(InfoPage), gengar);
        }

        private void txtBusquedaPokemon_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pokemon_buscado = txtBusquedaPokemon.Text.Trim().ToLower();
            List<UserControl> resultados = new List<UserControl>();

            if (string.IsNullOrEmpty(pokemon_buscado))
            {
                pokemonGridView.ItemsSource = listaPokemon;
            } else
            {
                foreach (var control in listaPokemon)
                {
                    var tipoControl = control.GetType();
                    var nombrePropiedad = tipoControl.GetProperty("Nombre");

                    if (nombrePropiedad != null)
                    {
                        string nombrePokemon = nombrePropiedad.GetValue(control) as string;
                        if (nombrePokemon.ToLower().StartsWith(pokemon_buscado.ToLower()))
                        {
                            resultados.Add(control);
                        }

                    }
                }
                pokemonGridView.ItemsSource = resultados;
            }
        }
    }
}
