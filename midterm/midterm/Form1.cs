using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            lblProduct.Text = Calculate(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)).ToString();
            }

        private double Calculate(double Num1, double Num2)
        {

            return (Num1 * Num2);

        }

    }

        

      
        }



        
        



