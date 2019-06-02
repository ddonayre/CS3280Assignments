using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show($"You Typed: {textBox1.Text}", "MessageBox 1",MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
            label4.Text = "You clicked the " + result.ToString() + " button";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show($"You Typed: {textBox2.Text}", "MessageBox 2", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            label4.Text = "You clicked the " + result.ToString() + " button";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show($"You Typed: {textBox3.Text}", "MessageBox 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            label4.Text = "You clicked the " + result.ToString() + " button";
        }
    }
}
