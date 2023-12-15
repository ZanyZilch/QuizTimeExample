﻿using MySqlConnector;
using QuizTime.Controllers;
using QuizTime.Models;
using QuizTime.Widgets;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
using QuizTime.Controllers;


namespace QuizTime.Views
{
    /// <summary>
    /// Interaction logic for CreateQuestion.xaml
    /// </summary>
    public partial class CreateQuestion : Window
    {
        public Quiz quiz;
        public Question _newquestion = new Question();
        public string questionImage;
        public int questionIndex;
        public bool IsEdit;

        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void btnQuestionImage_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Image file (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                questionImage = ofd.FileName;
                lblQuestionImage.Content = ofd.FileName;
            }
        }

        private void btnAddAnswer_Click(object sender, RoutedEventArgs e)
        {
            NewAnswer newAnswer = new NewAnswer();
        }

        private void btnFinalize_Click(object sender, RoutedEventArgs e)
        {

            _newquestion.questionText = lblQuestionName.Text;
            _newquestion.image = (string)lblQuestionImage.Content;
            _newquestion.idQuiz = quiz.idQuiz;
            _newquestion.QuestionType = "OneAnswer";

            List<Answer> answers = new List<Answer>();
            foreach (NewAnswer newAnswer in grdAnswers.Children.OfType<NewAnswer>())
            {
                Answer answer = new Answer();
                answer.answerText = newAnswer.txtAnswer.Text;
                answer.image = newAnswer.lblimageName.Content.ToString();
                answer.correct = (bool)newAnswer.cbxCorrect.IsChecked;

                answers.Add(answer);
            }
            _newquestion.answerList = answers;

            if (!IsEdit)
            {
                quiz.Questions.Add(_newquestion);
            }
            this.Close();
            
            //Dit werkt
            //SQL bla = new SQL();

            //long idQuestion = new long();
            //List<long> idAnswers = new List<long>();

            ////Create Question
            //string query = "INSERT INTO question (idQuestion, questionText, image, idQuiz, type) " +
            //               "VALUES (NULL, @questionText, @questionImage, @idQuiz, 'OneAnswer')";

            //using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
            //{
            //    cmd.Parameters.AddWithValue("@questionText", lblQuestionName.Text);
            //    cmd.Parameters.AddWithValue("@questionImage", lblQuestionImage.Content);
            //    cmd.Parameters.AddWithValue("@idQuiz", quiz.idQuiz);

            //    cmd.ExecuteNonQuery();
            //    idQuestion = cmd.LastInsertedId;
            //}

            ////Create Answers
            //query = "INSERT INTO answer (idAnswer, answerText, image) " +
            //        "VALUES (NULL, @answerText, @answerImage)";
            //foreach (NewAnswer newAnswer in grdAnswers.Children.OfType<NewAnswer>())
            //{
            //    using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
            //    {
            //        cmd.Parameters.AddWithValue("@answerText", lblQuestionName.Text);
            //        cmd.Parameters.AddWithValue("@answerImage", lblQuestionImage.Content);

            //        cmd.ExecuteNonQuery();
            //        idAnswers.Add(cmd.LastInsertedId);
            //    }

            //    Answer answer = new Answer();
            //    answer.answerText = newAnswer.answerText;
            //    answer.image = newAnswer.answerImage;
            //    answer.correct = newAnswer.Correct;

            //}

            ////Create question_answer
            //query = "INSERT INTO `question_answer` (`idQuestion`, `idAnswer`, `correct`) " +
            //        "VALUES (@idQuestion, @idAnswer, @Correct);";
            //int counter = 0;
            //foreach (NewAnswer newAnswer in grdAnswers.Children.OfType<NewAnswer>())
            //{
            //    using (MySqlCommand cmd = new MySqlCommand(query, bla.Connection))
            //    {
            //        cmd.Parameters.AddWithValue("@idQuestion", idQuestion);
            //        cmd.Parameters.AddWithValue("@idAnswer",idAnswers.ElementAt(counter));
            //        cmd.Parameters.AddWithValue("@Correct", newAnswer.cbxCorrect.IsChecked);

            //        cmd.ExecuteNonQuery();
            //    }
            //    counter++;
            //}
            //this.Close();
        }
    }
}
