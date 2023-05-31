using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Core;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace IPOkemon_Raul_Calzado
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public System.Threading.Timer timer;
        private int segundosRestantes;
        ResourceLoader resourceLoader;

        public MainPage()
        {
            this.InitializeComponent();

            tiles();

            segundosRestantes = 120;
            timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);

            fmMain.Navigate(typeof(InicioPage));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            SystemNavigationManager.GetForCurrentView().BackRequested += MainPage_BackRequested;

            string defaultLanguage = Windows.Globalization.ApplicationLanguages.Languages[0];

            // Crear un ResourceContext utilizando el idioma predeterminado
            var resourceContext = ResourceContext.GetForCurrentView();
            resourceContext.Languages = new List<string> { defaultLanguage };

            // Obtener el ResourceLoader utilizando el ResourceContext
            resourceLoader = ResourceLoader.GetForCurrentView();
        }

        private void tiles()
        {
            TileContent content = new TileContent()
            {
                Visual = new TileVisual()
                {
                    TileMedium = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children =
                            {
                             new AdaptiveText()
                             {
                                    Text = "IPOkemon",
                                    HintStyle = AdaptiveTextStyle.Subtitle
                             },
                             new AdaptiveText()
                             {
                                 Text = "Un proyecto de IPO2",
                                 HintStyle = AdaptiveTextStyle.CaptionSubtle
                             },
                             }
                        }
                    },
                    TileWide = new TileBinding()
                    {
                        Branding = TileBranding.NameAndLogo,
                        DisplayName = "Version 1.0",
                        Content = new TileBindingContentAdaptive()
                        {
                            Children = {
                             new AdaptiveText()
                             {
                                Text = "IPOkemon",
                                HintStyle = AdaptiveTextStyle.Subtitle
                             },
                             new AdaptiveText()
                             {
                                Text = "Un Proyecto de IPO2",
                                HintStyle = AdaptiveTextStyle.CaptionSubtle
                             },
                             new AdaptiveText()
                             {
                                Text = "Una aplicación sobre Pokemon hecha con tecnología UWP",
                                HintWrap = true,
                             }
                        }
                        }
                    },
                    TileLarge = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            Children = {
                             new AdaptiveText()
                            {
                                 Text = "IPOkemon",
                                 HintStyle = AdaptiveTextStyle.Subtitle
                             },
                             new AdaptiveText()
                             {
                                 Text = "Un Proyecto de IPO2",
                                 HintStyle = AdaptiveTextStyle.CaptionSubtle
                             },
                             new AdaptiveText()
                            {
                                 Text = "Una aplicación sobre Pokemon hecha con tecnología UWP",
                                 HintStyle = AdaptiveTextStyle.CaptionSubtle
                             }
                            }
                        }
                    },
                }
            };
            var notification = new TileNotification(content.GetXml());
            notification.ExpirationTime = DateTimeOffset.UtcNow.AddSeconds(30);
            var updater = TileUpdateManager.CreateTileUpdaterForApplication();
            updater.Update(notification);
        }

        private void TimerCallback(object state)
        {
            segundosRestantes--;

            if (segundosRestantes <= 0)
            {
                CancelarTemporizador();
                new ToastContentBuilder()
                            .AddArgument("action", "Combate")
                            .AddArgument("conversationId", 9813)
                            .AddText("¡Ven a combatir contra otros Pokémon!")
                            .AddText("Puedes combatir accediendo a la sección de Combate")
                            .Show();
            }
        }

        private void CancelarTemporizador()
        {
            timer.Dispose();
        }

        private void MainPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            var currentPage = fmMain.Content as Page;
            if (currentPage is PokedexPage || currentPage is CombatePage || currentPage is AcercaPage)
            {
                fmMain.Navigate(typeof(InicioPage));
                e.Handled = true;
            }
            else if (fmMain.CanGoBack)
            {
                fmMain.GoBack();
                e.Handled = true;
            }
        }

        private void fmMain_Navigated(object sender, NavigationEventArgs e)
        {
            var currentPage = fmMain.Content as Page;
            if (currentPage is PokedexPage || currentPage is CombatePage || currentPage is AcercaPage)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void irPokedex(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(PokedexPage));
        }
        private void irCombate(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(JugadoresPage), this);
        }
        private void irCuidar(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(CuidarPage));
        }
        private void irAcerca(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(AcercaPage));
        }
        private void irInicio(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(InicioPage));

        }
        private async void CambiarIdioma_Click(object sender, RoutedEventArgs e)
        {
            string titulo = resourceLoader.GetString("tituloCambioIdioma"); ;
            string contenido = resourceLoader.GetString("contenidoCambioIdioma"); ;
            string cancelar = resourceLoader.GetString("cancelar"); ;
            ContentDialog dialog = new ContentDialog
            {
                Title = titulo,
                Content = contenido,
                CloseButtonText = cancelar
            };

            // Agrega opciones de idioma al diálogo
            dialog.PrimaryButtonText = "Español";
            dialog.PrimaryButtonClick += (dialogSender, args) =>
            {
                CambiarIdioma("es-ES"); // Cambiar al idioma español
            };

            dialog.SecondaryButtonText = "English";
            dialog.SecondaryButtonClick += (dialogSender, args) =>
            {
                CambiarIdioma("en-US"); // Cambiar al idioma inglés
            };

            await dialog.ShowAsync();
        }
        private void CambiarIdioma(string codigoIdioma)
        {
            ApplicationLanguages.PrimaryLanguageOverride = codigoIdioma;
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(rootFrame.Content.GetType());

        }
        private void btnCompactar_Click(object sender, RoutedEventArgs e)
        {
            sView.IsPaneOpen = !sView.IsPaneOpen;
        }
        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 720)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactInline;
                sView.IsPaneOpen = true;
            }
            else if (Width >= 360)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                sView.IsPaneOpen = false;
            }
            else
            {
                sView.DisplayMode = SplitViewDisplayMode.Overlay;
                sView.IsPaneOpen = false;
            }
        }
    }
}