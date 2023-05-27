using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class SeleccionPage : Page
    {
        public SeleccionPage()
        {
            this.InitializeComponent();
        }
        public ObservableCollection<Control> Pokemons { get; set; } = new ObservableCollection<Control>()
        {
            new ucGengar(),
            new ucPiplup()
        };
        public ObservableCollection<Control> Pokemons2 { get; set; } = new ObservableCollection<Control>()
        {
            new ucPiplup(),
            new ucGengar(),
            new ucPiplup()
        };

        private void btnLuchar_Click(object sender, RoutedEventArgs e)
        {
            var luchador1 = Pokemons[Luchador1.SelectedIndex];
            var luchador2 = Pokemons2[Luchador2.SelectedIndex];
            luchador1.GetType().GetMethod("verFondo")?.Invoke(luchador1, new object[] { false });
            luchador2.GetType().GetMethod("verFondo")?.Invoke(luchador2, new object[] { false });
            Frame aux = (Frame)this.Parent;
            aux.Navigate(typeof(CombatePage), new Control[] {luchador1, luchador2});
        }
    }
}
