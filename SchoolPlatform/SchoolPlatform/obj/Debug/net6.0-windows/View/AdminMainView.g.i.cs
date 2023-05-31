﻿#pragma checksum "..\..\..\..\View\AdminMainView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505A2A3C55CE11DA3F8F78436B004E3C8A79F406"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using SchoolPlatform.View;
using SchoolPlatform.ViewModel;
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


namespace SchoolPlatform.View {
    
    
    /// <summary>
    /// AdminMainView
    /// </summary>
    public partial class AdminMainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 159 "..\..\..\..\View\AdminMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ControlBar;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\View\AdminMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\View\AdminMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock captionTxt;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\View\AdminMainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl contentZone;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SchoolPlatform;component/view/adminmainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AdminMainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 85 "..\..\..\..\View\AdminMainView.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.showEditStudents);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 100 "..\..\..\..\View\AdminMainView.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.showEditProfesors);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ControlBar = ((System.Windows.Controls.StackPanel)(target));
            
            #line 165 "..\..\..\..\View\AdminMainView.xaml"
            this.ControlBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ControlBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\..\..\View\AdminMainView.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.captionTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.contentZone = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

