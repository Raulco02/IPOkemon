﻿#pragma checksum "C:\Users\pedri\OneDrive\Escritorio\IPOkemon\IPOkemon Raul Calzado\IPOkemon Raul Calzado\CombatePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C81F5D10773881270F52663DD1826811C2A5CDE0FDAEBED05B5F5F68E3B836E0"
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
    partial class CombatePage : 
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
            case 2: // CombatePage.xaml line 21
                {
                    this.lblEleccion = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // CombatePage.xaml line 22
                {
                    this.btn1jug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn1jug).Click += this.btn1jug_Click;
                }
                break;
            case 4: // CombatePage.xaml line 23
                {
                    this.btn2jug = (global::Windows.UI.Xaml.Controls.Button)(target);
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
