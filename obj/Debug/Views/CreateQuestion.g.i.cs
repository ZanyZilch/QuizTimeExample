﻿#pragma checksum "..\..\..\Views\CreateQuestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12DA849F74D0C073B34BE1320C06F71AF403041CD6E62689219016AAA7A35BB0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuizTime.Views;
using QuizTime.Widgets;
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


namespace QuizTime.Views {
    
    
    /// <summary>
    /// CreateQuestion
    /// </summary>
    public partial class CreateQuestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lblQuestionName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox grpbxAnswers;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdAnswers;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuestionImage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuestionImage;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFinalize;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAnswer;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\CreateQuestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveAnswer;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizTime;component/views/createquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreateQuestion.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.lblQuestionName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.grpbxAnswers = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.grdAnswers = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.btnQuestionImage = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\CreateQuestion.xaml"
            this.btnQuestionImage.Click += new System.Windows.RoutedEventHandler(this.btnQuestionImage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblQuestionImage = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnFinalize = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Views\CreateQuestion.xaml"
            this.btnFinalize.Click += new System.Windows.RoutedEventHandler(this.btnFinalize_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddAnswer = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Views\CreateQuestion.xaml"
            this.btnAddAnswer.Click += new System.Windows.RoutedEventHandler(this.btnAddAnswer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRemoveAnswer = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\CreateQuestion.xaml"
            this.btnRemoveAnswer.Click += new System.Windows.RoutedEventHandler(this.btnRemoveAnswer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

