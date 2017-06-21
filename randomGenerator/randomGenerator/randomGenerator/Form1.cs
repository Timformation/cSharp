using System;
using System.Windows.Forms;

namespace randomGenerator
{
    public partial class frmHighLow : Form
    {
        int randomNumber;
        int intGuessCount;
        int intGuess;
        int intBestLowScore = 11;
        public frmHighLow()
        {
            InitializeComponent();      
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(0, 1000);
            lblRandom.Text = randomNumber.ToString();
            intGuessCount = 0;
            btnStart.Enabled = false;
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            txtGuess.Focus();
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            intGuessCount = intGuessCount + 1;
            lblGuessCount.Text = (intGuessCount).ToString();
            if (!isNumberInt(txtGuess.Text))
            {
                MessageBox.Show("Numbers Only.");
                txtGuess.Text = "";
                txtGuess.Focus();
            }
            else
            {
                intGuess = int.Parse(txtGuess.Text);
                if (intGuess < randomNumber)
                {
                    lblOutcome.Text = "Too Low!";
                    txtGuess.Text = "";
                    txtGuess.Focus();
                    if (intGuessCount == 10)
                    {
                        MessageBox.Show("GAMEOVER! The number was: " + randomNumber.ToString());
                        btnStart.Enabled = true;
                        btnGuess.Enabled = false;
                        txtGuess.Enabled = false;
                    }
                }
                else if (intGuess > randomNumber)
                {
                    lblOutcome.Text = "Too High!";
                    txtGuess.Text = "";
                    txtGuess.Focus();
                    if (intGuessCount == 10)
                    {
                        MessageBox.Show("GAMEOVER! The number was: " + randomNumber.ToString());
                        btnStart.Enabled = true;
                        btnGuess.Enabled = false;
                        txtGuess.Enabled = false;
                    }
                }
                else
                {
                    lblOutcome.Text = "You guessed it in " + lblGuessCount.Text + " attempts.";
                    btnStart.Enabled = true;
                    btnGuess.Enabled = false;
                    txtGuess.Enabled = false;
                    if (intGuessCount < intBestLowScore)
                    {
                        intBestLowScore = intGuessCount;
                        lblBestScore.Text = (intBestLowScore).ToString();
                        intGuessCount = 0;
                        txtGuess.Text = "";
                    }
                }
            }
        }
        private void lblOutcome_Click(object sender, EventArgs e)
        {
        }
        private bool isNumberInt(string strInput)
        {
            try
            {
                int intValue = int.Parse(strInput);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




