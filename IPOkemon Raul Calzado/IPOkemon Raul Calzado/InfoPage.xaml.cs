﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemon_Raul_Calzado
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class InfoPage : Page
    {
        public InfoPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

            if (e.Parameter != null && e.Parameter is Pokemon)
            {
                Pokemon pokemon = (Pokemon)e.Parameter;
                this.tbNombrePokemon.Text = pokemon.nombre + " (" + pokemon.tipo + ")";
                this.tbDescripcionPokemon.Text = pokemon.descripcion;
                this.tbAlturaPokemon.Text = pokemon.altura + " m";
                this.tbPesoPokemon.Text = pokemon.peso + " kg";
                this.imgInfoPokemon.Source = new BitmapImage(new Uri("ms-appx:///" + pokemon.imagen_pokemon)); ;
            }
        }
    }
}
