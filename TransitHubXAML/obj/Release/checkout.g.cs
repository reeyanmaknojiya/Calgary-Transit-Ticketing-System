﻿#pragma checksum "..\..\checkout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9961A576532B3FF077EF8F009A8D6E32C51DE46B8545F76F72F6E78015B86C34"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using TransitHubXAML;


namespace TransitHubXAML {
    
    
    /// <summary>
    /// checkout
    /// </summary>
    public partial class checkout : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle visaRectangle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label visaLabel1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label visaLabel2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle msRectangle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label msLabel1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label msLabel2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image msImage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ppRectangle;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ppLabel1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image visaImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ppImage;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\checkout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button oneTimeCard;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TransitHubXAML;component/checkout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\checkout.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 12 "..\..\checkout.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.back_button);
            
            #line default
            #line hidden
            return;
            case 3:
            this.visaRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 16 "..\..\checkout.xaml"
            this.visaRectangle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.visaChange);
            
            #line default
            #line hidden
            
            #line 16 "..\..\checkout.xaml"
            this.visaRectangle.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Visa_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.visaLabel1 = ((System.Windows.Controls.Label)(target));
            
            #line 17 "..\..\checkout.xaml"
            this.visaLabel1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Visa_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.visaLabel2 = ((System.Windows.Controls.Label)(target));
            
            #line 18 "..\..\checkout.xaml"
            this.visaLabel2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Visa_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.msRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 19 "..\..\checkout.xaml"
            this.msRectangle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.msChange);
            
            #line default
            #line hidden
            
            #line 19 "..\..\checkout.xaml"
            this.msRectangle.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.MasterCard_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.msLabel1 = ((System.Windows.Controls.Label)(target));
            
            #line 20 "..\..\checkout.xaml"
            this.msLabel1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MasterCard_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.msLabel2 = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\checkout.xaml"
            this.msLabel2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MasterCard_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.msImage = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\checkout.xaml"
            this.msImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MasterCard_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ppRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 23 "..\..\checkout.xaml"
            this.ppRectangle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ppChange);
            
            #line default
            #line hidden
            
            #line 23 "..\..\checkout.xaml"
            this.ppRectangle.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Paypal_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ppLabel1 = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\checkout.xaml"
            this.ppLabel1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Paypal_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.visaImage = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\checkout.xaml"
            this.visaImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Visa_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ppImage = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\checkout.xaml"
            this.ppImage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Paypal_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.oneTimeCard = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\checkout.xaml"
            this.oneTimeCard.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

