﻿#pragma checksum "C:\Users\pedri\OneDrive\Escritorio\IPOkemon\IPOkemon Raul Calzado\IPOkemon Raul Calzado\SeleccionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41E09D56D994E574FE36DDB519097B725284F6AC26E533A7BEF68B0448442C63"
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
    partial class SeleccionPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SeleccionPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISeleccionPage_Bindings
        {
            private global::IPOkemon_Raul_Calzado.SeleccionPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.FlipView obj2;
            private global::Windows.UI.Xaml.Controls.FlipView obj3;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj3ItemsSourceDisabled = false;

            private SeleccionPage_obj1_BindingsTracking bindingsTracking;

            public SeleccionPage_obj1_Bindings()
            {
                this.bindingsTracking = new SeleccionPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 20 && columnNumber == 177)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 176)
                {
                    isobj3ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // SeleccionPage.xaml line 20
                        this.obj2 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        this.bindingsTracking.RegisterTwoWayListener_2(this.obj2);
                        break;
                    case 3: // SeleccionPage.xaml line 28
                        this.obj3 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ISeleccionPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::IPOkemon_Raul_Calzado.SeleccionPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::IPOkemon_Raul_Calzado.SeleccionPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Pokemons(obj.Pokemons, phase);
                        this.Update_Pokemons2(obj.Pokemons2, phase);
                    }
                }
            }
            private void Update_Pokemons(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Pokemons(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SeleccionPage.xaml line 20
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_Pokemons2(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Pokemons2(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // SeleccionPage.xaml line 28
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_2_ItemsSource()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Pokemons = (global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control>)this.obj2.ItemsSource;
                    }
                }
            }
            private void UpdateTwoWay_3_ItemsSource()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Pokemons2 = (global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control>)this.obj3.ItemsSource;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SeleccionPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SeleccionPage_obj1_Bindings> weakRefToBindingObj; 

                public SeleccionPage_obj1_BindingsTracking(SeleccionPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SeleccionPage_obj1_Bindings>(obj);
                }

                public SeleccionPage_obj1_Bindings TryGetBindingObject()
                {
                    SeleccionPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_Pokemons(null);
                    UpdateChildListeners_Pokemons2(null);
                }

                public void PropertyChanged_Pokemons(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SeleccionPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Pokemons(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    SeleccionPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> cache_Pokemons = null;
                public void UpdateChildListeners_Pokemons(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj)
                {
                    if (obj != cache_Pokemons)
                    {
                        if (cache_Pokemons != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Pokemons).PropertyChanged -= PropertyChanged_Pokemons;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_Pokemons).CollectionChanged -= CollectionChanged_Pokemons;
                            cache_Pokemons = null;
                        }
                        if (obj != null)
                        {
                            cache_Pokemons = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Pokemons;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_Pokemons;
                        }
                    }
                }
                public void PropertyChanged_Pokemons2(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SeleccionPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_Pokemons2(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    SeleccionPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> cache_Pokemons2 = null;
                public void UpdateChildListeners_Pokemons2(global::System.Collections.ObjectModel.ObservableCollection<global::Windows.UI.Xaml.Controls.Control> obj)
                {
                    if (obj != cache_Pokemons2)
                    {
                        if (cache_Pokemons2 != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Pokemons2).PropertyChanged -= PropertyChanged_Pokemons2;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_Pokemons2).CollectionChanged -= CollectionChanged_Pokemons2;
                            cache_Pokemons2 = null;
                        }
                        if (obj != null)
                        {
                            cache_Pokemons2 = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Pokemons2;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_Pokemons2;
                        }
                    }
                }
                public void RegisterTwoWayListener_2(global::Windows.UI.Xaml.Controls.FlipView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_2_ItemsSource();
                        }
                    });
                }
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.FlipView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_ItemsSource();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SeleccionPage.xaml line 20
                {
                    this.Luchador1 = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 3: // SeleccionPage.xaml line 28
                {
                    this.Luchador2 = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 4: // SeleccionPage.xaml line 36
                {
                    this.btnLuchar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLuchar).Click += this.btnLuchar_Click;
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
            switch(connectionId)
            {
            case 1: // SeleccionPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SeleccionPage_obj1_Bindings bindings = new SeleccionPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

