using QuizTime.Models;
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

namespace QuizTime.Widgets
{
    /// <summary>
    /// Interaction logic for AnAnswer.xaml
    /// </summary>
    public partial class AnAnswer : UserControl
    {
        public string answerText { get; set; }
        public bool selected { get; set; }
        public bool Correct { get; set; }
        public string answerImage { get; set; }
        public AnAnswer(Answer answer)
        {
            InitializeComponent();

            answerText = answer.answerText;
            Correct = answer.correct;
            answerImage = answer.image;
            lblquestionText.Content = answer.answerText;
            this.DataContext = this;

        }
    }
}
