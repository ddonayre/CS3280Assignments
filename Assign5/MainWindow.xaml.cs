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

namespace Assign5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User user;
        private HighScoreWindow scoreWindow = new HighScoreWindow();
        public MainWindow()
        {
            InitializeComponent();
            checkUser();
            
        }

        private void checkUser()
        {
            if (user != null)
            {
                playGameButton.IsEnabled = true;
                highScoreButton.IsEnabled = true;
            }
            else
            {
                playGameButton.IsEnabled = false;
                highScoreButton.IsEnabled = false;
            }
        }
        private void PlayGameButton_Click(object sender, RoutedEventArgs e)
        {
           
            MathProblem problem = new AdditionProblem();
            var game = new GameWindow(problem);
            game.SetUser(ref user); 
            OpenWindow(game);
            scoreWindow.addScore(user);
        }

        private void HighScoreButton_Click(object sender, RoutedEventArgs e)
        {
            scoreWindow.addScore(user);
            OpenWindow(scoreWindow);          
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            var userWindow = new UserDataWindow();
            OpenWindow(userWindow);
            this.user = userWindow.User;
            checkUser();
        }

        private void OpenWindow(Window window)
        {
            this.Hide();
            window.ShowDialog();
            this.Show();
        }
    }
}
