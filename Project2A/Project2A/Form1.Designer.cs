namespace Project2A
{
    partial class MultiMachine
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHighScorer = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(54, 82);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(21, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(101, 82);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(21, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(147, 82);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(35, 20);
            this.txtAnswer.TabIndex = 2;
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(81, 85);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(14, 13);
            this.LblX.TabIndex = 3;
            this.LblX.Text = "X";
            this.LblX.Click += new System.EventHandler(this.LblX_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(33, 9);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(77, 13);
            this.lblHighScore.TabIndex = 4;
            this.lblHighScore.Text = "HIGH SCORE:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblHighScorer
            // 
            this.lblHighScorer.AutoSize = true;
            this.lblHighScorer.Location = new System.Drawing.Point(135, 9);
            this.lblHighScorer.Name = "lblHighScorer";
            this.lblHighScorer.Size = new System.Drawing.Size(128, 13);
            this.lblHighScorer.TabIndex = 6;
            this.lblHighScorer.Text = "NO HIGH SCORER YET!";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(53, 156);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(87, 13);
            this.lblCorrect.TabIndex = 7;
            this.lblCorrect.Text = "Correct Answers:";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Location = new System.Drawing.Point(128, 85);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(13, 13);
            this.lblEquals.TabIndex = 8;
            this.lblEquals.Text = "=";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(53, 127);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(95, 13);
            this.lblIncorrect.TabIndex = 9;
            this.lblIncorrect.Text = "Incorrect Answers:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(53, 184);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(65, 13);
            this.lblPercentage.TabIndex = 10;
            this.lblPercentage.Text = "Percentage:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(54, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Click Here to &Start the Timer!";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // MultiMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 276);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblHighScorer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "MultiMachine";
            this.Text = "Multi-Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHighScorer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnStart;
    }
}

