using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizTime.Views
{
    /// <summary>
    /// Interaction logic for QuizController.xaml
    /// </summary>
    public partial class QuizController : Window
    {
        public StartQuiz controlledQuiz;
        public ResultScreen resultScreen;
        public QuizController(StartQuiz startQuiz)
        {
            InitializeComponent();
            this.controlledQuiz = startQuiz;
            btnNext.Click += btnQuizNext_Click;
            btnPrevious.Click += btnQuizPrevious_Click;
        }

        public QuizController(ResultScreen result)
        {
            InitializeComponent();
            this.resultScreen = result;
            btnNext.Click += btnResultNext_Click;
            btnPrevious.Click += btnResultPrevious_Click;
            btnRevealAnswers.Click += btnResultRevealAnswers_Click;
            btnRevealAnswers.Visibility=Visibility.Visible;
        }

        //StartQuiz
        private void btnQuizPrevious_Click(object sender, RoutedEventArgs e)
        {
            this.controlledQuiz.Previous_Click();
        }

        private void btnQuizNext_Click(object sender, RoutedEventArgs e)
        {
             if(this.controlledQuiz.Next_Click() == 1)
            {
                this.Close();
            }
        }

        //StartResult
        private void btnResultPrevious_Click(object sender, RoutedEventArgs e)
        {
            this.resultScreen.ScrollLeft();
        }

        private void btnResultNext_Click(object sender, RoutedEventArgs e)
        {
            this.resultScreen.ScrollRight();
        }

        private void btnResultRevealAnswers_Click(object sender, RoutedEventArgs e)
        {
            this.resultScreen.MarkAnswers();
        }
    }
}
