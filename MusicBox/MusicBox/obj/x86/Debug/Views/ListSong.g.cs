﻿#pragma checksum "C:\Users\Phuong Anh\Desktop\UWP\MusicBox\MusicBox\Views\ListSong.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "426826C2337CCA8D64C9C3D479095F84"
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
    partial class ListSong : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
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
            public static void Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(global::Windows.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Windows.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListSong_obj20_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IListSong_Bindings
        {
            private global::MusicBox.Entity.Song dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj20;
            private global::Windows.UI.Xaml.Controls.Image obj21;
            private global::Windows.UI.Xaml.Controls.TextBlock obj22;
            private global::Windows.UI.Xaml.Controls.TextBlock obj23;
            private global::Windows.UI.Xaml.Controls.TextBlock obj24;

            public ListSong_obj20_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 20: // Views\ListSong.xaml line 40
                        this.obj20 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 21: // Views\ListSong.xaml line 55
                        this.obj21 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 22: // Views\ListSong.xaml line 56
                        this.obj22 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 23: // Views\ListSong.xaml line 57
                        this.obj23 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 24: // Views\ListSong.xaml line 58
                        this.obj24 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj20.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::MusicBox.Entity.Song) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IListSong_Bindings

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
                    this.dataRoot = (global::MusicBox.Entity.Song)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MusicBox.Entity.Song obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_name(obj.name, phase);
                        this.Update_thumbnail(obj.thumbnail, phase);
                        this.Update_singer(obj.singer, phase);
                        this.Update_description(obj.description, phase);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListSong.xaml line 40
                    if ((this.obj20.Target as global::Windows.UI.Xaml.Controls.StackPanel) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name((this.obj20.Target as global::Windows.UI.Xaml.Controls.StackPanel), obj, null);
                    }
                    // Views\ListSong.xaml line 56
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj22, obj, null);
                }
            }
            private void Update_thumbnail(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListSong.xaml line 55
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj21, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_singer(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListSong.xaml line 57
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj23, obj, null);
                }
            }
            private void Update_description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListSong.xaml line 58
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj24, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListSong_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IListSong_Bindings
        {
            private global::MusicBox.Views.ListSong dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj18;

            private ListSong_obj1_BindingsTracking bindingsTracking;

            public ListSong_obj1_Bindings()
            {
                this.bindingsTracking = new ListSong_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 18: // Views\ListSong.xaml line 20
                        this.obj18 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        this.bindingsTracking.RegisterTwoWayListener_18(this.obj18);
                        break;
                    default:
                        break;
                }
            }

            // IListSong_Bindings

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
                    this.dataRoot = (global::MusicBox.Views.ListSong)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MusicBox.Views.ListSong obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListAllSong(obj.ListAllSong, phase);
                    }
                }
            }
            private void Update_ListAllSong(global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ListAllSong(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListSong.xaml line 20
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj18, obj, null);
                }
            }
            private void UpdateTwoWay_18_ItemsSource()
            {
                if (this.initialized)
                {
                    this.dataRoot.ListAllSong = (global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song>)this.obj18.ItemsSource;
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ListSong_obj1_BindingsTracking
            {
                private global::System.WeakReference<ListSong_obj1_Bindings> weakRefToBindingObj; 

                public ListSong_obj1_BindingsTracking(ListSong_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ListSong_obj1_Bindings>(obj);
                }

                public ListSong_obj1_Bindings TryGetBindingObject()
                {
                    ListSong_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ListAllSong(null);
                }

                public void PropertyChanged_ListAllSong(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ListSong_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song>;
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
                public void CollectionChanged_ListAllSong(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    ListSong_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song> cache_ListAllSong = null;
                public void UpdateChildListeners_ListAllSong(global::System.Collections.ObjectModel.ObservableCollection<global::MusicBox.Entity.Song> obj)
                {
                    if (obj != cache_ListAllSong)
                    {
                        if (cache_ListAllSong != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ListAllSong).PropertyChanged -= PropertyChanged_ListAllSong;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ListAllSong).CollectionChanged -= CollectionChanged_ListAllSong;
                            cache_ListAllSong = null;
                        }
                        if (obj != null)
                        {
                            cache_ListAllSong = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ListAllSong;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ListAllSong;
                        }
                    }
                }
                public void RegisterTwoWayListener_18(global::Windows.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_18_ItemsSource();
                        }
                    });
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
            case 2: // Views\ListSong.xaml line 109
                {
                    this.MediaPlayer = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 3: // Views\ListSong.xaml line 68
                {
                    this.AddSongStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\ListSong.xaml line 100
                {
                    this.BtnCreateSong = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnCreateSong).Click += this.BtnCreateSong_Click;
                }
                break;
            case 5: // Views\ListSong.xaml line 101
                {
                    this.BtnReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // Views\ListSong.xaml line 95
                {
                    this.Thumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Views\ListSong.xaml line 96
                {
                    this.thumbnail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\ListSong.xaml line 90
                {
                    this.Link = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Views\ListSong.xaml line 91
                {
                    this.link = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\ListSong.xaml line 85
                {
                    this.Author = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Views\ListSong.xaml line 86
                {
                    this.author = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\ListSong.xaml line 80
                {
                    this.Singer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // Views\ListSong.xaml line 81
                {
                    this.singer = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Views\ListSong.xaml line 75
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Views\ListSong.xaml line 76
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\ListSong.xaml line 70
                {
                    this.Name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // Views\ListSong.xaml line 71
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\ListSong.xaml line 20
                {
                    this.MenuListAllSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 20: // Views\ListSong.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element20 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    ((global::Windows.UI.Xaml.Controls.StackPanel)element20).Tapped += this.StackPanel_Tap;
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
            case 1: // Views\ListSong.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ListSong_obj1_Bindings bindings = new ListSong_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 20: // Views\ListSong.xaml line 40
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element20 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    ListSong_obj20_Bindings bindings = new ListSong_obj20_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element20.DataContext);
                    element20.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element20, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element20, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

