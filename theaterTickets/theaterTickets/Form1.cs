using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theaterTickets
{
    public partial class theaterTickets : Form
    {
        public theaterTickets()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double nonStudentTotal = 0;
            double dblTicketCost = 7.50;
            double dblStudentDiscount = 2.00;
            double dblCharge3D = 5.00;
            double dblClassicDiscount = .75;
            //TODO: Get calculate buttons to all share event handler & get student discount working. 
            if (txtTickets.Text == "")
            {
                MessageBox.Show("You must enter a number of tickets before you can calculate.");
                txtTickets.Focus();
            }
            else if (rdoTheater2.Checked == true)

            {

                lblTotal.Text = Math.Round(((double.Parse(txtTickets.Text) * dblTicketCost) * dblClassicDiscount), 1).ToString();
                nonStudentTotal = double.Parse(lblTotal.Text);


                if (chkStudent.Checked == true)
                    lblTotal.Text = Math.Round((double.Parse(lblTotal.Text)) - (dblStudentDiscount * double.Parse(txtTickets.Text)), 1).ToString("c");

                else
                {
                    lblTotal.Text = nonStudentTotal.ToString("c");
                }

            }

            else if (rdoTheater3.Checked == true)

            {
                lblTotal.Text = (double.Parse(txtTickets.Text) * dblTicketCost + (dblCharge3D * double.Parse(txtTickets.Text))).ToString();
                nonStudentTotal = double.Parse(lblTotal.Text);

                if (chkStudent.Checked == true)
                    lblTotal.Text = Math.Round((double.Parse(lblTotal.Text)) - (dblStudentDiscount * double.Parse(txtTickets.Text)), 1).ToString("c");
                else
                {
                    lblTotal.Text = nonStudentTotal.ToString("c");
                }
            }

            else

            {
                lblTotal.Text = (double.Parse(txtTickets.Text) * dblTicketCost).ToString();
                nonStudentTotal = double.Parse(lblTotal.Text);

                if (chkStudent.Checked == true)

                {
                    lblTotal.Text = Math.Round((double.Parse(lblTotal.Text)) - (dblStudentDiscount * double.Parse(txtTickets.Text)), 1).ToString("c");

                }
                else
                {
                    lblTotal.Text = nonStudentTotal.ToString("c");
                }
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTickets.Clear();
            chkStudent.Checked = false;
            rdoTheater1.Checked = true;
            lblTotal.Text = "";
        }

        private void txtTickets_Leave(object sender, EventArgs e)
        {
            int tryTickets;
            if (txtTickets.Text == "")
            {
                MessageBox.Show("Please enter a value.");
                txtTickets.Clear();
                txtTickets.Focus();
            }
            else if (!int.TryParse(txtTickets.Text, out tryTickets))
            {

                MessageBox.Show("Please enter a NUMERIC value.");
                txtTickets.Clear();
                txtTickets.Focus();

            }
            
        }

    
        

        private void theaterTickets_Load(object sender, EventArgs e)
        {

        }

    }
}
    
    
