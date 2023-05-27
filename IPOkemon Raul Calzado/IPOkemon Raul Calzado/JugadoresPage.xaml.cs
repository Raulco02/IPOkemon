﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class JugadoresPage : Page
    {
        public JugadoresPage()
        {
            this.InitializeComponent();
            //Previo, ver si se puede usar
            //ApplicationView.GetForCurrentView().VisibleBoundsChanged += UcRatingText_VisibleBoundsChanged;
        }

        private void btn1jug_Click(object sender, RoutedEventArgs e)
        {
            Frame aux = (Frame)this.Parent;
            aux.Navigate(typeof(SeleccionPage));
        }
        /* Previo, ver si se puede usar
private void UcRatingText_VisibleBoundsChanged(ApplicationView sender, object args)
{
   var Width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
   if (Width >= 600)
   {
       RelativePanel.SetBelow(tbPokemon, null);
       RelativePanel.SetRightOf(tbPokemon, rcStars);
       RelativePanel.SetAlignVerticalCenterWith(tbPokemon, rcStars);
       RelativePanel.SetAlignVerticalCenterWithPanel(rcStars, true);
   }
   else
   {
       RelativePanel.SetRightOf(tbPokemon, null);
       RelativePanel.SetBelow(tbPokemon, rcStars);
       RelativePanel.SetAlignVerticalCenterWith(tbPokemon, null);
       RelativePanel.SetAlignVerticalCenterWithPanel(rcStars, false);
   }
}
*/
    }
}