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
    /// Interaction logic for HighScoreWindow.xaml
    /// </summary>
    public partial class HighScoreWindow : Window
    {
        private User score;
    
        public HighScoreWindow()
        {
            InitializeComponent();
        }
        public void addScore(User user)
        {
            score = user;
            scoreLabel.Content = $"{score.Name}\t{score.Score}\t{score.Time}";
        }
        private void CloseHighScorebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            
        }
    }
}
