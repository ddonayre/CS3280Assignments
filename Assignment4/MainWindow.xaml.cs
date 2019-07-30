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

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game game;
        public MainWindow()
        {
            InitializeComponent();
            ClearBoard();
            game = new Game();
        }

        private void ClearBoard()
        {
            PlayAgainButton.IsEnabled = true;

            cell00.Content = "";
            cell00.IsEnabled = true;
            cell01.Content = "";
            cell01.IsEnabled = true;
            cell02.Content = "";
            cell02.IsEnabled = true;

            cell10.Content = "";
            cell10.IsEnabled = true;
            cell11.Content = "";
            cell11.IsEnabled = true;
            cell12.Content = "";
            cell12.IsEnabled = true;

            cell20.Content = "";
            cell20.IsEnabled = true;
            cell21.Content = "";
            cell21.IsEnabled = true;
            cell22.Content = "";
            cell22.IsEnabled = true;       
        }

        private void Cell_Clicked(object sender, MouseButtonEventArgs e)
        {
            Label clickedCell = (Label)sender;
            var rowCol = clickedCell.Tag.ToString().Split('_');
            int row = int.Parse(rowCol[0]);
            int col = int.Parse(rowCol[1]);
            if (game.currentTurn == 1)
            {
                clickedCell.Content = game.p1;
            }
            else
            {
                clickedCell.Content = game.p2;
            }
                
            bool didWin = game.PlayerMove(row, col);
            clickedCell.IsEnabled = false;
            // set status label to currentTurn 

            player1WinsLabel.Content = "Player 1 Wins: " + game.p1wins.ToString();
            player2Winslabel.Content = "Player 2 Wins: " + game.p2wins.ToString();
            tieslabel.Content = $"Ties: {game.ties}";
            gamestatuslabel.Content = $"{game.playerTurn}";

            if (didWin)
                GameEnded();
        }
        private void GameEnded()
        {
            PlayAgainButton.IsEnabled = true;
            gamestatuslabel.Content = $"{game.winningPlayer}";
            // TODO set 'wins' label $"Player 1|2 wins: {p1wins | p2wins}"

            // set status label to $"Player {game.currentTurn} won!"
            if (game.Board[0, 0] == 0)
                cell00.IsEnabled = false;
            if (game.Board[0, 1] == 0)
                cell01.IsEnabled = false;
            if (game.Board[0,2] == 0)
                cell02.IsEnabled = false;           

            if (game.Board[1, 0] == 0)
                cell10.IsEnabled = false;
            if (game.Board[1, 1] == 0)
                cell11.IsEnabled = false;
            if (game.Board[1, 2] == 0)
                cell12.IsEnabled = false;          

            if (game.Board[2, 0] == 0)
                cell20.IsEnabled = false;
            if (game.Board[2, 1] == 0)
                cell21.IsEnabled = false;
            if (game.Board[2, 2] == 0)
                cell22.IsEnabled = false;
        }

        private void PlayAgainButton_Click(object sender, RoutedEventArgs e)
        {
            ClearBoard();
            game.NewGame();
        }

    
    }
}
