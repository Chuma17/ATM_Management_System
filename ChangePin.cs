using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class ChangePin : Form
    {
        SqlConnection sqlConnection;
        public ChangePin()
        {
            InitializeComponent();
            //Connecting to the database
            string connectionString = ConfigurationManager.ConnectionStrings["ATM_Management_System.Properties.Settings.ATMdbConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
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
                        string query = "UPDATE AccountTbl SET Pin = " + newPin + " where AcctNum = '" + Login.AccNumber + "'";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.ExecuteScalar();

                        MessageBox.Show("Pin changed successfully");

                        HOME home = new HOME();
                        home.Show();
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

        private void Back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
                
        private void ChangePin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
