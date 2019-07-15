namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numStudentsTextbox = new System.Windows.Forms.TextBox();
            this.numAssignmentsTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.reset_scores = new System.Windows.Forms.Button();
            this.first_student = new System.Windows.Forms.Button();
            this.previous_student = new System.Windows.Forms.Button();
            this.next_student = new System.Windows.Forms.Button();
            this.last_student = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.studentNameTextbox = new System.Windows.Forms.TextBox();
            this.save_name = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.save_score = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.assignment_score_textbox = new System.Windows.Forms.TextBox();
            this.enter_assignment_textbox = new System.Windows.Forms.TextBox();
            this.assignmentNumberLabel = new System.Windows.Forms.Label();
            this.display_score = new System.Windows.Forms.Button();
            this.save_file_bttn = new System.Windows.Forms.Button();
            this.save_file_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayScoreTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of students:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of assignments:";
            // 
            // numStudentsTextbox
            // 
            this.numStudentsTextbox.Location = new System.Drawing.Point(201, 28);
            this.numStudentsTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.numStudentsTextbox.Name = "numStudentsTextbox";
            this.numStudentsTextbox.Size = new System.Drawing.Size(53, 22);
            this.numStudentsTextbox.TabIndex = 3;
            // 
            // numAssignmentsTextbox
            // 
            this.numAssignmentsTextbox.Location = new System.Drawing.Point(202, 69);
            this.numAssignmentsTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.numAssignmentsTextbox.Name = "numAssignmentsTextbox";
            this.numAssignmentsTextbox.Size = new System.Drawing.Size(52, 22);
            this.numAssignmentsTextbox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(281, 44);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(128, 37);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit Counts";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Submit_count_Click);
            // 
            // reset_scores
            // 
            this.reset_scores.Enabled = false;
            this.reset_scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_scores.Location = new System.Drawing.Point(681, 31);
            this.reset_scores.Margin = new System.Windows.Forms.Padding(4);
            this.reset_scores.Name = "reset_scores";
            this.reset_scores.Size = new System.Drawing.Size(98, 55);
            this.reset_scores.TabIndex = 6;
            this.reset_scores.Text = "Reset Scores";
            this.reset_scores.UseVisualStyleBackColor = true;
            this.reset_scores.Click += new System.EventHandler(this.Reset_scores_Click);
            // 
            // first_student
            // 
            this.first_student.Enabled = false;
            this.first_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_student.Location = new System.Drawing.Point(25, 23);
            this.first_student.Margin = new System.Windows.Forms.Padding(4);
            this.first_student.Name = "first_student";
            this.first_student.Size = new System.Drawing.Size(149, 28);
            this.first_student.TabIndex = 8;
            this.first_student.Text = "<< First Student";
            this.first_student.UseVisualStyleBackColor = true;
            this.first_student.Click += new System.EventHandler(this.First_student_Click);
            // 
            // previous_student
            // 
            this.previous_student.Enabled = false;
            this.previous_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_student.Location = new System.Drawing.Point(201, 23);
            this.previous_student.Margin = new System.Windows.Forms.Padding(4);
            this.previous_student.Name = "previous_student";
            this.previous_student.Size = new System.Drawing.Size(156, 28);
            this.previous_student.TabIndex = 9;
            this.previous_student.Text = "< Prev Student";
            this.previous_student.UseVisualStyleBackColor = true;
            this.previous_student.Click += new System.EventHandler(this.Previous_student_Click);
            // 
            // next_student
            // 
            this.next_student.Enabled = false;
            this.next_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_student.Location = new System.Drawing.Point(384, 23);
            this.next_student.Margin = new System.Windows.Forms.Padding(4);
            this.next_student.Name = "next_student";
            this.next_student.Size = new System.Drawing.Size(132, 28);
            this.next_student.TabIndex = 10;
            this.next_student.Text = "> Next Student";
            this.next_student.UseVisualStyleBackColor = true;
            this.next_student.Click += new System.EventHandler(this.Next_student_Click);
            // 
            // last_student
            // 
            this.last_student.Enabled = false;
            this.last_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_student.Location = new System.Drawing.Point(543, 23);
            this.last_student.Margin = new System.Windows.Forms.Padding(4);
            this.last_student.Name = "last_student";
            this.last_student.Size = new System.Drawing.Size(155, 28);
            this.last_student.TabIndex = 11;
            this.last_student.Text = ">> Last Student";
            this.last_student.UseVisualStyleBackColor = true;
            this.last_student.Click += new System.EventHandler(this.Last_student_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student #:";
            // 
            // studentNameTextbox
            // 
            this.studentNameTextbox.Enabled = false;
            this.studentNameTextbox.Location = new System.Drawing.Point(121, 32);
            this.studentNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.studentNameTextbox.Name = "studentNameTextbox";
            this.studentNameTextbox.Size = new System.Drawing.Size(288, 22);
            this.studentNameTextbox.TabIndex = 14;
            // 
            // save_name
            // 
            this.save_name.Enabled = false;
            this.save_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_name.Location = new System.Drawing.Point(435, 29);
            this.save_name.Margin = new System.Windows.Forms.Padding(4);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(100, 28);
            this.save_name.TabIndex = 15;
            this.save_name.Text = "Save Name";
            this.save_name.UseVisualStyleBackColor = true;
            this.save_name.Click += new System.EventHandler(this.Save_name_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numStudentsTextbox);
            this.groupBox1.Controls.Add(this.numAssignmentsTextbox);
            this.groupBox1.Controls.Add(this.SubmitButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(438, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Count";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.first_student);
            this.groupBox2.Controls.Add(this.previous_student);
            this.groupBox2.Controls.Add(this.next_student);
            this.groupBox2.Controls.Add(this.last_student);
            this.groupBox2.Location = new System.Drawing.Point(37, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(742, 74);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.studentNameTextbox);
            this.groupBox3.Controls.Add(this.save_name);
            this.groupBox3.Location = new System.Drawing.Point(37, 196);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(564, 74);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.save_score);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.assignment_score_textbox);
            this.groupBox4.Controls.Add(this.enter_assignment_textbox);
            this.groupBox4.Controls.Add(this.assignmentNumberLabel);
            this.groupBox4.Location = new System.Drawing.Point(37, 277);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(564, 135);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Info";
            // 
            // save_score
            // 
            this.save_score.Enabled = false;
            this.save_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_score.Location = new System.Drawing.Point(384, 53);
            this.save_score.Margin = new System.Windows.Forms.Padding(4);
            this.save_score.Name = "save_score";
            this.save_score.Size = new System.Drawing.Size(100, 28);
            this.save_score.TabIndex = 4;
            this.save_score.Text = "Save Score";
            this.save_score.UseVisualStyleBackColor = true;
            this.save_score.Click += new System.EventHandler(this.Save_score_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment Score:";
            // 
            // assignment_score_textbox
            // 
            this.assignment_score_textbox.Enabled = false;
            this.assignment_score_textbox.Location = new System.Drawing.Point(271, 76);
            this.assignment_score_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.assignment_score_textbox.Name = "assignment_score_textbox";
            this.assignment_score_textbox.Size = new System.Drawing.Size(60, 22);
            this.assignment_score_textbox.TabIndex = 2;
            // 
            // enter_assignment_textbox
            // 
            this.enter_assignment_textbox.Enabled = false;
            this.enter_assignment_textbox.Location = new System.Drawing.Point(271, 39);
            this.enter_assignment_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.enter_assignment_textbox.Name = "enter_assignment_textbox";
            this.enter_assignment_textbox.Size = new System.Drawing.Size(60, 22);
            this.enter_assignment_textbox.TabIndex = 1;
            // 
            // assignmentNumberLabel
            // 
            this.assignmentNumberLabel.AutoSize = true;
            this.assignmentNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentNumberLabel.Location = new System.Drawing.Point(12, 42);
            this.assignmentNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignmentNumberLabel.Name = "assignmentNumberLabel";
            this.assignmentNumberLabel.Size = new System.Drawing.Size(242, 17);
            this.assignmentNumberLabel.TabIndex = 0;
            this.assignmentNumberLabel.Text = "Enter Assignment Number (1-5):";
            // 
            // display_score
            // 
            this.display_score.Enabled = false;
            this.display_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_score.Location = new System.Drawing.Point(385, 429);
            this.display_score.Margin = new System.Windows.Forms.Padding(4);
            this.display_score.Name = "display_score";
            this.display_score.Size = new System.Drawing.Size(136, 28);
            this.display_score.TabIndex = 20;
            this.display_score.Text = "Display Scores";
            this.display_score.UseVisualStyleBackColor = true;
            this.display_score.Click += new System.EventHandler(this.Display_score_Click);
            // 
            // save_file_bttn
            // 
            this.save_file_bttn.Enabled = false;
            this.save_file_bttn.Location = new System.Drawing.Point(776, 628);
            this.save_file_bttn.Margin = new System.Windows.Forms.Padding(4);
            this.save_file_bttn.Name = "save_file_bttn";
            this.save_file_bttn.Size = new System.Drawing.Size(100, 28);
            this.save_file_bttn.TabIndex = 22;
            this.save_file_bttn.Text = "Save File";
            this.save_file_bttn.UseVisualStyleBackColor = true;
            this.save_file_bttn.Click += new System.EventHandler(this.Save_file_bttn_Click);
            // 
            // save_file_textbox
            // 
            this.save_file_textbox.Enabled = false;
            this.save_file_textbox.Location = new System.Drawing.Point(463, 628);
            this.save_file_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.save_file_textbox.Name = "save_file_textbox";
            this.save_file_textbox.Size = new System.Drawing.Size(252, 22);
            this.save_file_textbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 634);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Save File Enter Name:";
            // 
            // DisplayScoreTextBox
            // 
            this.DisplayScoreTextBox.Location = new System.Drawing.Point(37, 478);
            this.DisplayScoreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayScoreTextBox.Name = "DisplayScoreTextBox";
            this.DisplayScoreTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.DisplayScoreTextBox.Size = new System.Drawing.Size(812, 125);
            this.DisplayScoreTextBox.TabIndex = 26;
            this.DisplayScoreTextBox.Text = "";
            this.DisplayScoreTextBox.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 667);
            this.Controls.Add(this.DisplayScoreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_file_textbox);
            this.Controls.Add(this.save_file_bttn);
            this.Controls.Add(this.display_score);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset_scores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Scores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numStudentsTextbox;
        private System.Windows.Forms.TextBox numAssignmentsTextbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button reset_scores;
        private System.Windows.Forms.Button first_student;
        private System.Windows.Forms.Button previous_student;
        private System.Windows.Forms.Button next_student;
        private System.Windows.Forms.Button last_student;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentNameTextbox;
        private System.Windows.Forms.Button save_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button save_score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assignment_score_textbox;
        private System.Windows.Forms.TextBox enter_assignment_textbox;
        private System.Windows.Forms.Label assignmentNumberLabel;
        private System.Windows.Forms.Button display_score;
        private System.Windows.Forms.Button save_file_bttn;
        private System.Windows.Forms.TextBox save_file_textbox;
        private System.Windows.Forms.Label label5;
      
        private System.Windows.Forms.RichTextBox DisplayScoreTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

