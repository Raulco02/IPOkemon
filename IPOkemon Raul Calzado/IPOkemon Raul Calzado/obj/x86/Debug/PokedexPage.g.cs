﻿#pragma checksum "C:\Users\pedri\OneDrive\Escritorio\IPOkemon\IPOkemon Raul Calzado\IPOkemon Raul Calzado\PokedexPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC47C45CE432255F9BFDA6889E45529F42DDA1854B55138D10636BC14EE3BFF9"
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
    partial class PokedexPage : 
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
            case 2: // PokedexPage.xaml line 31
                {
                    this.StyledGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 4: // PokedexPage.xaml line 49
                {
                    this.ucPiplup = (global::IPOkemon_Raul_Calzado.ucPiplup)(target);
                    ((global::IPOkemon_Raul_Calzado.ucPiplup)this.ucPiplup).PointerPressed += this.ucPiplup1_PointerPressed;
                }
                break;
            case 5: // PokedexPage.xaml line 50
                {
                    this.ucGengar = (global::IPOkemon_Raul_Calzado.ucGengar)(target);
                    ((global::IPOkemon_Raul_Calzado.ucGengar)this.ucGengar).PointerPressed += this.ucGengar_PointerPressed;
                }
                break;
            case 6: // PokedexPage.xaml line 51
                {
                    this.ucPiplup3 = (global::IPOkemon_Raul_Calzado.ucPiplup)(target);
                }
                break;
            case 7: // PokedexPage.xaml line 52
                {
                    this.ucGengar4 = (global::IPOkemon_Raul_Calzado.ucGengar)(target);
                }
                break;
            case 8: // PokedexPage.xaml line 53
                {
                    this.ucPiplup5 = (global::IPOkemon_Raul_Calzado.ucPiplup)(target);
                }
                break;
            case 9: // PokedexPage.xaml line 54
                {
                    this.ucGengar6 = (global::IPOkemon_Raul_Calzado.ucGengar)(target);
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

