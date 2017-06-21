namespace Project2
{
    partial class frmCalculator
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
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.txtAgeEntry = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNameEntry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Location = new System.Drawing.Point(131, 28);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(113, 20);
            this.txtNameEntry.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNameEntry, "Enter a name here.");
            // 
            // txtAgeEntry
            // 
            this.txtAgeEntry.Location = new System.Drawing.Point(131, 62);
            this.txtAgeEntry.Name = "txtAgeEntry";
            this.txtAgeEntry.Size = new System.Drawing.Size(38, 20);
            this.txtAgeEntry.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtAgeEntry, "Enter age (in years) here.");
            this.txtAgeEntry.TextChanged += new System.EventHandler(this.txtAgeEntry_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(110, 101);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "&Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "Click here to concatinate.");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(197, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Clicking this button will close the Age Calculator program.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNameEntry
            // 
            this.lblNameEntry.AutoSize = true;
            this.lblNameEntry.Location = new System.Drawing.Point(87, 31);
            this.lblNameEntry.Name = "lblNameEntry";
            this.lblNameEntry.Size = new System.Drawing.Size(38, 13);
            this.lblNameEntry.TabIndex = 0;
            this.lblNameEntry.Text = "&Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Age (in years):";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(68, 149);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameEntry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAgeEntry);
            this.Controls.Add(this.txtNameEntry);
            this.Name = "frmCalculator";
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameEntry;
        private System.Windows.Forms.TextBox txtAgeEntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNameEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

