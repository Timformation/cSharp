namespace demoPod
{
    partial class POD
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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.rdoDiscountYes = new System.Windows.Forms.RadioButton();
            this.rdoDiscountNo = new System.Windows.Forms.RadioButton();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblQuantityPurchased = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(272, 38);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(317, 31);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.Text = "g";
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(272, 97);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(317, 31);
            this.txtPartNumber.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(272, 160);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(317, 31);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(272, 221);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(317, 31);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(234, 404);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(396, 190);
            this.txtShow.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(354, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(354, 629);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(162, 47);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rdoDiscountYes
            // 
            this.rdoDiscountYes.AutoSize = true;
            this.rdoDiscountYes.Location = new System.Drawing.Point(354, 275);
            this.rdoDiscountYes.Name = "rdoDiscountYes";
            this.rdoDiscountYes.Size = new System.Drawing.Size(81, 29);
            this.rdoDiscountYes.TabIndex = 8;
            this.rdoDiscountYes.TabStop = true;
            this.rdoDiscountYes.Text = "Yes";
            this.rdoDiscountYes.UseVisualStyleBackColor = true;
            // 
            // rdoDiscountNo
            // 
            this.rdoDiscountNo.AutoSize = true;
            this.rdoDiscountNo.Location = new System.Drawing.Point(465, 275);
            this.rdoDiscountNo.Name = "rdoDiscountNo";
            this.rdoDiscountNo.Size = new System.Drawing.Size(70, 29);
            this.rdoDiscountNo.TabIndex = 9;
            this.rdoDiscountNo.TabStop = true;
            this.rdoDiscountNo.Text = "No";
            this.rdoDiscountNo.UseVisualStyleBackColor = true;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(33, 44);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(165, 25);
            this.lblCompanyName.TabIndex = 10;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Location = new System.Drawing.Point(33, 97);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(132, 25);
            this.lblPartNumber.TabIndex = 11;
            this.lblPartNumber.Text = "Part Number";
            // 
            // lblQuantityPurchased
            // 
            this.lblQuantityPurchased.AutoSize = true;
            this.lblQuantityPurchased.Location = new System.Drawing.Point(33, 160);
            this.lblQuantityPurchased.Name = "lblQuantityPurchased";
            this.lblQuantityPurchased.Size = new System.Drawing.Size(201, 25);
            this.lblQuantityPurchased.TabIndex = 12;
            this.lblQuantityPurchased.Text = "Quantity Purchased";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(43, 221);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(105, 25);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(49, 277);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(185, 25);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Discount Applies?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(719, 629);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 68);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // POD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 709);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantityPurchased);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.rdoDiscountNo);
            this.Controls.Add(this.rdoDiscountYes);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.txtCompanyName);
            this.Name = "POD";
            this.Text = "POD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rdoDiscountYes;
        private System.Windows.Forms.RadioButton rdoDiscountNo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblQuantityPurchased;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnExit;
    }
}

