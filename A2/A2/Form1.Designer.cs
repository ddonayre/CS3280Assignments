namespace A2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimesLostLabel = new System.Windows.Forms.Label();
            this.TimesWonLabel = new System.Windows.Forms.Label();
            this.TimesPlayedLabel = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LastGuessLabel = new System.Windows.Forms.Label();
            this.DicePicBox = new System.Windows.Forms.PictureBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DicePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimesLostLabel);
            this.groupBox1.Controls.Add(this.TimesWonLabel);
            this.groupBox1.Controls.Add(this.TimesPlayedLabel);
            this.groupBox1.Location = new System.Drawing.Point(165, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Info";
            // 
            // TimesLostLabel
            // 
            this.TimesLostLabel.AutoSize = true;
            this.TimesLostLabel.Location = new System.Drawing.Point(6, 107);
            this.TimesLostLabel.Name = "TimesLostLabel";
            this.TimesLostLabel.Size = new System.Drawing.Size(151, 17);
            this.TimesLostLabel.TabIndex = 2;
            this.TimesLostLabel.Text = "Number of Times Lost:";
            // 
            // TimesWonLabel
            // 
            this.TimesWonLabel.AutoSize = true;
            this.TimesWonLabel.Location = new System.Drawing.Point(6, 74);
            this.TimesWonLabel.Name = "TimesWonLabel";
            this.TimesWonLabel.Size = new System.Drawing.Size(153, 17);
            this.TimesWonLabel.TabIndex = 1;
            this.TimesWonLabel.Text = "Number of Times Won:";
            // 
            // TimesPlayedLabel
            // 
            this.TimesPlayedLabel.AutoSize = true;
            this.TimesPlayedLabel.Location = new System.Drawing.Point(6, 42);
            this.TimesPlayedLabel.Name = "TimesPlayedLabel";
            this.TimesPlayedLabel.Size = new System.Drawing.Size(167, 17);
            this.TimesPlayedLabel.TabIndex = 0;
            this.TimesPlayedLabel.Text = "Number of Times Played:";
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(174, 273);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 23);
            this.RollButton.TabIndex = 2;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(398, 273);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your guess:";
            // 
            // LastGuessLabel
            // 
            this.LastGuessLabel.AutoSize = true;
            this.LastGuessLabel.Location = new System.Drawing.Point(341, 202);
            this.LastGuessLabel.Name = "LastGuessLabel";
            this.LastGuessLabel.Size = new System.Drawing.Size(118, 17);
            this.LastGuessLabel.TabIndex = 5;
            this.LastGuessLabel.Text = "Your Last Guess:";
            // 
            // DicePicBox
            // 
            this.DicePicBox.Image = global::A2.Properties.Resources.die1;
            this.DicePicBox.Location = new System.Drawing.Point(58, 253);
            this.DicePicBox.Name = "DicePicBox";
            this.DicePicBox.Size = new System.Drawing.Size(100, 64);
            this.DicePicBox.TabIndex = 6;
            this.DicePicBox.TabStop = false;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(58, 357);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(499, 96);
            this.OutputTextBox.TabIndex = 7;
            this.OutputTextBox.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(288, 202);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 553);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.DicePicBox);
            this.Controls.Add(this.LastGuessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DicePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Label TimesPlayedLabel;
        private System.Windows.Forms.Label TimesLostLabel;
        private System.Windows.Forms.Label TimesWonLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastGuessLabel;
        private System.Windows.Forms.PictureBox DicePicBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

