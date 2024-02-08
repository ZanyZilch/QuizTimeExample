using MySqlConnector;
using QuizTime.Controllers;
using QuizTime.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DeleteQuiz.xaml
    /// </summary>
    public partial class DeleteQuiz : Window
    {
        Quiz quiz;
        public DeleteQuiz(Quiz thisquiz)
        {
            InitializeComponent();
            quiz = thisquiz;
        }


        public void OblirateQuiz()
        {
            string query = "";
            if ((bool)rdQuiz.IsChecked)
            {
                SQL bla = new SQL();
                query = "DELETE FROM quiz WHERE `quiz`.`idQuiz` = @idQuiz";
                using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
                {
                    cmd.Parameters.AddWithValue("@idQuiz", quiz.idQuiz);
                    cmd.ExecuteNonQuery();
                }
            }
            else if ((bool)rdQuizQuestion.IsChecked)
            {
                SQL bla = new SQL();

                foreach (Question question in quiz.Questions)
                {
                    foreach (Answer answer in question.answerList)
                    {
                        //Delete question_answer
                        query = "DELETE FROM question_answer WHERE `idQuestion` = @idQuestion AND `idAnswer` = @idAnswer";
                        using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
                        {
                            cmd.Parameters.AddWithValue("@idQuestion", question.idQuestion);
                            cmd.Parameters.AddWithValue("@idAnswer", answer.idAnswer);
                            cmd.ExecuteNonQuery();
                        }

                        //Delete answer
                        query = "DELETE FROM answer WHERE `answer`.`idAnswer` = @idAnswer";
                        using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
                        {
                            cmd.Parameters.AddWithValue("@idAnswer", answer.idAnswer);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    //Delete Question
                    query = "DELETE FROM question WHERE `idQuestion` = @idQuestion";
                    using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
                    {
                        cmd.Parameters.AddWithValue("@idQuestion", question.idQuestion);
                        cmd.ExecuteNonQuery();
                    }
                }

                //Delete Quiz
                query = "DELETE FROM quiz WHERE `quiz`.`idQuiz` = @idQuiz";
                using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
                {
                    cmd.Parameters.AddWithValue("@idQuiz", quiz.idQuiz);
                    cmd.ExecuteNonQuery();
                }
            }

            MainWindow mainWindow = new MainWindow();
            quiz = null;
            mainWindow.Show();
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            OblirateQuiz();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
