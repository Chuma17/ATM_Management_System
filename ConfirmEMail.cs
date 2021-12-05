using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class ConfirmEMail : Form
    {
        SqlConnection sqlConnection;
        public ConfirmEMail()
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

        private void Logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        public static String eMail;
        private void ConfirmEmailbtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string query = "select count(*) from AccountTbl where EMail = '" + Emailtb.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);

                using (sda)
                {
                    DataTable datatable = new DataTable();
                    sda.Fill(datatable);

                    if (datatable.Rows[0][0].ToString() == "1")
                    {
                        eMail = Emailtb.Text;
                        MessageBox.Show("EMail Available!");

                        RenewPin renewPin = new RenewPin();
                        renewPin.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid EMail!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Account number or Pin!");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
