﻿#pragma checksum "..\..\..\..\Views\PracticeView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202E8E4CABB39227B5DF7B75F4D99E429F7B152D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AnyVocab.Views;
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


namespace AnyVocab.Views {
    
    
    /// <summary>
    /// PracticeView
    /// </summary>
    public partial class PracticeView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Views\PracticeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WordLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\PracticeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAnswerTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\PracticeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AssessmentLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\PracticeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CounterLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\PracticeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AnyVocab;V1.0.0.0;component/views/practiceview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PracticeView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.UserAnswerTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 17 "..\..\..\..\Views\PracticeView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Skip);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 18 "..\..\..\..\Views\PracticeView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Check);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AssessmentLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CounterLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 21 "..\..\..\..\Views\PracticeView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Back);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Views\PracticeView.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Next);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

