﻿#pragma checksum "..\..\..\ContactWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B85F7F792CA86CE786FD63DBA5B1356015F802FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ContactApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace ContactApp {
    
    
    /// <summary>
    /// ContactWindow
    /// </summary>
    public partial class ContactWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid uxGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxNameError;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxEmail;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton uxHome;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton uxMobile;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock uxAge;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider uxAgeSlider;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uxNotes;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxSubmit;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ContactWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ContactApp;component/contactwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ContactWindow.xaml"
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
            
            #line 10 "..\..\..\ContactWindow.xaml"
            ((ContactApp.ContactWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.uxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.uxNameError = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.uxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.uxPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.uxHome = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.uxMobile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.uxAge = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.uxAgeSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 11:
            this.uxNotes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.uxSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\ContactWindow.xaml"
            this.uxSubmit.Click += new System.Windows.RoutedEventHandler(this.uxSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.uxCancel = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\ContactWindow.xaml"
            this.uxCancel.Click += new System.Windows.RoutedEventHandler(this.uxCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

