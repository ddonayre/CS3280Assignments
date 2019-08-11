using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace Assign5
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private int currentProblem = 1;
        private int correctAnswers = 0;
        private Stopwatch timer;
        private DispatcherTimer dt = new DispatcherTimer();
        private Stopwatch sw = new Stopwatch();
        private MathProblem mathProblem;
        private User user;
        public GameWindow(MathProblem problem)
        {
            InitializeComponent();
            this.mathProblem = problem;
            dt.Tick += new EventHandler(tick);
            dt.Interval = new TimeSpan(0, 0, 1);
            sw.Start();
            dt.Start();
            NewProblem();
        }

        public void SetUser(ref User user)
        {
            this.user = user;
        }
        
        private void EndGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void tick(object sender, EventArgs e)
        {
            timeLabel.Content = $"{sw.Elapsed.Minutes:00}:{sw.Elapsed.Seconds:00}";
        }
        private void NewProblem()
        {
            this.mathProblem.GenerateProblem();
            this.numberALabel.Content = mathProblem.NumberA;
            this.numberBLabel.Content = mathProblem.NumberB;
            this.operatorLabel.Content = mathProblem.Operator;
            this.scoreLabel.Content = $"{correctAnswers}/{currentProblem}";
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // validate input in answerBox
            // convert answerbox.Text/Content to int
            // then compare answer to mathProblem.result
            if (Int32.TryParse(answerBox.Text, out int result))
            {
                if (result == mathProblem.Result)
                {

                    resultLabel.Content = "correct";
                    correctAnswers++;
                }
                else
                {
                    resultLabel.Content = "incorrect";
                }
            }
            else
            {
                resultLabel.Content = "Integers only";
            }

            if (currentProblem < 10)
            {
                NewProblem();
                currentProblem++;
            }
            else
            {
                Gameover();
            }


        }

        private void Gameover()
        {
            resultLabel.Content = "Gameover";
            HighScoreWindow scoreWindow = new HighScoreWindow();
            this.user.Score = correctAnswers;
            this.user.Time = sw.Elapsed.Minutes * 60 + sw.Elapsed.Seconds;
            this.Close();
        }
    }
}
