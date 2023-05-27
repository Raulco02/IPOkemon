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
    public class CombateViewModel
    {
        public Control Luchador1 { get; set; }
        public Control Luchador2 { get; set; }
    }
    public sealed partial class CombatePage : Page
    {
        public Control luchador1;
        public Control luchador2;
        public CombatePage()
        {
            this.InitializeComponent();
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
            Control[] luchadores = e.Parameter as Control[];
            
            luchador1 = luchadores[0];
            luchador2 = luchadores[1];
            luchador2.GetType().GetMethod("verAcciones")?.Invoke(luchador2, new object[] { false });

            var viewModel = new CombateViewModel()
            {
                Luchador1 = luchador1,
                Luchador2 = luchador2
            };

            DataContext = viewModel;
        }
    }
}
