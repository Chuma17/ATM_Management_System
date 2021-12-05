using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace ATM_Management_System
{
    public partial class Registration : Form
    {
        //Creating the connection variable
        SqlConnection sqlConnection;
        public Registration()
        {
            InitializeComponent();
            //Connecting to the database
            string connectionString = ConfigurationManager.ConnectionStrings["ATM_Management_System.Properties.Settings.ATMdbConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }        

        private void Register_Click(object sender, EventArgs e)
        {
            //condition to confirm if all fields are fields
            if (AcctNumtb.Text == "" || FirstNametb.Text == "" || LastNametb.Text == "" || Agetb.Text == "" ||
                EMailtb.Text == "" || Pintb.Text == "" || Balancetb.Text == "" || Phonetb.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            
            else
            {
                try
                {
                    //Query to add all the values to the database
                    string query = "insert into AccountTbl values (@AcctNum, @FirstName," +
                        "@LastName, @EMail, @Pin, @Balance, @Phone, @Age)";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@AcctNum", AcctNumtb.Text);
                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstNametb.Text);
                    sqlCommand.Parameters.AddWithValue("@LastName", LastNametb.Text);
                    sqlCommand.Parameters.AddWithValue("@EMail", EMailtb.Text);
                    sqlCommand.Parameters.AddWithValue("@Pin", Pintb.Text);
                    sqlCommand.Parameters.AddWithValue("@Balance", Balancetb.Text);
                    sqlCommand.Parameters.AddWithValue("@Phone", Phonetb.Text);
                    sqlCommand.Parameters.AddWithValue("@Age", Agetb.Text);
                    sqlCommand.ExecuteScalar();

                    MessageBox.Show("Account Created Successfully");

                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Input the correct values");
                }
                finally
                {
                    sqlConnection.Close();                                                           
                }
            }
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
