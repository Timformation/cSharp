using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheaterTest
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        MovieObj.oMovieCalc TicketCost = new MovieObj.oMovieCalc();

        private void btnCalc_Click(object sender, EventArgs e)
        {
            TicketCost.NumTickets = int.Parse(txtNumTickets.Text);
            TicketCost.TheaterNumber = int.Parse(txtTheaterNumber.Text);
            if (rdoIsStudent.Checked == true)
            {
                TicketCost.isStudent = true;
            }
            else
            {
                TicketCost.isStudent = false;
            }
            lblTotal.Text = TicketCost.GetCost().ToString();
           // lblTotal.Text = TicketCost.GetCost(2, 4, false).ToString();
        }
    }
}
