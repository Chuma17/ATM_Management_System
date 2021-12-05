using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Statement : Form
    {
        SqlConnection sqlConnection;
        public Statement()
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

        private void Populate()
        {
            sqlConnection.Open();
            //query to select the details from a particular account number
            string query = "select * from TransactionTbl where AcctNum = '" + Login.AccNumber + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            sqlConnection.Close();
            
            
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
