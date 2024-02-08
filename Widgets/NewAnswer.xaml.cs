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
        public int answerID { get; set; }
        public string answerText { get; set; }
        public bool Correct { get; set; }
        public string answerImage { get; set; }

        public NewAnswer()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public NewAnswer(int id, string text, bool correct, string image)
        {
            InitializeComponent();
            answerID = id;
            answerText = text;
            Correct = correct;
            answerImage = image;

            txtAnswer.Text = text;
            cbxCorrect.IsChecked = correct;
            lblimageName.Content = image;

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

        public event EventHandler Selected;

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    UpdateVisualState();

                    if (_isSelected)
                        Selected?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (IsSelected)
            {
                IsSelected = false;
            }
            else
            {
                IsSelected = true; // Select the current control

                // Unselect other NewAnswer controls within the parent container
                var parent = Parent as Panel;
                if (parent != null)
                {
                    foreach (var child in parent.Children)
                    {
                        if (child is NewAnswer otherAnswer && otherAnswer != this)
                        {
                            otherAnswer.IsSelected = false;
                        }
                    }
                }
            }
        }
        private void UpdateVisualState()
        {
            // Modify visual state based on the IsSelected property
            if (IsSelected)
            {
                // Apply a selected style or change the appearance when selected
                // For example, change the background color or border
                this.Background = Brushes.LightBlue;
            }
            else
            {
                // Revert to the default style or appearance when not selected
                // For example, revert the background color or border
                this.Background = Brushes.Transparent;
            }
        }
    }
}
