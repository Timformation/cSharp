using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExecuteNonQuery
{
    public partial class frmCommand : Form
    {
        public frmCommand()
        {
            InitializeComponent();
        }

        //Connection String
        String cnStr = "Data Source=134.39.173.35;Initial Catalog=tsirchuk_w17;User ID=tsirchuk_w17;password=Checkmate!";
        String strSQL;

        SqlConnection cn = new SqlConnection();


        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Assign Connection string to connection object
            cn.ConnectionString = cnStr;


            //Open the Connection to SQL Server

            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                
                if (ex.Message.IndexOf("error: 40") > -1)
                    MessageBox.Show("Either your connection string contains a bad IP address or you are not connected to the internet right now.");
                

                else
                if (ex.Message.IndexOf("Cannot open database") > -1)
                    MessageBox.Show("Your connection string requested a bad database name.");
                else
                    if (ex.Message.IndexOf("Login failed") > -1)
                    MessageBox.Show("Your connecting string contains an invalid user name or password.");

                else
                    MessageBox.Show("An error occured.");
                

            }

            //This concatenates the insert statement.  Of course you would add loads of error checking.
            strSQL = "insert into tblZipcodes (zip, city, state) values ('" + txtZip.Text + "','" + txtCity.Text + "','" + txtState.Text + "')";

            //this statement creates the command object and passes in the SQL statement
            //then associates the command to the cn connection object
            SqlCommand cmd = new SqlCommand(strSQL, cn);

            //Execute command.  Returns no rows.

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (txtZip.Text == "" || txtCity.Text == "" || txtState.Text == "")
                    MessageBox.Show("You cannot leave a field empty.");
                else

                if (ex.Message.IndexOf("number of supplied values") > -1)
                    MessageBox.Show("City, State and Zip code are required fields.");

                else

                if (ex.Message.IndexOf("PRIMARY KEY") > -1)
                    MessageBox.Show("You cannot add a zip code that already exists in the database.");

            }
            
            //Close Connection
            cn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnInsert.Enabled = false;
            lblFind.Visible = true;
            txtZip2Find.Visible = true;
            txtZip2Find.Focus();

        }

        private void txtZip2Find_Leave(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();

            //Assign connection string to the connection object
            cn.ConnectionString = cnStr;
            //Open the connection to SQL Server
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                if (ex.Message.IndexOf("error: 40") > -1)
                    MessageBox.Show("Either your connection string contains a bad IP address, or you are not connected to the internet.");

                else

                if (ex.Message.IndexOf("Cannot open database") > -1)
                    MessageBox.Show("Your connection string requested a bad database name.");
                else

                    if (ex.Message.IndexOf("Login failed") > -1)
                    MessageBox.Show("Your connecting string contains an invalid user name or password. Check your login information and try again.");

                else
                    MessageBox.Show("An error occured.");
            

            }
           

            //This statement creates a command object and passes in a SQL Statement
            //The associates the command to the cn Connection Object
            SqlCommand cmd = new SqlCommand("Select city,state,zip from tblZipcodes where zip='" + txtZip2Find.Text + "'",cn);
            SqlDataReader rdrZip;
            //Open a DataReader

            try
            {
                rdrZip = cmd.ExecuteReader();
                if (!rdrZip.HasRows)
                {
                    throw new Exception();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                if (txtZip2Find.Text == "")
                    MessageBox.Show("You must enter a zip code to search for.");
                
                else

                MessageBox.Show("Your search did not return any results: check the zip code you entered and try again.");
                return;

            }


            //Attempt to read record into datareader
            rdrZip.Read();
            //If found, data reader has rows else not found
            if (rdrZip.HasRows)
            { //Move text from rdr into textboxes
                txtCity.Text = rdrZip["city"].ToString();
                txtState.Text = rdrZip["state"].ToString();
                txtZip.Text = rdrZip["zip"].ToString();
            }
            else
            {
                MessageBox.Show("Zip Not Found");
            }
            cn.Close();

            //Restore buttons
            btnSearch.Enabled = true;
            btnInsert.Enabled = true;
            lblFind.Visible = false;
            txtZip2Find.Visible = false;
          
        }

       
    }
}