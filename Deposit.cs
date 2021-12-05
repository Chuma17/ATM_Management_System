using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ATM_Management_System
{
    public partial class Deposit : Form
    {
        SqlConnection sqlConnection;
        public Deposit()
        {
            InitializeComponent();
            //Connecting to the database
            string connectionString = ConfigurationManager.ConnectionStrings["ATM_Management_System.Properties.Settings.ATMdbConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        
        private void AddTransaction()
        {
            string TransactionType = "Deposit";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('"+ Login.AccNumber +"', '"+ TransactionType +"', '"+ AmountDepositedtb.Text +"', '"+ DateTime.Today.Date.ToString() +"')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AmountDepositedtb.Text == "" || Convert.ToInt32(AmountDepositedtb.Text) < 0)
                {
                    MessageBox.Show("Enter the amount to deposit");
                }
                else
                {
                    newBalance = oldBalance + Convert.ToInt32(AmountDepositedtb.Text);
                    try
                    {
                        sqlConnection.Open();
                        //Query to add deposit to app balance.
                        string query = "UPDATE AccountTbl SET Balance = " + newBalance + " where AcctNum = '" + Login.AccNumber + "'";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.ExecuteScalar();

                        MessageBox.Show("Amount Deposited successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        sqlConnection.Close();
                        AddTransaction();
                        AmountDepositedtb.Clear();
                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Inputs digits only");
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

        int oldBalance, newBalance;
        private void GetBalance()
        {
            sqlConnection.Open();
            //query to get the existing balance
            string query = "select Balance from AccountTbl where AcctNum = '" + Login.AccNumber + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);

            using (sda)
            {//make the existing balance an int variable so it can be added
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                oldBalance = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                sqlConnection.Close();
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void AmountDepositedtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
