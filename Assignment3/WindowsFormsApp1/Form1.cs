using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string[] studentInfo;
        private int[,] assignmentScores;
        private int studentCursor = 0;
        private int numStudents = 0;
        private int numAssignmets = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Submit_count_Click(object sender, EventArgs e)
        {

            try
            {
                numStudents = Convert.ToInt32(numStudentsTextbox.Text);
               
                if (int.TryParse(numAssignmentsTextbox.Text, out numAssignmets) && numAssignmets >= 1  )
                { 
                    studentInfo = new string[numStudents];
                    assignmentScores = new int[numStudents, numAssignmets];
                    Enable_Form();
                    Populate_Arrays();
                    studentNameTextbox.Text = studentInfo[0];
                    label6.Text = $"Student #{1}";
                    

                }
                else { throw new Exception(); }
            }
            catch(Exception h)
            {
                MessageBox.Show("Enter a valid value ");
                Reset_CountField();
            }
        }

        private void Reset_scores_Click(object sender, EventArgs e)
        {
            Disable_Form();
            Reset_CountField();
        }

        private void First_student_Click(object sender, EventArgs e)
        {

                studentCursor = 0;
                studentNameTextbox.Text = studentInfo[0];
                label6.Text = $"Student #{1}";
             

        }
        private void Previous_student_Click(object sender, EventArgs e)
        {
            
            if (studentCursor <= 0)
            {
            }
            else
            {
                studentCursor = studentCursor - 1;
                studentNameTextbox.Text = studentInfo[studentCursor];
                label6.Text = $"Student #{studentCursor+1}";
            }
        }
        private void Next_student_Click(object sender, EventArgs e)
        {
           
            
            if (studentCursor >= numStudents-1)
            {
            }
            else
            {
                studentCursor = studentCursor + 1;
                studentNameTextbox.Text = studentInfo[studentCursor];
                label6.Text = $"Student #{studentCursor+1}";
            }
        }

        private void Last_student_Click(object sender, EventArgs e)
        {
            studentCursor = numStudents - 1;
            studentNameTextbox.Text = studentInfo[studentCursor];
            label6.Text = $"Student #{numStudents}";
           
        }

        private void Save_name_Click(object sender, EventArgs e)
        {
           
                studentInfo[studentCursor] = studentNameTextbox.Text;
            
        }

        private void Save_score_Click(object sender, EventArgs e)
        {
            try
            {
                int assign_value = 0;
                if (int.TryParse(enter_assignment_textbox.Text, out assign_value) && assign_value >= 1 )
                {
                    assignmentScores[studentCursor, assign_value - 1]
                       = Convert.ToInt32(assignment_score_textbox.Text);
                }
                else { throw new Exception(); }
            }
            catch (Exception h)
            {
                MessageBox.Show("Enter a valid number between 1-5");
                Reset_CountField();
            }

            enter_assignment_textbox.Text = "";
            assignment_score_textbox.Text = "";
            
        }

        private void Display_score_Click(object sender, EventArgs e)
        {
            displayScore();
        }

        private void Save_file_bttn_Click(object sender, EventArgs e)
        {
            displayScore();
            string[] allLines = DisplayScoreTextBox.Text.Split('\n');
            if (!save_file_textbox.Text.Equals(""))
            { OutputStringToFile(save_file_textbox.Text, allLines); }
            save_file_textbox.Text = "";
        }

       

        /// <summary>
        /// Outputs the string array to file. Each element in the array is a line of text.
        /// Output path - C:\Users\Public\<paramref name="fileName"/>
        /// </summary>
        /// <param name="output">The output.</param>
        /// <param name="fileName">Name of the file.</param>
        public void OutputStringToFile(string fileName, string[] outputLines)
        {
            try
            {
                // set file path
                string filePath = @"C:\Users\Public\" + fileName + ".txt";

                // check if file exists
                if (File.Exists(filePath))
                {
                    MessageBox.Show("This file already exists");
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        for (int i = 0; i < outputLines.Length; i++)
                            writer.WriteLine(outputLines[i] + "\n");
                    }

                    MessageBox.Show($"Success!\nSaved as: {fileName}\n At Location: \n{filePath}");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name +
                    "." + MethodInfo.GetCurrentMethod().Name + ": " + ex.ToString() + " -> " + ex.Message);
                
            }
        }

       
        private void displayScore()
        {
            DisplayScoreTextBox.Text = "";
            DisplayScoreTextBox.Text +=
                          $"Students\t\t";
            for (int k = 0; k < numAssignmets; k++)
            {
                DisplayScoreTextBox.Text +=
                  $"\t#{k}";
            }
            DisplayScoreTextBox.Text +=
                  $"\tAVG\tGRADE\n";

            for (int i = 0; i < numStudents; i++)
            {
                DisplayScoreTextBox.Text +=
                    $"{studentInfo[i]}\t   ";
                for (int t = 0; t < numAssignmets; t++)
                {
                    DisplayScoreTextBox.Text +=
                    $"\t{assignmentScores[i, t]}";
                }
                DisplayScoreTextBox.Text += $"\t{Average(i)}" +
                    $"\t{Grade(Average(i))}\n";

            }
        }
        private double Average(int indexrow)
        {
            double result= 0;
            for (int i = 0; i < numAssignmets; i++)
            {
                result += (assignmentScores[indexrow, i]);
            }
            return result/numAssignmets;
        }

        private char Grade(double avg)
        {

            if (avg >= 90.0)
            {
                return 'A';
            }

            if (avg >= 80.0)
            {
                return 'B';
            }

            if (avg >= 70.0)
            {
                return 'C';
            }

            if (avg >= 60.0)
            {
                return 'D';
            }

            return 'F';
        }
        private void Reset_CountField()
        {
            numStudentsTextbox.Text = "";
            numAssignmentsTextbox.Text = "";
        }
        private void Enable_Form()
        {

            numAssignmentsTextbox.Enabled = false;
            numStudentsTextbox.Enabled = false;
            SubmitButton.Enabled = false;
            reset_scores.Enabled = true;
            first_student.Enabled = true;
            previous_student.Enabled = true;
            next_student.Enabled = true;
            last_student.Enabled = true;
            save_name.Enabled = true;
            save_score.Enabled = true;
            assignment_score_textbox.Enabled = true;
            enter_assignment_textbox.Enabled = true;
            display_score.Enabled = true;
            DisplayScoreTextBox.Enabled = true;
            save_file_bttn.Enabled = true;
            save_file_textbox.Enabled = true;
            studentNameTextbox.Enabled = true;

        }
        private void Disable_Form()
        {

            numAssignmentsTextbox.Enabled = true;
            numStudentsTextbox.Enabled = true;
            SubmitButton.Enabled = true;
            reset_scores.Enabled = false;
            first_student.Enabled = false;
            previous_student.Enabled = false;
            next_student.Enabled = false;
            last_student.Enabled = false;
            save_name.Enabled = false;
            save_score.Enabled = false;
            assignment_score_textbox.Enabled = false;
            enter_assignment_textbox.Enabled = false;
            display_score.Enabled = false;
            DisplayScoreTextBox.Enabled = false;
            save_file_bttn.Enabled = false;
            save_file_textbox.Enabled = false;
            studentNameTextbox.Enabled = false;
        }

        private void Populate_Arrays()
        {
            for (int i = 0; i < numStudents; i++)
            {
                studentInfo[i] = $"Student #{i+1}";
                for(int t=0; t<numAssignmets;t++)
                {
                    assignmentScores[i,t] = 0;
                }
            }

        }

    }
}
