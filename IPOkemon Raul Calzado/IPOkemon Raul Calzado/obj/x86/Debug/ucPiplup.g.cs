﻿#pragma checksum "C:\Users\pedri\OneDrive\Escritorio\IPOkemon\IPOkemon Raul Calzado\IPOkemon Raul Calzado\ucPiplup.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE14E9EB77D2FFC5755A342038F4E789A242F6B6D9C7E686DAB1A8D6A8626855"
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
    partial class ucPiplup : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            case 2: // ucPiplup.xaml line 13
                {
                    this.MoverAlas = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.MoverAlas).Completed += this.ataques_Completed;
                }
                break;
            case 3: // ucPiplup.xaml line 26
                {
                    this.MoverAlaIzq = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.MoverAlaIzq).Completed += this.ataques_Completed;
                }
                break;
            case 4: // ucPiplup.xaml line 32
                {
                    this.MoverAlaDer = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.MoverAlaDer).Completed += this.ataques_Completed;
                }
                break;
            case 5: // ucPiplup.xaml line 38
                {
                    this.Entristecer = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 6: // ucPiplup.xaml line 39
                {
                    this.sbAtaqueAla = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.sbAtaqueAla).Completed += this.ataques_Completed;
                }
                break;
            case 7: // ucPiplup.xaml line 56
                {
                    this.sbBurbuja = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.sbBurbuja).Completed += this.ataques_Completed;
                }
                break;
            case 8: // ucPiplup.xaml line 84
                {
                    this.Lanzarrocas = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.Lanzarrocas).Completed += this.ataques_Completed;
                }
                break;
            case 9: // ucPiplup.xaml line 104
                {
                    this.gridGeneral = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10: // ucPiplup.xaml line 116
                {
                    this.imFondo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 11: // ucPiplup.xaml line 118
                {
                    this.imgHeart = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12: // ucPiplup.xaml line 119
                {
                    this.imgShield = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13: // ucPiplup.xaml line 120
                {
                    this.imRPotion = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imRPotion).PointerPressed += this.usePotionRed;
                }
                break;
            case 14: // ucPiplup.xaml line 121
                {
                    this.imYPotion = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imYPotion).PointerPressed += this.usePotionYellow;
                }
                break;
            case 15: // ucPiplup.xaml line 276
                {
                    this.pbShield = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                    ((global::Windows.UI.Xaml.Controls.ProgressBar)this.pbShield).ValueChanged += this.pbShield_ValueChanged;
                }
                break;
            case 16: // ucPiplup.xaml line 273
                {
                    this.pbHealth = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 17: // ucPiplup.xaml line 139
                {
                    this.canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 18: // ucPiplup.xaml line 143
                {
                    this.ptCuerpo = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)this.ptCuerpo).PointerPressed += this.moverAlas;
                }
                break;
            case 19: // ucPiplup.xaml line 147
                {
                    global::Windows.UI.Xaml.Shapes.Ellipse element19 = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)element19).PointerPressed += this.cansar;
                }
                break;
            case 20: // ucPiplup.xaml line 149
                {
                    global::Windows.UI.Xaml.Shapes.Ellipse element20 = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)element20).PointerPressed += this.pararAlas;
                }
                break;
            case 21: // ucPiplup.xaml line 162
                {
                    global::Windows.UI.Xaml.Shapes.Path element21 = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)element21).PointerPressed += this.enfadar;
                }
                break;
            case 22: // ucPiplup.xaml line 163
                {
                    global::Windows.UI.Xaml.Shapes.Path element22 = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)element22).PointerPressed += this.agradar;
                }
                break;
            case 23: // ucPiplup.xaml line 164
                {
                    global::Windows.UI.Xaml.Shapes.Ellipse element23 = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)element23).PointerPressed += this.abrirPico;
                }
                break;
            case 24: // ucPiplup.xaml line 165
                {
                    this.ptLineaPico = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)this.ptLineaPico).PointerPressed += this.abrirPico;
                }
                break;
            case 25: // ucPiplup.xaml line 166
                {
                    this.ptLineaPicoTriste = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)this.ptLineaPicoTriste).PointerPressed += this.abrirPico;
                }
                break;
            case 26: // ucPiplup.xaml line 174
                {
                    this.elPupilaI = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.elPupilaI).PointerPressed += this.enfadarOjoI;
                }
                break;
            case 27: // ucPiplup.xaml line 185
                {
                    this.elPupilaII = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                    ((global::Windows.UI.Xaml.Shapes.Ellipse)this.elPupilaII).PointerPressed += this.enfadarOjoII;
                }
                break;
            case 28: // ucPiplup.xaml line 194
                {
                    this.elPupilaIzq = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 29: // ucPiplup.xaml line 195
                {
                    this.elPupilaDer = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 30: // ucPiplup.xaml line 205
                {
                    this.ptAlaIzq = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)this.ptAlaIzq).PointerPressed += this.moverAlaIzq;
                }
                break;
            case 31: // ucPiplup.xaml line 210
                {
                    this.ptAlaDer = (global::Windows.UI.Xaml.Shapes.Path)(target);
                    ((global::Windows.UI.Xaml.Shapes.Path)this.ptAlaDer).PointerPressed += this.moverAlaDer;
                }
                break;
            case 32: // ucPiplup.xaml line 216
                {
                    this.ptPicoAbierto = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 33: // ucPiplup.xaml line 217
                {
                    this.rcOjoIzqEnf = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 34: // ucPiplup.xaml line 222
                {
                    this.rcOjoDerEnf = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 35: // ucPiplup.xaml line 227
                {
                    this.rcOjoDerCan = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 36: // ucPiplup.xaml line 232
                {
                    this.rcOjoIzqCan = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 37: // ucPiplup.xaml line 237
                {
                    this.ptOjoIzqCer = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 38: // ucPiplup.xaml line 238
                {
                    this.ptOjoDerCer = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 39: // ucPiplup.xaml line 239
                {
                    this.elSonrojoDer = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 40: // ucPiplup.xaml line 240
                {
                    this.elSonrojoIzq = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 41: // ucPiplup.xaml line 241
                {
                    this.ptAtaque = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 42: // ucPiplup.xaml line 242
                {
                    this.Burbujas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 43: // ucPiplup.xaml line 263
                {
                    this.Sueno = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44: // ucPiplup.xaml line 264
                {
                    this.Roca = (global::Windows.UI.Xaml.Shapes.Path)(target);
                }
                break;
            case 45: // ucPiplup.xaml line 247
                {
                    this.Burbuja1 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 46: // ucPiplup.xaml line 252
                {
                    this.Burbuja2 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 47: // ucPiplup.xaml line 257
                {
                    this.Burbuja3 = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 48: // ucPiplup.xaml line 187
                {
                    this.ojoDerRojo = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 49: // ucPiplup.xaml line 176
                {
                    this.ojoIzqRojo = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 50: // ucPiplup.xaml line 131
                {
                    this.tbNombre = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 51: // ucPiplup.xaml line 132
                {
                    this.btnAtaqueAla = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAtaqueAla).Click += this.btnAtaqueAla_Click;
                }
                break;
            case 52: // ucPiplup.xaml line 133
                {
                    this.btnBurbuja = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBurbuja).Click += this.btnBurbuja_Click;
                }
                break;
            case 53: // ucPiplup.xaml line 134
                {
                    this.btnRoca = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRoca).Click += this.btnRoca_Click;
                }
                break;
            case 54: // ucPiplup.xaml line 135
                {
                    this.btnDescanso = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDescanso).Click += this.btnDescanso_Click;
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

