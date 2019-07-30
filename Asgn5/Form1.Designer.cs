namespace Asgn5
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
            this.doneButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.TextBox();
            this.plusLabel = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Enabled = false;
            this.doneButton.Location = new System.Drawing.Point(34, 281);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(198, 56);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(34, 399);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(198, 56);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(34, 197);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(351, 22);
            this.answerBox.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(34, 87);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(54, 22);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "0";
            // 
            // plusLabel
            // 
            this.plusLabel.Location = new System.Drawing.Point(129, 87);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(22, 22);
            this.plusLabel.TabIndex = 4;
            this.plusLabel.Text = "+";
            // 
            // labelB
            // 
            this.labelB.Location = new System.Drawing.Point(184, 87);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(86, 22);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "0";
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(366, 87);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(160, 22);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 522);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.doneButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.TextBox labelA;
        private System.Windows.Forms.TextBox plusLabel;
        private System.Windows.Forms.TextBox labelB;
        private System.Windows.Forms.TextBox timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

