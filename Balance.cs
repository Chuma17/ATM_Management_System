using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Balance : Form
    {
        SqlConnection sqlConnection;
        public Balance()
        {
            InitializeComponent();
            //Connecting to the database
            string connectionString = ConfigurationManager.ConnectionStrings["ATM_Management_System.Properties.Settings.ATMdbConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        //Closes the app
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccNumlbl_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = Login.AccNumber;

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
                    Balancelbl.Text = "$" + dataTable.Rows[0][0].ToString();
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

        private void Logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
