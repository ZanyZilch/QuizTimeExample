using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Models
{
    public class Answer
    {
        public int idAnswer { get; set; }
        public string answerText { get; set; }
        public string image { get; set; }
        public bool correct { get; set; }
    }
}
