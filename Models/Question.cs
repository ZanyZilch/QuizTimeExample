using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Models
{
    public class Question
    {
        public int idQuestion { get; set; }
        public string questionText { get; set; }
        public string image { get; set; }
        public int idQuiz { get; set; }
        public string QuestionType { get; set; }
        // MultipleChoice = 1
        // OneAnswer = 2
        public List<Answer> answerList { get; set; }

    }
}

