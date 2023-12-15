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
using System.Windows.Shapes;
using System.Timers;

namespace QuizTime.Views
{
    /// <summary>
    /// Interaction logic for StartQuiz.xaml
    /// </summary>
    public partial class StartQuiz : Window
    {
        Quiz quiz;
        private int currentPageIndex = 0;
        public StartQuiz(Quiz quiz)
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Enabled = false;
            timer.Interval = 1000;
            int counter = 10;

            if (quiz != null)
            {
                questionAmount.Content = "Question 1 out of " + quiz.Questions.Count.ToString();
                this.quiz = quiz;
                if (!string.IsNullOrEmpty(quiz.Image))
                {
                    Uri imagePath = new Uri(quiz.Image);
                    BitmapImage bitmap = new BitmapImage(imagePath);
                    imgQuiz.Source = bitmap;
                }
                questionText.Content = this.quiz.Quizname;
                InitializeQuiz();
                foreach(Question question in quiz.Questions)
                {
                    counter =+ 10;
                }
                //timer.Enabled
                //lblTimer.Content 
            }
            else
            {
                var result = MessageBox.Show("Empty Quiz, try again.", "Quiz error", MessageBoxButton.OK, MessageBoxImage.Error);

                switch (result)
                {
                    case MessageBoxResult.Cancel:
                        Console.WriteLine("cancel");

                        break;
                    case MessageBoxResult.OK:
                        Console.WriteLine("yes");

                        MainWindow main = new MainWindow();
                        main.Show();
                        this.Close();
                        break;

                }

            }
        }
        private void InitializeQuiz()
        {
            if (quiz.Questions.Count > 0)
            {
                pageFrame.Navigate(new QuizQuestionPage(quiz.Questions[currentPageIndex]));
            }
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                pageFrame.Navigate(new QuizQuestionPage(quiz.Questions[currentPageIndex]));
                UpdateQuestionCounter();
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (currentPageIndex < quiz.Questions.Count - 1)
            {
                currentPageIndex++;
                pageFrame.Navigate(new QuizQuestionPage(quiz.Questions[currentPageIndex]));
                UpdateQuestionCounter();
            }
        }
        private void UpdateQuestionCounter()
        {
            questionAmount.Content = $"Question {currentPageIndex + 1} out of {quiz.Questions.Count}";
        }
    }


}
