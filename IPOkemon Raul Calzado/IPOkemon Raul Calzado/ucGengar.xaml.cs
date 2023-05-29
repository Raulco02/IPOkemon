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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace IPOkemon_Raul_Calzado
{
    public sealed partial class ucGengar : UserControl
    {
        DispatcherTimer dtTime;
        public String Nombre { get; set; }
        public ucGengar()
        {
            this.InitializeComponent();
            Nombre = "gengar";
        }

        private void imgPocionVida_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseHealth;
            dtTime.Start();
            this.imgPocionVida.Opacity = 0.5;
        }

        private void increaseHealth(object sender, object e)
        {
            this.pbVida.Value += 0.2;
            if (pbVida.Value >= 100)
            {
                this.dtTime.Stop();
                this.imgPocionVida.Opacity = 1;
            }
        }

        private void imgPocionEnergia_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseEnergy;
            dtTime.Start();
            this.imgPocionEnergia.Opacity = 0.5;
        }

        private void increaseEnergy(object sender, object e)
        {
            this.pbEnergia.Value += 0.2;
            if (pbEnergia.Value >= 100)
            {
                this.dtTime.Stop();
                this.imgPocionEnergia.Opacity = 1;
            }
        }

        private void txtGengar_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb_2 = (Storyboard)this.Resources["MoverCola"];

            DoubleAnimation da = new DoubleAnimation();
            Storyboard sb = new Storyboard();
            sb.Duration = new Duration(TimeSpan.FromMilliseconds(300));
            sb.Children.Add(da);
            sb.BeginTime = TimeSpan.FromSeconds(0);
            ptBoca.RenderTransform = (Transform)new ScaleTransform();
            Storyboard.SetTarget(da, ptBoca.RenderTransform);
            Storyboard.SetTargetProperty(da, "ScaleY");
            da.From = 1;
            da.To = 1.2;
            sb.AutoReverse = true;
            sb.RepeatBehavior = new RepeatBehavior(3);
            sb.Begin();
            sb_2.Begin();
        }

        private void imgAtacar_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["Ataque"];
            if (pbEnergia.Value >= 20)
            {
                sb.Begin();
                this.pbEnergia.Value -= 20;
            }
        }

        private void imgMuerte_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionMuerte"];
            sb.Begin();
            pbVida.Value = 0;
            pbEnergia.Value = 0;
        }

        private void imgDescansar_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb_z = (Storyboard)this.Resources["MovimientoZ"];
            Storyboard sb_cerrar_ojos = (Storyboard)this.Resources["CerrarOjos"];
            sb_cerrar_ojos.Begin();
            sb_z.Begin();
            this.pbEnergia.Value += 5;
        }

        private void imgEscudo_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["AnimacionEscudo"];
            if (pbEnergia.Value >= 20)
            {
                sb.Begin();
                this.pbEnergia.Value -= 20;
            }
        }

        public void verFondo(bool verfondo)
        {
            if (!verfondo) { this.imgFondo.Source = null; }
        }

        public void verBarras(bool verbarras)
        {
            if (!verbarras)
            {
                this.pbVida.Visibility = Visibility.Collapsed;
                this.pbEnergia.Visibility = Visibility.Collapsed;
                this.imgPocionEnergia.Source = null;
                this.imgPocionVida.Source = null;
                this.imgVida.Source = null;
                this.imgEnergia.Source = null;
            }
        }

        public void verAcciones(bool veracciones)
        {
            if (!veracciones)
            {
                this.imgMuerte.Source = null;
                this.imgDescansar.Source = null;
                this.imgAtacar.Source = null;
                this.imgEscudo.Source = null;
            }
        }
    }
}

