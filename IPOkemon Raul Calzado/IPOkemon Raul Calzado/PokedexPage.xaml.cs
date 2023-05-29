using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public PokedexPage()
        {
            this.InitializeComponent();
            this.ucGengar.verAcciones(false);
            this.ucGengar.verBarras(false);
            this.ucPiplup.verBarraEscudo(false);
            this.ucPiplup.verBarraVida(false);
            this.ucPiplup.verAcciones(false);
        }

        private void ucPiplup1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Pokemon piplup = new Pokemon("Piplup", "No le gusta que lo cuiden. Como no aprecia el apoyo de su Entrenador, le cuesta coger confianza con él.", 0.4, 5.2, "Agua", "Assets/piplup.png");
            Frame aux = (Frame)this.Parent;
            aux.Navigate(typeof(InfoPage), piplup);
        }

        private void ucGengar_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Pokemon gengar = new Pokemon("Gengar", "Para quitarle la vida a su presa, se desliza en su sombra y espera su oportunidad en silencio.", 1.5, 40.5, "Fantasma, Veneno", "Assets/gengar.png");
            Frame aux = (Frame)this.Parent;
            aux.Navigate(typeof(InfoPage), gengar);
        }
    }
}
