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
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;

namespace QuizTime.Views
{
    /// <summary>
    /// Interaction logic for StartQuiz.xaml
    /// </summary>
    public partial class StartQuiz : Window
    {
        Quiz quiz;
        private int currentPageIndex = 0;
        public List<QuizQuestionPage> pages = new List<QuizQuestionPage>();

        //Countdown
        DispatcherTimer _timer;
        TimeSpan _time;

        //Stopwatch
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();
        string currentTime = string.Empty;
        public StartQuiz(Quiz quiz)
        {
            InitializeComponent();

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
                //SetTimerCountDown();

                ////SetStopWatch
                //dispatcherTimer.Tick += new EventHandler(dt_Tick);
                //dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
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
        void dt_Tick(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }
        }

        private void SetTimerCountDown()
        {
            _timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal, delegate
            {
                lblTimer.Content = _time.ToString("c");
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    stopWatch.Stop();
                    //Stop quiz and fetch results
                    CheckResults();
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            foreach (Question question in quiz.Questions)
            {
                _time = _time.Add(TimeSpan.FromSeconds(10));
            }
            _timer.Start();

            //StopWatch
            stopWatch.Start();
            dispatcherTimer.Start();
        }

        private void CheckResults()
        {

            int correctAnswersCount = 0;

            foreach (var page in pages)
            {
                var userAnswers = page.GetUserAnswers();
                var correctAnswers = page.currentQuestion.answerList.Where(answer => answer.correct);

                foreach (var userAnswer in userAnswers)
                {
                    // Check if the selected answer matches any correct answer for the question
                    bool isCorrect = correctAnswers.Any(correctAnswer => correctAnswer.answerText == userAnswer);

                    // Update the count of correct answers
                    if (isCorrect)
                    {
                        correctAnswersCount++;
                    }
                }
            }

            double percentage = (double)correctAnswersCount / quiz.Questions.Count * 100.0;

            List<string> result = new List<string>();
            string score = String.Format("Score: {0} / {1}", correctAnswersCount, quiz.Questions.Count);
            string average = string.Format("Percentage: {0}%", percentage);
            string timetaken =String.Format("Time taken: {0}", currentTime);


            result.Add(score);
            result.Add(average);
            result.Add(timetaken);
            ResultScreen resultScreen = new ResultScreen(result, pages);
            QuizController resultController = new QuizController(resultScreen);
            resultScreen.Show();
            resultController.Show();
            this.Close();
        }

        
        private void InitializeQuiz()
        {
            foreach (Question question in quiz.Questions)
            {
                QuizQuestionPage newpage = new QuizQuestionPage(question);
                pages.Add(newpage);
            }
            if (pages.Count > 0)
            {
                // Show the first question page initially
                pageFrame.Navigate(pages[currentPageIndex]);
            }
        }

        public void Previous_Click()
        {
            if (currentPageIndex > 0)
            {
                currentPageIndex--;
                pageFrame.Navigate(pages[currentPageIndex]);
                UpdateQuestionCounter();
            }
        }

        public int Next_Click()
        {
            if (currentPageIndex < pages.Count - 1)
            {
                currentPageIndex++;
                pageFrame.Navigate(pages[currentPageIndex]);
                UpdateQuestionCounter();
                return 0;
                //if(currentPageIndex == pages.Count)
                //{
                //    btnNext.Content = "Finish";
                //}
            }
            else
            {
                //_timer.Stop();
                //stopWatch.Stop();
                CheckResults();
                return 1;
            }
        }

        
        private void UpdateQuestionCounter()
        {
            questionAmount.Content = $"Question {currentPageIndex + 1} out of {quiz.Questions.Count}";
        }
    }


}
