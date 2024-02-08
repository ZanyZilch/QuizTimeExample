using QuizTime.Models;
using QuizTime.Pages;
using QuizTime.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace QuizTime.Views
{
    /// <summary>
    /// Interaction logic for ResultScreen.xaml
    /// </summary>
    public partial class ResultScreen : Window
    {
        List<QuizQuestionPage> pageresults;
        int currentPageIndex = 0;
        //Timer myTimer = new Timer();
        private DispatcherTimer timer;
        public ResultScreen(List<string> result, List<QuizQuestionPage> pages)
        {
            InitializeComponent();
            //txtScore.Content = result[0];
            txtPercentage.Content = result[1];
            txtTimeTaken.Content = result[2];
            
            pageresults = pages;

            foreach (var page in pageresults)
            {
                var userAnswers = page.GetUserAnswers();
                var correctAnswers = page.currentQuestion.answerList.Where(answer => answer.correct);

                foreach (AnAnswer answerControl in page.AnswerGrid.Children.OfType<AnAnswer>())
                {
                    // Check if the selected answer matches any correct answer for the question
                    bool isCorrect = correctAnswers.Any(correctAnswer => correctAnswer.answerText == answerControl.answerText);

                    // Access the border inside the AnAnswer user control
                    var border = answerControl.recBorder;

                    //answerControl.rdbtnselectedItem.IsEnabled = false;

                    //if (isCorrect)
                    //{
                    //    // Change border color to green when the answer is correct
                    //    border.Stroke = Brushes.Green;
                    //    border.StrokeThickness = 2;
                    //}
                    //else if ((bool)answerControl.rdbtnselectedItem.IsChecked)
                    //{
                    //    border.Stroke = Brushes.Red;
                    //    border.StrokeThickness = 2;
                    //}
                }
            }

            if (pages.Count > 0)
            {
                // Show the first question page initially
                pageFrame.Navigate(pageresults[currentPageIndex]);
                if (this.pageFrame.Content is Page page)
                {
                    var scaleX = this.pageFrame.ActualWidth / page.ActualWidth;
                    var scaleY = this.pageFrame.ActualHeight / page.ActualHeight;
                    var zoom = Math.Min(scaleX, scaleY);

                    page.LayoutTransform = new ScaleTransform(zoom, zoom);
                }
            }

            ////TimerInitialize
            //timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(5);
            //timer.Tick += Timer_Tick;
            //timer.Start();

        }
        public void MarkAnswers()
        {
            if (currentPageIndex < pageresults.Count)
            {
                var page = pageresults[currentPageIndex];
                var correctAnswers = page.currentQuestion.answerList.Where(answer => answer.correct);

                foreach (AnAnswer answerControl in page.AnswerGrid.Children.OfType<AnAnswer>())
                {
                    bool isCorrect = correctAnswers.Any(correctAnswer => correctAnswer.answerText == answerControl.answerText);

                    var border = answerControl.recBorder;

                    if (isCorrect)
                    {
                        // Change border color to green when the answer is correct
                        border.Stroke = Brushes.Green;
                        border.StrokeThickness = 2;
                    }
                }
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            ScrollRight();
        }

        public void ScrollRight()
        {

            if (pageresults[currentPageIndex] != null)
            {
                currentPageIndex++;
                if (pageresults.Count > currentPageIndex)
                {
                    pageFrame.Navigate(pageresults[currentPageIndex]);
                }
                else
                {
                    //Reset
                    currentPageIndex = 0;
                    pageFrame.Navigate(pageresults[currentPageIndex]);
                }
            }
        }

        public void ScrollLeft()
        {

            if (pageresults[currentPageIndex] != null)
            {
                currentPageIndex--;
                if (pageresults.Count > currentPageIndex)
                {
                    pageFrame.Navigate(pageresults[currentPageIndex]);
                }
                else
                {
                    //Reset
                    currentPageIndex = pageresults.Count;
                    pageFrame.Navigate(pageresults[currentPageIndex]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Closing += null;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }

}




    

