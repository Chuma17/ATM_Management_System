using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class FastCash : Form
    {
        SqlConnection sqlConnection;
        public FastCash()
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

        private void AddTransaction_500()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '"+ 500 +"', '" + DateTime.Today.Date.ToString() + "')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddTransaction_1000()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '" + 1000 + "', '" + DateTime.Today.Date.ToString() + "')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddTransaction_5000()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '" + 5000 + "', '" + DateTime.Today.Date.ToString() + "')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddTransaction_10000()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '" + 10000 + "', '" + DateTime.Today.Date.ToString() + "')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddTransaction_15000()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '" + 15000 + "', '" + DateTime.Today.Date.ToString() + "')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void AddTransaction_20000()
        {
            string TransactionType = "Withdrawal";
            //condition to confirm if all fields are fields            
            try
            {
                //Query to add all the values to the database
                string query = "insert into TransactionTbl values ('" + Login.AccNumber + "', '" + TransactionType + "', '" + 20000 + "', '" + DateTime.Today.Date.ToString() + "')";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FiveHundredbtn_Click(object sender, EventArgs e)
        {
            if (500 > Bal)
            {
                MessageBox.Show("Insufficient Funds.\nTry again");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    //Query to add deposit to app balance.
                    string query = "UPDATE AccountTbl SET Balance = Balance - 500 where AcctNum = '" + Login.AccNumber + "'";
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
                    AddTransaction_500();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }                                        
        }        

        private void OneThousandbtn_Click(object sender, EventArgs e)
        {
            if (1000 > Bal)
            {
                MessageBox.Show("Insufficient Funds.\nTry again");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    //Query to add deposit to app balance.
                    string query = "UPDATE AccountTbl SET Balance = Balance - 1000 where AcctNum = '" + Login.AccNumber + "'";
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
                    AddTransaction_1000();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void FiveThousandbtn_Click(object sender, EventArgs e)
        {
            if (5000 > Bal)
            {
                MessageBox.Show("Insufficient Funds.\nTry again");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    //Query to add deposit to app balance.
                    string query = "UPDATE AccountTbl SET Balance = Balance - 5000 where AcctNum = '" + Login.AccNumber + "'";
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
                    AddTransaction_5000();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void TenThousandbtn_Click(object sender, EventArgs e)
        {
            if (10000 > Bal)
            {
                MessageBox.Show("Insufficient Funds.\nTry again");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    //Query to add deposit to app balance.
                    string query = "UPDATE AccountTbl SET Balance = Balance - 10000 where AcctNum = '" + Login.AccNumber + "'";
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
                    AddTransaction_10000();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void FifteenThousandbtn_Click(object sender, EventArgs e)
        {
            if (15000 > Bal)
            {
                MessageBox.Show("Insufficient Funds.\nTry again");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    //Query to add deposit to app balance.
                    string query = "UPDATE AccountTbl SET Balance = Balance - 15000 where AcctNum = '" + Login.AccNumber + "'";
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
                    AddTransaction_15000();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void TwentyThousandbtn_Click(object sender, EventArgs e)
        {
            if (20000 > Bal)
            {
                MessageBox.Show("Insufficient Funds.\nTry again");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    //Query to add deposit to app balance.
                    string query = "UPDATE AccountTbl SET Balance = Balance - 20000 where AcctNum = '" + Login.AccNumber + "'";
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
                    AddTransaction_20000();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        int Bal;
        private void FastCash_Load(object sender, EventArgs e)
        {
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
                    Bal = Convert.ToInt32(dataTable.Rows[0][0].ToString());

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

        private void Back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
