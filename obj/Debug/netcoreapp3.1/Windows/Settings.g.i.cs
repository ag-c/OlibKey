﻿#pragma checksum "..\..\..\..\Windows\Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3463F4FFDD3558F33980C61DF6BCF7AA035CFC78"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace OlibPasswordManager.Windows {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Windows\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbCollapsedWindow;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbLang;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbTheme;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OlibPasswordManager;V1.3.0.266;component/windows/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Settings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\..\Windows\Settings.xaml"
            ((OlibPasswordManager.Windows.Settings)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Windows\Settings.xaml"
            ((OlibPasswordManager.Windows.Settings)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Settings_OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbCollapsedWindow = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.CbLang = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\Windows\Settings.xaml"
            this.CbLang.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbLang_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CbTheme = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\..\Windows\Settings.xaml"
            this.CbTheme.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbTheme_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 35 "..\..\..\..\Windows\Settings.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

