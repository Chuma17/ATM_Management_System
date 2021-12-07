using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Withdrawal : Form
    {
        SqlConnection sqlConnection;
        public Withdrawal()
        {
            InitializeComponent();
            //Connecting to the database
            string connectionString = ConfigurationManager.ConnectionStrings["ATM_Management_System.Properties.Settings.ATMdbConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void AddTransaction()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '" + AmountWithdrawntb.Text + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Withdrawbtn_Click(object sender, EventArgs e)
        {

            if (AmountWithdrawntb.Text == "")
            {
                MessageBox.Show("Enter a valid amount to withdraw");
            }
            else
            {
                try
                {
                    float ke;
                    if (!float.TryParse(AmountWithdrawntb.Text, out ke))
                    {
                        MessageBox.Show("Input digits only");
                    }
                    else
                    {
                        if (float.Parse(AmountWithdrawntb.Text) > oldBalance)
                        {
                            MessageBox.Show("Insufficient funds.\nTry again");
                        }
                        else
                        {
                            newBalance = oldBalance - float.Parse(AmountWithdrawntb.Text);
                            try
                            {
                                sqlConnection.Open();
                                //Query to add deposit to app balance.
                                string query = "UPDATE AccountTbl SET Balance = " + newBalance + " where AcctNum = '" + Login.AccNumber + "'";
                                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                                sqlCommand.ExecuteScalar();

                                MessageBox.Show("Withdrawal successfull!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                sqlConnection.Close();
                                AddTransaction();
                                
                                HOME home = new HOME();
                                home.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Input digits only");
                }
            }
        }    

        float oldBalance, newBalance;
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
                oldBalance = float.Parse(dataTable.Rows[0][0].ToString());
                sqlConnection.Close();
            }
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            GetBalance();

            try
            {
                sqlConnection.Open();
                //Query to get the balance of a user with already specified acc num
                string query = "select Balance from AccountTbl where AcctNum ='" + Login.AccNumber + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    AvailableBalancelbl.Text = "Bal: $" + dataTable.Rows[0][0].ToString();
                }
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
