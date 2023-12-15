using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySqlConnector;
using QuizTime.Models;

namespace QuizTime.Controllers
{
    public class Quiztime : SQL, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private Models.Quiz _activeQuiz;
        private List<Models.Quiz> _quizzes = new List<Models.Quiz>();

        // create constructor
        public Quiztime()
        {
            _quizzes = getQuizzes();
            NotifyPropertyChanged("Quizzes");
        }


        private List<Models.Question> Questions(int idQuiz)
        {
            List<Models.Question> questions = new List<Models.Question>();
            string query = "SELECT * FROM question " +
                "WHERE question.idQuiz = @idQuiz ";
                //"INNER JOIN question ON quiz.idQuiz = quiz.idQuiz " +
                //"INNER JOIN question ON quizquestion.idQuestion = question.idQuestion WHERE quiz.idQuiz = @idQuiz;";
            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@idQuiz", idQuiz);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Models.Question question = new Models.Question();
                    question.idQuestion = reader.GetInt32(0);
                    question.questionText = reader.GetString(1);
                    question.image = reader.GetString(2);
                    question.idQuiz = reader.GetInt16(3);
                    question.QuestionType = reader.GetString(4);
                    questions.Add(question);
                }
                reader.Close();
                reader.Dispose();

            }
            foreach (Question question in questions)
            {
                try { question.answerList = Answers(question.idQuestion); } catch { }
            }
            return questions;
        }

        private List<Models.Answer> Answers(int idQuestion)
        {
            //qa = question_answer
            //a = answer
            string query = "SELECT qa.idQuestion, qa.correct, a.idAnswer, a.answerText, a.image " +
                "           FROM question_answer AS qa " +
                "           INNER JOIN answer AS a ON qa.idAnswer = a.idAnswer " +
                "           WHERE qa.idQuestion = @idQuestion ";
            List<Models.Answer> answers = new List<Models.Answer>();
            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@idQuestion", idQuestion);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    Models.Answer answer = new Models.Answer();
                    answer.idAnswer = reader.GetInt32(2);
                    answer.answerText = reader.GetString(3);
                    answer.image = reader.GetString(4);
                    answer.correct = reader.GetBoolean(1);
                    answers.Add(answer);
                }

                reader.Close();
                reader.Dispose();
            }
            return answers;
        }

        private List<Models.Quiz> getQuizzes()
        {
            List<Models.Quiz> quizzes = new List<Models.Quiz>();
            string query = "SELECT * FROM quiz";

            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Models.Quiz quiz = new Models.Quiz();
                    quiz.idQuiz = reader.GetInt32(0);
                    quiz.Quizname = reader.GetString(1);
                    try { quiz.Image = reader.GetString(2); }catch(Exception e) { }
                    quizzes.Add(quiz);
                }
                reader.Close();
                reader.Dispose();
            }
            return quizzes;
        }


        // getter for the quizzes
        public List<Models.Quiz> Quizzes
        {
            get
            {
                return _quizzes;
            }
        }

        public Models.Quiz ActiveQuiz
        {
            get { return _activeQuiz; }
            set
            {
                // active quiz updated
                _activeQuiz = value;
                _activeQuiz.Questions = Questions(_activeQuiz.idQuiz);
                NotifyPropertyChanged("ActiveQuiz");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
