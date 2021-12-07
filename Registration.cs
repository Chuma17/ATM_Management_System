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
                if (FirstNametb.Text.Length > 50)
                {
                    MessageBox.Show("First Name should be at most 50 characters");
                }
                else
                {
                    if (LastNametb.Text.Length > 50)
                    {
                        MessageBox.Show("Last Name should be at most 50 characters");
                    }
                    else
                    {
                        if (EMailtb.Text.Length > 50)
                        {
                            MessageBox.Show("EMail should be at most 50 characters");
                        }                                                    
                        else
                        {
                            if (AcctNumtb.Text.Length != 10)
                            {
                                MessageBox.Show("Account Number should have 10 characters only");
                            }
                            else
                            {
                                if (Pintb.Text.Length != 4)
                                {
                                    MessageBox.Show("Pin should have 4 digits only");
                                }
                                else
                                {
                                    if (Agetb.Text.Length > 3)
                                    {
                                        MessageBox.Show("Age should not be more than 3 digits");
                                    }
                                    else
                                    {
                                        if (Phonetb.Text.Length != 10)
                                        {
                                            MessageBox.Show("Phone Number should be 10 digits. Exclude the firse zero");
                                        }
                                        else
                                        {
                                            try
                                            {
                                                float ke;
                                                if (!float.TryParse(Balancetb.Text, out ke))
                                                {
                                                    MessageBox.Show("Input digits only in the balance field");
                                                }
                                                else
                                                {
                                                    if (float.Parse(Balancetb.Text) > float.MaxValue || float.Parse(Balancetb.Text) < 0)
                                                    {
                                                        MessageBox.Show("Input a Balance Amount at most " + float.MaxValue + " and at least 0");
                                                    }
                                                    else
                                                    {
                                                        try
                                                        {
                                                            
                                                            if (Int64.Parse(AcctNumtb.Text) > Int64.MaxValue)
                                                            {
                                                                MessageBox.Show("Input digits only in the AcctNum field");
                                                            }
                                                            else
                                                            {
                                                                
                                                                try
                                                                {
                                                                    if (int.Parse(Pintb.Text) > int.MaxValue)
                                                                    {
                                                                        MessageBox.Show("Input digits only in the Pin field");
                                                                    }
                                                                    else
                                                                    {
                                                                        
                                                                        try
                                                                        {
                                                                            if (int.Parse(Agetb.Text) > int.MaxValue)
                                                                            {
                                                                                MessageBox.Show("Input digits only in the Age field");
                                                                            }
                                                                            else
                                                                            {
                                                                                
                                                                                try
                                                                                {
                                                                                    if (Int64.Parse(Phonetb.Text) > Int64.MaxValue)
                                                                                    {
                                                                                        MessageBox.Show("Phone Number should be 10 digits. Exclude the first zero");
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
                                                                                catch (Exception)
                                                                                {
                                                                                    MessageBox.Show("Input digits only in the Phone Number field");
                                                                                }
                                                                            }
                                                                        }
                                                                        catch (Exception)
                                                                        {
                                                                            MessageBox.Show("Input digits only in the Age field");
                                                                        }
                                                                    }
                                                                }
                                                                catch (Exception)
                                                                {
                                                                    MessageBox.Show("Input digits only in the PIN field");
                                                                }

                                                            }
                                                        }
                                                        catch (Exception)
                                                        {
                                                            MessageBox.Show("Input digits only in the ACCTNUM field");
                                                        }

                                                    }
                                                }
                                                
                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Input digits only in the BALANCE field");
                                            }
                                        }
                                    }
                                }                                
                            }                                                                      
                        }                                                                                    
                    }
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
