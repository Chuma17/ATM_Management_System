using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class Login : Form
    {
        SqlConnection sqlConnection;
        public Login()
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
                        

        private void SignUp_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
        public static String AccNumber;
        public static String PinCode;
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string query = "select count(*) from AccountTbl where AcctNum = '"+AcctNumtb.Text+"' and Pin = "+Pintb.Text+"";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
                
                using (sda)
                {
                    DataTable datatable = new DataTable();
                    sda.Fill(datatable);

                    if (datatable.Rows[0][0].ToString() == "1")
                    {
                        AccNumber = AcctNumtb.Text;
                        PinCode = Pintb.Text;

                        MessageBox.Show("Login Successful!");

                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }                        

                    else
                    {
                        MessageBox.Show("Invalid Account number or Pin!");
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

        private void ForgotPinlbl_Click(object sender, EventArgs e)
        {
            ConfirmEMail confirmEMail = new ConfirmEMail();
            confirmEMail.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
