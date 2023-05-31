using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class CuidarPage : Page
    {

        public ObservableCollection<Control> Pokemons { get; set; } = new ObservableCollection<Control>()
        {
            new ucPiplup(),
            new ucGengar()
        };
        ResourceLoader resourceLoader;

        public CuidarPage()
        {
            this.InitializeComponent();

            var pokemon = Pokemons[0];
            var pokemon2 = Pokemons[1];

            InPokemon inPokemon = pokemon as InPokemon;
            InPokemon inPokemon2 = pokemon2 as InPokemon;
            inPokemon.ataqueRealizado += ataque_realizado;
            inPokemon.debilitado += debilitado;
            inPokemon.muerteSubita += muerteSubita;
            inPokemon.ataqueFallado += ataque_fallado;
            inPokemon2.ataqueRealizado += ataque_realizado;
            inPokemon2.debilitado += debilitado;
            inPokemon2.muerteSubita += muerteSubita;
            inPokemon2.ataqueFallado += ataque_fallado;

            string defaultLanguage = Windows.Globalization.ApplicationLanguages.Languages[0];

            // Crear un ResourceContext utilizando el idioma predeterminado
            var resourceContext = ResourceContext.GetForCurrentView();
            resourceContext.Languages = new List<string> { defaultLanguage };

            // Obtener el ResourceLoader utilizando el ResourceContext
            resourceLoader = ResourceLoader.GetForCurrentView();

        }

        public void ataque_realizado(object sender, Ataque e)
        {

        }
        public void debilitado(object sender, object e)
        {

        }
        public void muerteSubita(object sender, object e)
        {

        }
        public void ataque_fallado(object sender, Ataque e)
        {
            string nombre = (string)sender.GetType().GetProperty("Nombre").GetValue((object)sender, null);
            if (e.nombre == "Muerte súbita")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("muerteSubita"),
                    Content = nombre + " " + resourceLoader.GetString("precaucionMuerte"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
            if (e.nombre == "Psíquico")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("psiquico"),
                    Content = nombre + " " + resourceLoader.GetString("precaucionPsiquico"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
            if (e.nombre == "Protección")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("proteccion"),
                    Content = resourceLoader.GetString("precaucionProteccion1") + " " + nombre + " " + resourceLoader.GetString("precaucionProteccion2"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
            if (e.nombre == "Descanso")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("descanso"),
                    Content = nombre + " " + resourceLoader.GetString("precaucionDescanso"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
            if (e.nombre == "Ataque ala")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("ataqueAla"),
                    Content = nombre + " " + resourceLoader.GetString("precaucionAtaqueAla"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
            if (e.nombre == "Burbuja")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("burbuja"),
                    Content = nombre + " " + resourceLoader.GetString("precaucionBurbuja"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
            if (e.nombre == "Lanzarrocas")
            {
                ContentDialog dialog = new ContentDialog
                {
                    Title = resourceLoader.GetString("lanzarrocas"),
                    Content = nombre + " " + resourceLoader.GetString("precaucionLanzarrocas"),
                    CloseButtonText = resourceLoader.GetString("aceptar")
                };
                dialog.ShowAsync();
            }
        }
    }
}
