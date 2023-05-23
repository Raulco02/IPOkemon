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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace IPOkemon_Raul_Calzado
{
    public sealed partial class ucPiplup : UserControl
    {
        DispatcherTimer dtTime;
        bool cansado;
        bool alasParadas;
        public ucPiplup()
        {
            this.InitializeComponent();
            moverAlasPermanent(0.5);
        }

        public double Vida
        {
            get { return this.pbHealth.Value; }
            set { this.pbHealth.Value = value; }
        }

        public int Escudo
        {
            get { return Escudo; }
            set { Escudo = value; }
        }

        public void verFondo(bool verfondo)
        {
            if (!verfondo) { this.imFondo.Source = null; }
            else
            {
                imFondo.Source = new BitmapImage(new Uri("ms-appx:///Assets/mountain.jpg", UriKind.Absolute));

                //imFondo.Source = new BitmapImage(new Uri("/Assets/mountain.jpg", UriKind.Relative));
            }
        }

        public void verBarraVida(bool verbarraVida)
        {
            if(!verbarraVida) { 
                this.pbHealth.Visibility = Visibility.Collapsed; 
                this.imgHeart.Visibility = Visibility.Collapsed;
                this.imRPotion.Visibility = Visibility.Collapsed;
            }
            else { 
                this.pbHealth.Visibility = Visibility.Visible;
                this.imgHeart.Visibility = Visibility.Visible;
                this.imRPotion.Visibility = Visibility.Visible;
            }
        }

        public void verBarraEscudo(bool verbarraEscudo)
        {
            if (!verbarraEscudo) { 
                this.pbShield.Visibility = Visibility.Collapsed; 
                this.imgShield.Visibility = Visibility.Collapsed;
                this.imYPotion.Visibility = Visibility.Collapsed;
            }
            else { 
                this.pbShield.Visibility = Visibility.Visible;
                this.imgShield.Visibility = Visibility.Visible;
                this.imYPotion.Visibility = Visibility.Visible;
            }
        }

        public void verBotonesAtaques(bool verbotonesAtaques)
        {
            if (!verbotonesAtaques)
            {
                this.btnAtaqueAla.Visibility = Visibility.Collapsed;
                this.btnBurbuja.Visibility = Visibility.Collapsed;
                this.btnRoca.Visibility = Visibility.Collapsed;
                this.btnDescanso.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.btnAtaqueAla.Visibility = Visibility.Visible;
                this.btnBurbuja.Visibility = Visibility.Visible;
                this.btnRoca.Visibility = Visibility.Visible;
                this.btnDescanso.Visibility = Visibility.Visible;
            }
        }

        public void verNombre(bool vernombre)
        {
            if (!vernombre) { this.tbNombre.Visibility = Visibility.Collapsed; }
            else { this.tbNombre.Visibility = Visibility.Visible; }
        }

        public void pararMovimientoAlas()
        {
            accionPararAlas();
        }

        public void movimientoAlas()
        {
            alasParadas = false;
            this.pbShield.Value = this.pbShield.Value + 1;
            this.pbShield.Value = this.pbShield.Value - 1;
        }

        public void animacionAgradar()
        {
            agradar();
        }

        public void animacionCansar()
        {
            accionCansar(false, true);
            entristecer();
        }

        public void animacionEnfadar()
        {
            accionEnfadar();
        }

        public void animacionPico()
        {
            accionAbrirPico(2000, 0);
        }

        public void animacionAtaqueAla()
        {
            ataqueAla();
        }

        public void animacionBurbuja()
        {
            burbuja();
        }

        public void animacionDescanso()
        {
            descansoclick();
        }

        public void animacionLanzarrocas()
        {
            lanzarrocas();
        }

        private void usePotionRed(object sender, PointerRoutedEventArgs e)
        {
            agradar();
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseHealth;
            dtTime.Start();
            this.imRPotion.Opacity = 0.5;
        }
        private void increaseHealth(object sender, object e)
        {
            this.pbHealth.Value += 0.2;
            if (pbHealth.Value >= 100)
            {
                this.dtTime.Stop();
                this.imRPotion.Opacity = 1;
                moverAlasPermanent(1);
                accionEnfadar();
            }
        }
        private void usePotionYellow(object sender, PointerRoutedEventArgs e)
        {
            agradar();
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += increaseShield;
            dtTime.Start();
            this.imYPotion.Opacity = 0.5;
        }
        private void increaseShield(object sender, object e)
        {
            this.pbShield.Value += 0.2;
            if (pbShield.Value >= 100)
            {
                this.dtTime.Stop();
                this.imYPotion.Opacity = 1;
                moverAlasPermanent(1);
                accionEnfadar();
            }
        }
        private void enfadarOjoI(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.elPupilaI.Resources["ojoIzqRojoKey"];
            desactivarBotones();
            sb.Completed += ataques_Completed;
            sb.Begin();
        }
        private void enfadarOjoII(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.elPupilaII.Resources["ojoDerRojoKey"];
            desactivarBotones();
            sb.Completed += ataques_Completed;
            sb.Begin();
        }
        private void enfadar(object sender, PointerRoutedEventArgs e)
        {
            accionEnfadar();
        }
        private void accionEnfadar()
        {
            Storyboard sbOjoIzqR = (Storyboard)this.elPupilaI.Resources["ojoIzqRojoKey"];
            Storyboard sbOjoDerR = (Storyboard)this.elPupilaII.Resources["ojoDerRojoKey"];
            sbOjoIzqR.Begin();
            sbOjoDerR.Begin();
            accionAbrirPico(2000, 0);
            enfadarOjos();
        }
        private void cansar(object sender, PointerRoutedEventArgs e)
        {
            accionCansar(false, true);
            entristecer();
        }
        private void pararAlas(object sender, PointerRoutedEventArgs e)
        {
            accionPararAlas();
        }
        private void accionPararAlas()
        {
            if (alasParadas == false)
            {
                Storyboard sb = (Storyboard)this.Resources["MoverAlas"];
                sb.Stop();
                alasParadas = true;
            }
            else
            {
                moverAlasPermanent(0.5);
                alasParadas = false;
            }
        }
        private void abrirPico(object sender, PointerRoutedEventArgs e)
        {
            accionAbrirPico(2000, 0);
        }
        private void agradar(object sender, PointerRoutedEventArgs e)
        {
            agradar();
        }
        private void accionAbrirPico(int duracion, int comienzo)
        {
            Storyboard sb = new Storyboard();
            sb.Duration = new Duration(TimeSpan.FromMilliseconds(duracion));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, ptPicoAbierto);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(duracion));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb.Children.Add(oa);
            sb.BeginTime = TimeSpan.FromMilliseconds(comienzo);
            Storyboard.SetTarget(oa, ptPicoAbierto);
            sb.Begin();
        }
        private void enfadarOjos()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, rcOjoDerEnf);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, rcOjoDerEnf);

            Storyboard sb2 = new Storyboard();
            sb2.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa2 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa2, rcOjoIzqEnf);
            Storyboard.SetTargetProperty(oa2, "Visibility");

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf3.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf4 = new DiscreteObjectKeyFrame();
            kf4.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf4.Value = Visibility.Collapsed;

            oa2.KeyFrames.Add(kf3);
            oa2.KeyFrames.Add(kf4);

            sb2.Children.Add(oa2);
            sb2.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa2, rcOjoIzqEnf);

            desactivarBotones();
            sb1.Completed += ataques_Completed;

            sb1.Begin();
            sb2.Begin();
        }
        private void accionCansar(bool permanente, bool hacerAccion)
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, rcOjoDerCan);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, rcOjoDerCan);

            Storyboard sb2 = new Storyboard();
            sb2.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa2 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa2, rcOjoIzqCan);
            Storyboard.SetTargetProperty(oa2, "Visibility");

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf3.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf4 = new DiscreteObjectKeyFrame();
            kf4.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf4.Value = Visibility.Collapsed;

            oa2.KeyFrames.Add(kf3);
            oa2.KeyFrames.Add(kf4);

            sb2.Children.Add(oa2);
            sb2.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa2, rcOjoIzqCan);

            if (permanente)
            {
                sb1.RepeatBehavior = RepeatBehavior.Forever;
                sb2.RepeatBehavior = RepeatBehavior.Forever;
            }

            //desactivarBotones();
            //sb1.Completed += ataques_Completed;
            if (hacerAccion)
            {
                sb1.Begin();
                sb2.Begin();
            }
        }
        /// <summary>
        /// /////////
        /// </summary>
        private void accionCansarPermanente(bool parar)
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, rcOjoDerCan);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, rcOjoDerCan);

            Storyboard sb2 = new Storyboard();
            sb2.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa2 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa2, rcOjoIzqCan);
            Storyboard.SetTargetProperty(oa2, "Visibility");

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf3.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf4 = new DiscreteObjectKeyFrame();
            kf4.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf4.Value = Visibility.Collapsed;

            oa2.KeyFrames.Add(kf3);
            oa2.KeyFrames.Add(kf4);

            sb2.Children.Add(oa2);
            sb2.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa2, rcOjoIzqCan);


            sb1.RepeatBehavior = RepeatBehavior.Forever;
            sb2.RepeatBehavior = RepeatBehavior.Forever;

            sb1.Begin();
            sb2.Begin();

            if (parar)
            {
                sb1.Stop();
                sb2.Stop();
            }

        }
        private void entristecer()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, ptLineaPico);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Visible;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, ptLineaPico);

            Storyboard sb2 = new Storyboard();
            sb2.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa2 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa2, ptLineaPicoTriste);
            Storyboard.SetTargetProperty(oa2, "Visibility");

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf3.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf4 = new DiscreteObjectKeyFrame();
            kf4.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf4.Value = Visibility.Collapsed;

            oa2.KeyFrames.Add(kf3);
            oa2.KeyFrames.Add(kf4);

            sb2.Children.Add(oa2);
            sb2.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa2, ptLineaPicoTriste);

            desactivarBotones();
            sb1.Completed += ataques_Completed;

            sb1.Begin();
            sb2.Begin();
        }
        private void agradar()
        {
            cerrarOjoIzq();
            cerrarOjoDer();
            sonrojar();
        }
        private void cerrarOjoIzq()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, ptOjoIzqCer);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, ptOjoIzqCer);

            Storyboard sb2 = new Storyboard();
            sb2.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa2 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa2, elPupilaI);
            Storyboard.SetTargetProperty(oa2, "Visibility");

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf3.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf4 = new DiscreteObjectKeyFrame();
            kf4.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf4.Value = Visibility.Visible;

            oa2.KeyFrames.Add(kf3);
            oa2.KeyFrames.Add(kf4);

            sb2.Children.Add(oa2);
            sb2.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa2, elPupilaI);

            Storyboard sb4 = new Storyboard();
            sb4.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa4 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa4, elPupilaIzq);
            Storyboard.SetTargetProperty(oa4, "Visibility");

            DiscreteObjectKeyFrame kf7 = new DiscreteObjectKeyFrame();
            kf7.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf7.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf8 = new DiscreteObjectKeyFrame();
            kf8.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf8.Value = Visibility.Visible;

            oa4.KeyFrames.Add(kf7);
            oa4.KeyFrames.Add(kf8);

            sb4.Children.Add(oa4);
            sb4.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa4, elPupilaIzq);

            desactivarBotones();
            sb1.Completed += ataques_Completed;

            sb1.Begin();
            sb2.Begin();
            sb4.Begin();
        }
        private void cerrarOjoDer()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, ptOjoDerCer);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, ptOjoDerCer);

            Storyboard sb3 = new Storyboard();
            sb3.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa3 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa3, elPupilaII);
            Storyboard.SetTargetProperty(oa3, "Visibility");

            DiscreteObjectKeyFrame kf5 = new DiscreteObjectKeyFrame();
            kf5.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf5.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf6 = new DiscreteObjectKeyFrame();
            kf6.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf6.Value = Visibility.Visible;

            oa3.KeyFrames.Add(kf5);
            oa3.KeyFrames.Add(kf6);

            sb3.Children.Add(oa3);
            sb3.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa3, elPupilaII);

            Storyboard sb4 = new Storyboard();
            sb4.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa4 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa4, elPupilaDer);
            Storyboard.SetTargetProperty(oa4, "Visibility");

            DiscreteObjectKeyFrame kf7 = new DiscreteObjectKeyFrame();
            kf7.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf7.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf8 = new DiscreteObjectKeyFrame();
            kf8.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf8.Value = Visibility.Visible;

            oa4.KeyFrames.Add(kf7);
            oa4.KeyFrames.Add(kf8);

            sb4.Children.Add(oa4);
            sb4.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa4, elPupilaDer);

            //desactivarBotones();
            //sb1.Completed += ataques_Completed;

            sb1.Begin();
            sb3.Begin();
            sb4.Begin();
        }
        private void sonrojar()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, elSonrojoIzq);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, elSonrojoIzq);

            Storyboard sb2 = new Storyboard();
            sb2.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa2 = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa2, elSonrojoDer);
            Storyboard.SetTargetProperty(oa2, "Visibility");

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf3.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf4 = new DiscreteObjectKeyFrame();
            kf4.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf4.Value = Visibility.Collapsed;

            oa2.KeyFrames.Add(kf3);
            oa2.KeyFrames.Add(kf4);

            sb2.Children.Add(oa2);
            sb2.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa2, elSonrojoDer);

            desactivarBotones();
            sb1.Completed += ataques_Completed;

            sb1.Begin();
            sb2.Begin();
        }
        private void mostrarPtAla()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, ptAtaque);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(400));
            kf2.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(1000));
            kf3.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);
            oa.KeyFrames.Add(kf3);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, ptAtaque);

            sb1.Begin();
        }
        private void mostrarBurbujas()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, Burbujas);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            kf2.Value = Visibility.Collapsed;

            /*DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(100));
            kf3.Value = Visibility.Visible;
            */
            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);
            //oa.KeyFrames.Add(kf3);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromMilliseconds(300);
            Storyboard.SetTarget(oa, Burbujas);

            sb1.Begin();
        }
        private void descanso()
        {
            accionCansar(false, true);
            Storyboard sb = (Storyboard)this.Resources["MoverAlas"];
            sb.Stop();
            cerrarOjoDer();
            cerrarOjoIzq();
            mostrarLetras();
        }
        private void mostrarLetras()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, Sueno);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(2000));
            kf2.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);

            sb1.Children.Add(oa);
            sb1.BeginTime = TimeSpan.FromSeconds(0);
            Storyboard.SetTarget(oa, Sueno);

            sb1.Completed += descanso_Completed;

            sb1.Begin();
        }
        private void mostrarRoca()
        {
            Storyboard sb1 = new Storyboard();
            sb1.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            ObjectAnimationUsingKeyFrames oa = new ObjectAnimationUsingKeyFrames();
            Storyboard.SetTarget(oa, Roca);
            Storyboard.SetTargetProperty(oa, "Visibility");

            DiscreteObjectKeyFrame kf1 = new DiscreteObjectKeyFrame();
            kf1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0));
            kf1.Value = Visibility.Collapsed;

            DiscreteObjectKeyFrame kf2 = new DiscreteObjectKeyFrame();
            kf2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(200));
            kf2.Value = Visibility.Visible;

            DiscreteObjectKeyFrame kf3 = new DiscreteObjectKeyFrame();
            kf3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            kf3.Value = Visibility.Collapsed;

            oa.KeyFrames.Add(kf1);
            oa.KeyFrames.Add(kf2);
            oa.KeyFrames.Add(kf3);

            sb1.Children.Add(oa);
            sb1.Begin();
        }
        private void moverAlas(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["MoverAlas"];
            sb.AutoReverse = true;
            sb.SpeedRatio = 1;
            sb.RepeatBehavior = new RepeatBehavior(3);
            sb.Begin();
        }
        private void moverAlasPermanent(double speedRatio)
        {
            Storyboard sb = (Storyboard)this.Resources["MoverAlas"];
            sb.AutoReverse = true;
            sb.RepeatBehavior = RepeatBehavior.Forever;
            sb.SpeedRatio = speedRatio;
            sb.Begin();
        }
        private void moverAlaDer(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["MoverAlaDer"];
            sb.AutoReverse = true;
            sb.Begin();
        }
        private void moverAlaIzq(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)this.Resources["MoverAlaIzq"];
            sb.AutoReverse = true;
            sb.Begin();
        }
        private void btnAtaqueAla_Click(object sender, RoutedEventArgs e)
        {
            ataqueAla();
        }
        private void ataqueAla()
        {
            int dano = 10;
            if (pbShield.Value - dano >= 0)
            {
                Storyboard sb = (Storyboard)this.Resources["sbAtaqueAla"];
                mostrarPtAla();
                sb.Begin();
                pbShield.Value -= dano;
                desactivarBotones();
                if (pbShield.Value >= 30)
                {
                    accionCansar(false, false);
                }
            }
            else
            {
                accionCansar(false, true);
                entristecer();
            }
        }
        private void ataques_Completed(object sender, object e)
        {
            btnAtaqueAla.IsEnabled = true;
            btnBurbuja.IsEnabled = true;
            btnDescanso.IsEnabled = true;
            btnRoca.IsEnabled = true;
            if (pbShield.Value > 30)
            {
                if (alasParadas == false)
                {
                    if (pbShield.Value != 100)
                        moverAlasPermanent(0.5);
                    else
                        moverAlasPermanent(1);
                }
            }
            else
            {
                Storyboard sb = (Storyboard)this.Resources["MoverAlas"];
                sb.Stop();
                cansado = true;
                accionCansar(true, true);
            }

            if (pbHealth.Value <= 20)
            {
                cerrarOjoDer();
                accionAbrirPico(2000, 0);
                moverAlasPermanent(0.2);
            }
        }
        private void descanso_Completed(object sender, object e)
        {
            btnAtaqueAla.IsEnabled = true;
            btnBurbuja.IsEnabled = true;
            btnDescanso.IsEnabled = true;
            btnRoca.IsEnabled = true;
            if (alasParadas == false)
                moverAlasPermanent(1);
            accionEnfadar();
        }
        private void btnBurbuja_Click(object sender, RoutedEventArgs e)
        {
            burbuja();
        }
        private void burbuja()
        {
            int dano = 25;
            if (pbShield.Value - dano >= 0)
            {
                Storyboard sb = (Storyboard)this.Resources["sbBurbuja"];
                accionAbrirPico(1000, 300);
                mostrarBurbujas();
                sb.Begin();
                pbShield.Value -= dano;
                desactivarBotones();
            }
            else
            {
                accionCansar(false, true);
                entristecer();
            }
        }

        private void btnDescanso_Click(object sender, RoutedEventArgs e)
        {
            descansoclick();
        }

        private void descansoclick()
        {
            descanso();
            pbHealth.Value = 100;
            pbShield.Value = 100;
            desactivarBotones();
        }

        private void btnRoca_Click(object sender, RoutedEventArgs e)
        {
            lanzarrocas();
        }
        private void lanzarrocas()
        {
            int dano = 40;
            if (pbShield.Value - dano >= 0)
            {
                pbHealth.Value -= 10;
                Storyboard sb = (Storyboard)this.Resources["Lanzarrocas"];
                sb.Begin();
                pbShield.Value -= dano;
                mostrarRoca();
                desactivarBotones();
            }
            else
            {
                accionCansar(false, true);
                entristecer();
            }
        }
        private void desactivarBotones()
        {
            btnAtaqueAla.IsEnabled = false;
            btnBurbuja.IsEnabled = false;
            btnDescanso.IsEnabled = false;
            btnRoca.IsEnabled = false;
        }

        private void pbShield_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (cansado && pbShield.Value > 30)
            {
                accionCansarPermanente(true);
                cansado = false;
                if (alasParadas == false)
                {
                    if (pbShield.Value != 100)
                        moverAlasPermanent(0.5);
                }
            }
        }
    }
}
        
