using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Game
    {
        public int[,] Board;
        public char p1 ='X';
        public char p2 ='O';
        public string winningPlayer;
        private int _p1wins;
        private int _p2wins;
        public int p1wins
        {
            get { return _p1wins; }
            set
            {
                _p1wins = value;
                if (_p1wins != 0)
                {
                    if (currentTurn == 1)
                        winningPlayer = $"Player {p1} wins!";
                    else
                        winningPlayer = $"Player {p2} wins!";
                }
            }
        }

        public int p2wins
        {
            get { return _p2wins; }
            set
            {
                _p2wins = value;
                if (_p2wins != 0)
                {
                    if (currentTurn == 1)
                        winningPlayer = $"Player {p1} wins!";
                    else
                        winningPlayer = $"Player {p2} wins!";
                }
            }
        }
    
        public int ties;
        public string playerTurn;
        private int _currentTurn;
        public int currentTurn
        {
            get { return _currentTurn; }
            set
            {
                _currentTurn = value;
                if (currentTurn == 1)
                    playerTurn = $"Player {p1}, it is your turn";
                else
                    playerTurn = $"Player {p2}, it is your turn";
            }
        }

        public Game()
        {
            p1wins = 0;
            p2wins = 0;
            ties = 0;
            NewGame();
        }

        public void NewGame()
        {
            currentTurn = 1;
            Board = new int[3,3];
        }
        public bool CheckForWin()
        {
            if (CheckVerticalWin() || CheckHorizontalWin() || CheckDiagnalWin())
                if (currentTurn == 1)
                {
                    p1wins += 1;
                    return true;
                }
                else
                {
                    p2wins += 1;
                    return true;
                }
            //return true;
            //Check for full board for tie
            else
            {
                if (CheckTie())
                {
                    ties += 1;
                    winningPlayer = "Game Tied!";
                    return true;
                }
            }

            return false;
        }

        private bool CheckHorizontalWin()
        {
            if ((Board[0,0] == currentTurn && Board[0,1] == currentTurn && Board[0,2] == currentTurn) ||
                (Board[1,0] == currentTurn && Board[1,1] == currentTurn && Board[1,2] == currentTurn) ||
                (Board[2,0] == currentTurn && Board[2,1] == currentTurn && Board[2,2] == currentTurn))
                return true;
            
            return false;
        }

        private bool CheckTie()
        {
            if ((Board[0, 0] != 0 && Board[0, 1] != 0 && Board[0, 2] != 0) &&
                (Board[1, 0] != 0 && Board[1, 1] != 0 && Board[1, 2] != 0) &&
                (Board[2, 0] != 0 && Board[2, 1] != 0 && Board[2, 2] != 0))
                return true;

            return false;
        }

        private bool CheckDiagnalWin()
        {
            if ((Board[0,0] == currentTurn && Board[1,1] == currentTurn && Board[2,2] == currentTurn) ||
                (Board[0,2] == currentTurn && Board[1,1] == currentTurn && Board[2,0] == currentTurn)) 
                return true;
            
            return false;
        }

        private bool CheckVerticalWin()
        {
            if ((Board[0,0] == currentTurn && Board[1,0] == currentTurn && Board[2,0] == currentTurn) ||
                (Board[0,1] == currentTurn && Board[1,1] == currentTurn && Board[2,1] == currentTurn) ||
                (Board[0,2] == currentTurn && Board[1,2] == currentTurn && Board[2,2] == currentTurn))
                return true;
            return false;
        }

        public bool PlayerMove(int row, int col)
        {
            if (Board[row, col] != 0)
                return false;
            Board[row,col] = currentTurn;
            bool didWin = this.CheckForWin();
            if (currentTurn == 1)
            {
                currentTurn = 2;
            }
            else
            {
                currentTurn = 1;
            }
            return didWin;
        }
    }
}
