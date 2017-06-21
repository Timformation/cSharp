namespace TheaterTest
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTheaterNumber = new System.Windows.Forms.TextBox();
            this.txtNumTickets = new System.Windows.Forms.TextBox();
            this.rdoIsStudent = new System.Windows.Forms.RadioButton();
            this.rdoNotAStudent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(497, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label1";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(622, 281);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(152, 74);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Test";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTheaterNumber
            // 
            this.txtTheaterNumber.Location = new System.Drawing.Point(405, 74);
            this.txtTheaterNumber.Name = "txtTheaterNumber";
            this.txtTheaterNumber.Size = new System.Drawing.Size(100, 31);
            this.txtTheaterNumber.TabIndex = 2;
            // 
            // txtNumTickets
            // 
            this.txtNumTickets.Location = new System.Drawing.Point(405, 140);
            this.txtNumTickets.Name = "txtNumTickets";
            this.txtNumTickets.Size = new System.Drawing.Size(100, 31);
            this.txtNumTickets.TabIndex = 3;
            // 
            // rdoIsStudent
            // 
            this.rdoIsStudent.AutoSize = true;
            this.rdoIsStudent.Location = new System.Drawing.Point(418, 207);
            this.rdoIsStudent.Name = "rdoIsStudent";
            this.rdoIsStudent.Size = new System.Drawing.Size(157, 29);
            this.rdoIsStudent.TabIndex = 4;
            this.rdoIsStudent.TabStop = true;
            this.rdoIsStudent.Text = "Is a Student";
            this.rdoIsStudent.UseVisualStyleBackColor = true;
            // 
            // rdoNotAStudent
            // 
            this.rdoNotAStudent.AutoSize = true;
            this.rdoNotAStudent.Location = new System.Drawing.Point(418, 242);
            this.rdoNotAStudent.Name = "rdoNotAStudent";
            this.rdoNotAStudent.Size = new System.Drawing.Size(196, 29);
            this.rdoNotAStudent.TabIndex = 5;
            this.rdoNotAStudent.TabStop = true;
            this.rdoNotAStudent.Text = "Is Not a Student";
            this.rdoNotAStudent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 432);
            this.Controls.Add(this.rdoNotAStudent);
            this.Controls.Add(this.rdoIsStudent);
            this.Controls.Add(this.txtNumTickets);
            this.Controls.Add(this.txtTheaterNumber);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTheaterNumber;
        private System.Windows.Forms.TextBox txtNumTickets;
        private System.Windows.Forms.RadioButton rdoIsStudent;
        private System.Windows.Forms.RadioButton rdoNotAStudent;
    }
}

