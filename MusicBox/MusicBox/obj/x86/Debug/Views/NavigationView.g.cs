﻿#pragma checksum "C:\Users\Phuong Anh\Desktop\UWP\MusicBox\MusicBox\Views\NavigationView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34820E2DAB2FD22546318F253CF3B78C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicBox.Views
{
    partial class NavigationView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_AdaptiveTrigger_MinWindowWidth(global::Windows.UI.Xaml.AdaptiveTrigger obj, global::System.Double value)
            {
                obj.MinWindowWidth = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class NavigationView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            INavigationView_Bindings
        {
            private global::MusicBox.Views.NavigationView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.AdaptiveTrigger obj2;

            public NavigationView_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\NavigationView.xaml line 19
                        this.obj2 = (global::Windows.UI.Xaml.AdaptiveTrigger)target;
                        break;
                    default:
                        break;
                }
            }

            // INavigationView_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MusicBox.Views.NavigationView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MusicBox.Views.NavigationView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        if (NavigationView.IsApiContractPresent_Windows_Foundation_UniversalApiContract_5)
                        {
                            this.Update_NavView_459327327(obj.NavView, phase);
                        }
                    }
                }
            }
            private void Update_NavView_459327327(global::Windows.UI.Xaml.Controls.NavigationView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        if (NavigationView.IsApiContractPresent_Windows_Foundation_UniversalApiContract_5)
                        {
                            this.Update_NavView_459327327_CompactModeThresholdWidth_459327327(obj.CompactModeThresholdWidth, phase);
                        }
                    }
                }
            }
            private void Update_NavView_459327327_CompactModeThresholdWidth_459327327(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\NavigationView.xaml line 19
                    if (NavigationView.IsApiContractPresent_Windows_Foundation_UniversalApiContract_5)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_AdaptiveTrigger_MinWindowWidth(this.obj2, obj);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // Views\NavigationView.xaml line 29
                {
                    if (NavigationView.IsApiContractPresent_Windows_Foundation_UniversalApiContract_5)
                    {
                        this.NavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                        if (NavigationView.IsApiContractPresent_Windows_Foundation_UniversalApiContract_5)
                        {
                            ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).Loaded += this.NavView_Loaded;
                        }
                        if (NavigationView.IsApiContractPresent_Windows_Foundation_UniversalApiContract_5)
                        {
                            ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).ItemInvoked += this.NavView_ItemInvoked;
                        }
                    }
                }
                break;
            case 4: // Views\NavigationView.xaml line 34
                {
                    this.SearchBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                }
                break;
            case 5: // Views\NavigationView.xaml line 37
                {
                    this.ListSong = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // Views\NavigationView.xaml line 39
                {
                    this.MySong = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // Views\NavigationView.xaml line 41
                {
                    this.MyAccount = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // Views\NavigationView.xaml line 45
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\NavigationView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    NavigationView_obj1_Bindings bindings = new NavigationView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }

        // Api Information for conditional namespace declarations
        internal static bool IsApiContractPresent_Windows_Foundation_UniversalApiContract_5 = global::Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 5);
    }
}

