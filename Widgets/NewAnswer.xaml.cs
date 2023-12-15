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
    /// Interaction logic for NewAnswer.xaml
    /// </summary>
    public partial class NewAnswer : UserControl
    {
        public string answerText { get; set; }
        public bool Correct { get; set; }
        public string answerImage { get; set; }
        public NewAnswer()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnDeleteAnswer_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;
        }

        private void txtAnswer_TextInput(object sender, TextCompositionEventArgs e)
        {
            answerText = txtAnswer.Text;
        }

        private void btnUploadImage_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg"; // Specify the types of images which can be picked
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                answerImage = ofd.FileName;
                lblimageName.Content = ofd.FileName;
            }
        }
    }
}
