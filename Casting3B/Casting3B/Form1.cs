using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting3B
{
    public partial class Form1 : Form
    {
        int intNum1 = 30;
        double dblNum2 = 45.3;
        string strNum3;
        int intNum5;


        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum4.Text = intNum1.ToString();
            strNum3 = txtNum4.Text;
            dblNum2 = intNum1;
            intNum1 = int.Parse(dblNum2);
            txtNum4.Text = (dblNum2 * 2).ToString();
            intNum1 = int.Parse(txtNum4.Text);
            dblNum2 = double.Parse(txtNum4.Text);
            txtNum4.Text = (dblNum2 * 2).ToString();
            txtNum4.Text = ("The value is " + dblNum2.ToString("c")).ToString();




        }
    }



