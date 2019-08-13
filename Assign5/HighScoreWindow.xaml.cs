using System;
using System.Windows;

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
