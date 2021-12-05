using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class RenewPin : Form
    {
        SqlConnection sqlConnection;
        public RenewPin()
        {
            InitializeComponent();
            //Connecting to the database
            string connectionString = ConfigurationManager.ConnectionStrings["ATM_Management_System.Properties.Settings.ATMdbConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        private void RenewPin_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        int newPin;
        
        private void UpdatePinbtn_Click(object sender, EventArgs e)
        {
            if (!(NewPin.Text == ConfirmPin.Text))
            {
                MessageBox.Show("Both entries are different.\nTry again");
            }
            else
            {
                try
                {
                    if (NewPin.Text == "" || Convert.ToInt32(NewPin.Text) < 0 || ConfirmPin.Text == "" || Convert.ToInt32(ConfirmPin.Text) < 0)
                    {
                        MessageBox.Show("Enter a valid pin");
                    }
                    else
                    {
                        newPin = Convert.ToInt32(NewPin.Text);
                        try
                        {
                            sqlConnection.Open();
                            //Query to add deposit to app balance.
                            string query = "UPDATE AccountTbl SET Pin = " + newPin + " where EMail = '" + ConfirmEMail.eMail + "'";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.ExecuteScalar();

                            MessageBox.Show("Pin changed successfully");

                            Login log = new Login();
                            log.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Input digits only");
                }
                
            }
        }
    }
}
