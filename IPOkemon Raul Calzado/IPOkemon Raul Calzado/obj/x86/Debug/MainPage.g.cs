﻿#pragma checksum "C:\Users\Usuario\Desktop\Apuntes\IPO2\Lab\sincro2\IPOkemon\IPOkemon Raul Calzado\IPOkemon Raul Calzado\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "598B7C785E99015C550260662518CF6312BBFCEDF770622477B3FA5F5CF1CB0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPOkemon_Raul_Calzado
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 27
                {
                    this.sView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element3 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element3).PointerPressed += this.irInicio;
                }
                break;
            case 4: // MainPage.xaml line 43
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element4 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element4).PointerPressed += this.irPokedex;
                }
                break;
            case 5: // MainPage.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element5 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element5).PointerPressed += this.irCombate;
                }
                break;
            case 6: // MainPage.xaml line 45
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element6 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element6).PointerPressed += this.irCuidar;
                }
                break;
            case 7: // MainPage.xaml line 46
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element7 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element7).PointerPressed += this.irAcerca;
                }
                break;
            case 8: // MainPage.xaml line 47
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element8 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element8).PointerPressed += this.CambiarIdioma_Click;
                }
                break;
            case 9: // MainPage.xaml line 48
                {
                    this.btnInicio = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnInicio).Click += this.irInicio;
                }
                break;
            case 10: // MainPage.xaml line 49
                {
                    this.btnPokedex = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPokedex).Click += this.irPokedex;
                }
                break;
            case 11: // MainPage.xaml line 50
                {
                    this.btnCombate = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCombate).Click += this.irCombate;
                }
                break;
            case 12: // MainPage.xaml line 51
                {
                    this.btnPractica = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPractica).Click += this.irCuidar;
                }
                break;
            case 13: // MainPage.xaml line 52
                {
                    this.btnAcerca = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAcerca).Click += this.irAcerca;
                }
                break;
            case 14: // MainPage.xaml line 53
                {
                    this.btnIdioma = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnIdioma).Click += this.CambiarIdioma_Click;
                }
                break;
            case 15: // MainPage.xaml line 56
                {
                    this.fmMain = (global::Windows.UI.Xaml.Controls.Frame)(target);
                    ((global::Windows.UI.Xaml.Controls.Frame)this.fmMain).Navigated += this.fmMain_Navigated;
                }
                break;
            case 16: // MainPage.xaml line 22
                {
                    this.btnCompactar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCompactar).Click += this.btnCompactar_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

