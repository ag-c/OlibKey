﻿#pragma checksum "..\..\..\..\..\Views\SettingsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1B54DCFB759F0748E4F8BADED8205A3F6EB25190"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OlibKey.Views;
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


namespace OlibKey.Views {
    
    
    /// <summary>
    /// SettingsWindow
    /// </summary>
    public partial class SettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbCollapsedWindow;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAutorun;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbLang;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbTheme;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OlibKey;V2.1.0.0;component/views/settingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\SettingsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\..\Views\SettingsWindow.xaml"
            ((OlibKey.Views.SettingsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\..\Views\SettingsWindow.xaml"
            ((OlibKey.Views.SettingsWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Settings_OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbCollapsedWindow = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.cbAutorun = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\..\..\..\Views\SettingsWindow.xaml"
            this.cbAutorun.Checked += new System.Windows.RoutedEventHandler(this.CBAutorun);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\..\Views\SettingsWindow.xaml"
            this.cbAutorun.Unchecked += new System.Windows.RoutedEventHandler(this.CBAutorun);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CbLang = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\..\..\Views\SettingsWindow.xaml"
            this.CbLang.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbLang_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CbTheme = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\..\..\Views\SettingsWindow.xaml"
            this.CbTheme.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbTheme_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 37 "..\..\..\..\..\Views\SettingsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

