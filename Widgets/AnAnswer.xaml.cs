using QuizTime.Models;
using QuizTime.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizTime.Widgets
{
    /// <summary>
    /// Interaction logic for AnAnswer.xaml
    /// </summary>
    public partial class AnAnswer : UserControl
    {
        public string answerText { get; set; }
        public bool selected { get; set; }
        public bool Correct { get; set; }
        public string answerImage { get; set; }

        public Answer Answer { get; set; }

        public AnAnswer(Answer answer)
        {
            InitializeComponent();
            Answer = answer;

            answerText = answer.answerText;
            Correct = answer.correct;
            answerImage = answer.image;
            lblquestionText.Text = answer.answerText;

            if (!string.IsNullOrEmpty(answerImage) && !string.Equals(answerImage, "..."))
            {
                Uri imagePath = new Uri(answerImage);
                BitmapImage bitmap = new BitmapImage(imagePath);
                imgAnswer.Source = bitmap;
            }

            //rdbtnselectedItem.Click += BtnSelectAnswer_Click;
            this.DataContext = this;
        }

        private void BtnSelectAnswer_Click(object sender, RoutedEventArgs e)
        {
            // On button click, update selected answer in the QuizQuestionPage
            // Call SaveUserAnswer method in QuizQuestionPage with the chosen answer
            var parentPage = FindParentPage();
            if (parentPage is QuizQuestionPage quizPage)
            {
                quizPage.SaveUserAnswer(Answer);
            }
        }

        private Page FindParentPage()
        {
            // Utility method to find the parent page of the current control
            DependencyObject parent = VisualTreeHelper.GetParent(this);
            while (parent != null && !(parent is Page))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            return parent as Page;
        }
    }
}
