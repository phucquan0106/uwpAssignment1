﻿#pragma checksum "C:\OishiWorkspace\Upgrade\Apt\Sem3\uwp\Assignment1\ScrollViewerDemo1\Pages\MySong.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B709768CEF938FD7C5FEC661847AC17F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScrollViewerDemo1.Pages
{
    partial class MySong : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MySong_obj10_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMySong_Bindings
        {
            private global::ScrollViewerDemo1.Entity.Song dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10TextDisabled = false;

            public MySong_obj10_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 36)
                {
                    isobj10TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Pages\MySong.xaml line 17
                        this.obj10 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
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
                            (this.obj10.Target as global::Windows.UI.Xaml.Controls.TextBlock).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ScrollViewerDemo1.Entity.Song) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMySong_Bindings

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
                    this.dataRoot = (global::ScrollViewerDemo1.Entity.Song)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ScrollViewerDemo1.Entity.Song obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_name(obj.name, phase);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\MySong.xaml line 17
                    if (!isobj10TextDisabled)
                    {
                        if ((this.obj10.Target as global::Windows.UI.Xaml.Controls.TextBlock) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text((this.obj10.Target as global::Windows.UI.Xaml.Controls.TextBlock), obj, null);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\MySong.xaml line 23
                {
                    this.MyMediaPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Pages\MySong.xaml line 26
                {
                    this.PreviousButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PreviousButton).Click += this.PreviousButton_OnClick;
                }
                break;
            case 4: // Pages\MySong.xaml line 27
                {
                    this.StatusButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.StatusButton).Click += this.StatusButton_OnClick;
                }
                break;
            case 5: // Pages\MySong.xaml line 28
                {
                    this.NextButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.NextButton).Click += this.NextButton_OnClick;
                }
                break;
            case 6: // Pages\MySong.xaml line 36
                {
                    this.ControlLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Pages\MySong.xaml line 33
                {
                    this.SongThumbnail = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 8: // Pages\MySong.xaml line 14
                {
                    this.ListViewSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListViewSong).DoubleTapped += this.ListViewSong_OnDoubleTapped;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 10: // Pages\MySong.xaml line 17
                {                    
                    global::Windows.UI.Xaml.Controls.TextBlock element10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    MySong_obj10_Bindings bindings = new MySong_obj10_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element10.DataContext);
                    element10.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element10, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element10, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

