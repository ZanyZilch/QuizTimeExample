﻿#pragma checksum "..\..\..\Views\CreateQuiz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C834E1363BD013E125EADC04D07CB9E347F21CF67B32553E2BF6909EE642DD6"
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


namespace QuizTime.Views {
    
    
    /// <summary>
    /// CreateQuiz
    /// </summary>
    public partial class CreateQuiz : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtboxQuizName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuizImage;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image QuizImage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuizImage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listview_Questions;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddQuestion;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveQuestion;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditQuestion;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\CreateQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFinalize;
        
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
            System.Uri resourceLocater = new System.Uri("/QuizTime;component/views/createquiz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreateQuiz.xaml"
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
            this.txtboxQuizName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnQuizImage = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Views\CreateQuiz.xaml"
            this.btnQuizImage.Click += new System.Windows.RoutedEventHandler(this.btnQuizImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.QuizImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.lblQuizImage = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.listview_Questions = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.btnAddQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\CreateQuiz.xaml"
            this.btnAddQuestion.Click += new System.Windows.RoutedEventHandler(this.btnNewQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnRemoveQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Views\CreateQuiz.xaml"
            this.btnRemoveQuestion.Click += new System.Windows.RoutedEventHandler(this.btnRemoveQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEditQuestion = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Views\CreateQuiz.xaml"
            this.btnEditQuestion.Click += new System.Windows.RoutedEventHandler(this.btnEditQuestion_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnFinalize = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\CreateQuiz.xaml"
            this.btnFinalize.Click += new System.Windows.RoutedEventHandler(this.btnFinalize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

