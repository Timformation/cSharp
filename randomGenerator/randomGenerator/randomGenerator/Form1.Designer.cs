namespace randomGenerator
{
    partial class frmHighLow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighLow));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(221, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(1, -1);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(93, 13);
            this.lblRandom.TabIndex = 0;
            this.lblRandom.Text = "(Random Number)";
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(105, 168);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 5;
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(221, 158);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(70, 37);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Submit &Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(130, 205);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(50, 13);
            this.lblOutcome.TabIndex = 7;
            this.lblOutcome.Text = "Outcome";
            this.lblOutcome.Click += new System.EventHandler(this.lblOutcome_Click);
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(6, 13);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(103, 13);
            this.lblGuesses.TabIndex = 0;
            this.lblGuesses.Text = "Number of Guesses:";
            // 
            // lblGuessCount
            // 
            this.lblGuessCount.AutoSize = true;
            this.lblGuessCount.Location = new System.Drawing.Point(115, 16);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(13, 13);
            this.lblGuessCount.TabIndex = 1;
            this.lblGuessCount.Text = "0";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(6, 31);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(91, 13);
            this.lblHighScore.TabIndex = 2;
            this.lblHighScore.Text = "Best (Low) Score:";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.Location = new System.Drawing.Point(140, -1);
            this.lblLogo.MaximumSize = new System.Drawing.Size(75, 75);
            this.lblLogo.MinimumSize = new System.Drawing.Size(75, 75);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(75, 75);
            this.lblLogo.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(271, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblBestScore);
            this.groupBox.Controls.Add(this.lblGuesses);
            this.groupBox.Controls.Add(this.lblGuessCount);
            this.groupBox.Controls.Add(this.lblHighScore);
            this.groupBox.Location = new System.Drawing.Point(42, 103);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(173, 47);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Location = new System.Drawing.Point(115, 31);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(13, 13);
            this.lblBestScore.TabIndex = 3;
            this.lblBestScore.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Guess:";
            // 
            // frmHighLow
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.btnStart);
            this.Name = "frmHighLow";
            this.Text = "High/Low Game";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label lblGuessCount;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label label3;
    }
}

