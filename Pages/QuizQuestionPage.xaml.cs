﻿using QuizTime.Models;
using QuizTime.Widgets;
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

namespace QuizTime.Pages
{
    /// <summary>
    /// Interaction logic for QuizQuestionPage.xaml
    /// </summary>
    public partial class QuizQuestionPage : Page
    {
        public Question currentQuestion;
        private List<string> _userAnswers = new List<string>();
        public QuizQuestionPage(Question thisQuestion)
        {
            InitializeComponent();
            this.currentQuestion = thisQuestion;
            questionText.Text = currentQuestion.questionText;

            if (!string.IsNullOrEmpty(thisQuestion.image) && !string.Equals(thisQuestion.image, "..."))
            {
                Uri imagePath = new Uri(thisQuestion.image);
                BitmapImage bitmap = new BitmapImage(imagePath);
                imgQuestion.Source = bitmap;
            }
            PopulateAnswers();
        }
   
        public void PopulateAnswers()
        {
            int row = 0;
            int column = 0;


            foreach (Answer answer in currentQuestion.answerList)
            {
                AnAnswer answerControl = new AnAnswer(answer);
                Grid.SetRow(answerControl, row);
                Grid.SetColumn(answerControl, column);

                AnswerGrid.Children.Add(answerControl);

                column++;
                if (column == 2)
                {
                    column = 0;
                    row++;
                }
            }
        }

        public void SaveUserAnswer(Answer answer)
        {
            _userAnswers.Add(answer.answerText);
        }
        public List<string> GetUserAnswers()
        {
            return _userAnswers;
        }
    }
}
