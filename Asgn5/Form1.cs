using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asgn5
{
    public partial class Form1 : Form
    {
        public int timeLeft;
        public int a;
        public int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timeLeft = 5;
            Random r = new Random();
            a = r.Next(12) + 1;
            b = r.Next(12) + 1;
            labelA.Text = a.ToString();
            labelB.Text = b.ToString();

            timer1.Start();

            startButton.Enabled = false;
            doneButton.Enabled = true;
                     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerLabel.Text = timeLeft.ToString();
            }

            if (timeLeft == 0)
            {
                doneButton.Enabled = false;
                startButton.Enabled = true;
                timer1.Stop();
                timerLabel.Text = "";

            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            doneButton.Enabled = false;
            startButton.Enabled = true;
            timer1.Stop();

            int c = a + b;
            if (answerBox.Text == c.ToString())
            {
                timer1.Stop();
                timerLabel.Text = "You win";
            }
            else
            {
                timerLabel.Text = "You lose";
            }
        





        }
    }
}
