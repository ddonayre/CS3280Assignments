using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2
{
    public partial class Form1 : Form
    {
        private int timesPlayed = 0;
        private int timesWon = 0;
        private int timesLost = 0;
        private int[] frequencyRoll = new int[7];
        private int[] timesGuessed = new int[7];

        public Form1()
        {
            InitializeComponent();
            OutputTextBox.Text = "FACE\t      FREQUENCY\t       PERCENT\t      TIMES GUESSED\n"
                                 + "1\t\t0\t\t0%\t\t0\n"
                                 + "2\t\t0\t\t0%\t\t0\n"
                                 + "3\t\t0\t\t0%\t\t0\n"
                                 + "4\t\t0\t\t0%\t\t0\n"
                                 + "5\t\t0\t\t0%\t\t0\n"
                                 + "6\t\t0\t\t0%\t\t0\n";
            OutputTextBox.Refresh();
        }



        private void Button1_Click(object sender, EventArgs e)
        {

            timesPlayed += 1;
            int faceguessed = (int)numericUpDown1.Value;
            timesGuessed[faceguessed] += 1;

            Random random = new Random();
            int dice = 0;
            for (int i = 1; i < 7; i++)
            {

                dice = random.Next(1, 7);

                //show image's of dice roll
                DicePicBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject($"die{dice}"));
                DicePicBox.Refresh();
                Thread.Sleep(300);
            }
            //Check if won or lost
            if (faceguessed == dice)
            {
                timesWon += 1;
            }
            else
            {
                timesLost += 1;
            }


            int face = dice;
            frequencyRoll[face] = 1;

            LastGuessLabel.Text = $"your last guess:{faceguessed}";
            printValues();
        }

        void resetValue()
        {
            frequencyRoll = new int[7];
            timesGuessed = new int[7];
            //percent = new int[6];
            timesPlayed = 0;
            timesWon = 0;
            timesLost = 0;
            numericUpDown1.Value = 1;
        }

        void printValues()
        {
            TimesPlayedLabel.Text = $"Number of Times Played: {timesPlayed}";
            TimesWonLabel.Text = $"Number of Times Won: {timesWon}";
            TimesLostLabel.Text = $"Number of Time Lost: {timesLost}";

            OutputTextBox.Text = "FACE\t   FREQUENCY\t    PERCENT\t   TIMES GUESSED\n";

            for (int i = 1; i <= 6; i++)
            {

                double percentage = frequencyRoll[i] / (double)(timesPlayed);
                OutputTextBox.Text += $"{i}\t\t{frequencyRoll[i]}\t\t{percentage * 100:f3}%\t\t{timesGuessed[i]}\n";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            resetValue();
            printValues();
        }
    }
}
