using QuizTime.Models;
using QuizTime.Views;
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

namespace QuizTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controllers.Quiztime quiztimeObject = new Controllers.Quiztime();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = quiztimeObject;
            cmbCombo.SelectionChanged += CmbCombo_SelectionChanged;
        }

        private void CmbCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnStartQuiz.IsEnabled = true;
            btnAddQuestion.IsEnabled = true;
            btnEditQuiz.IsEnabled = true;
            btnDeleteQuiz.IsEnabled = true;

            Quiz selectedItem = (Quiz)cmbCombo.SelectedItem;

            questionText.Content = selectedItem.Quizname;
            lblQuizImage.Content = "No Image Found :-(";
            imgQuiz.Source = null;
            if (!string.IsNullOrEmpty(selectedItem.Image))
            {
                lblQuizImage.Content = null;
                Uri imagePath = new Uri(selectedItem.Image);
                BitmapImage bitmap = new BitmapImage(imagePath);
                imgQuiz.Source = bitmap;
            }
        }

        private void btnAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            Quiz selectedItem = (Quiz)cmbCombo.SelectedItem;

            CreateQuestion newQuestion = new CreateQuestion();
            newQuestion.quiz = selectedItem;
            newQuestion.IsEdit = false;
            newQuestion.Show();
            this.Close();
        }

        private void btnCreateQuiz_Click(object sender, RoutedEventArgs e)
        {
            CreateQuiz createQuiz = new CreateQuiz();
            createQuiz.Title = "Create new Quiz";
            createQuiz.Show();
            this.Close();
        }

        private void btnStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            Quiz selectedItem = (Quiz)cmbCombo.SelectedItem;
            StartQuiz startQuiz = new StartQuiz(selectedItem);
            startQuiz.Show();
            QuizController controller = new QuizController(startQuiz);
            controller.Show();
            this.Close();
        }

        private void btnEditQuiz_Click(object sender, RoutedEventArgs e)
        {
            Quiz selectedItem = (Quiz)cmbCombo.SelectedItem;
            CreateQuiz editQuiz = new CreateQuiz(selectedItem);
            editQuiz.Title = "Edit Quiz";
            editQuiz.Show();
            this.Close();

        }

        private void btnDeleteQuiz_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Are you sure you want to Delete the Quiz?", "Delete Quiz", MessageBoxButton.YesNoCancel);
            //MessageBox.Show("Are you sure you want to Delete the Quiz and its underlying questions?", "Delete Quiz", MessageBoxButton.YesNoCancel);
            Quiz selectedItem = (Quiz)cmbCombo.SelectedItem;
            DeleteQuiz deleteQuiz = new DeleteQuiz(selectedItem);
            deleteQuiz.Show();
            this.Close();
        }
    }
}
