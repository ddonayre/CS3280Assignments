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
using System.Windows.Shapes;

namespace Assign5
{
    /// <summary>
    /// Interaction logic for UserDataWindow.xaml
    /// </summary>
    public partial class UserDataWindow : Window
    {
        public User User { get; set; }
        public UserDataWindow()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(ageBox.Text, out int age) && nameBox.Text != "")
            {
                string name = nameBox.Text;
                User = new User(name, age);
                this.Hide();
            }
            else
                feedbackLabel.Content = "Please Enter Valid Name and Age";
            
        }
    }
}
