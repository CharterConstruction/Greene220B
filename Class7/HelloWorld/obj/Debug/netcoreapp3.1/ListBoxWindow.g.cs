﻿#pragma checksum "..\..\..\ListBoxWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A7543577D66B1E646D9D4A6EBD430A8F6A5DEF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HelloWorld;
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


namespace HelloWorld {
    
    
    /// <summary>
    /// ListBoxWindow
    /// </summary>
    public partial class ListBoxWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\ListBoxWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox uxCurrentList;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ListBoxWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxDelete;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\ListBoxWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxRemove;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\ListBoxWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uxApply;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ListBoxWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox uxRemoveList;
        
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
            System.Uri resourceLocater = new System.Uri("/HelloWorld;component/listboxwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ListBoxWindow.xaml"
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
            this.uxCurrentList = ((System.Windows.Controls.ListBox)(target));
            
            #line 12 "..\..\..\ListBoxWindow.xaml"
            this.uxCurrentList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.uxCurrentList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.uxDelete = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\ListBoxWindow.xaml"
            this.uxDelete.Click += new System.Windows.RoutedEventHandler(this.uxDelete_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.uxRemove = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\ListBoxWindow.xaml"
            this.uxRemove.Click += new System.Windows.RoutedEventHandler(this.uxRemove_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uxApply = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\ListBoxWindow.xaml"
            this.uxApply.Click += new System.Windows.RoutedEventHandler(this.uxApply_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.uxRemoveList = ((System.Windows.Controls.ListBox)(target));
            
            #line 19 "..\..\..\ListBoxWindow.xaml"
            this.uxRemoveList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.uxRemoveList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
