using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QuizTime.Models
{
    public class Quiz
    {
        public int idQuiz { get; set; }
        public string Quizname { get; set; }
        public string Image { get; set; }

        public List<Question> Questions { get; set; }

    }
}
