using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoPod
{
    public partial class POD : Form
    {
        public POD()
        {
            InitializeComponent();
        }

        podAssignment.pod myPod = new podAssignment.pod();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myPod.CompanyName = txtCompanyName.Text;
            myPod.PartNumber = txtPartNumber.Text;
            try
            {
                myPod.QtyPurchased = int.Parse(txtQuantity.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Please enter a whole number value for quantity purchased.");
                txtQuantity.Clear();
                txtQuantity.Focus();
                return;
            }
            try
            {
                myPod.UnitPrice = double.Parse(txtUnitPrice.Text);
            }
            catch (FormatException)
            {

                MessageBox.Show("Please enter a numeric value for unit price.");
                txtUnitPrice.Clear();
                txtUnitPrice.Focus();
                return;
            }

            if (rdoDiscountYes.Checked == true)
            {
                myPod.Discount = true;
            }
            else
            {
                myPod.Discount = false;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtShow.Text =
                  myPod.CompanyName
                + Environment.NewLine + myPod.QtyPurchased
                + Environment.NewLine + myPod.PartNumber
                + Environment.NewLine + myPod.UnitPrice
                + Environment.NewLine + myPod.Discount;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
