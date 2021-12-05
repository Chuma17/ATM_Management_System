using System;
using System.Windows.Forms;

namespace ATM_Management_System
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logoutlb_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void ChangePinbtn_Click(object sender, EventArgs e)
        {
            ChangePin change = new ChangePin();
            change.Show();
            this.Hide();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number: " + Login.AccNumber;
        }

        private void Depositbtn_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void Withdrawalbtn_Click(object sender, EventArgs e)
        {
            Withdrawal withdrawal = new Withdrawal();
            withdrawal.Show();
            this.Hide();
        }

        private void Statementbtn_Click(object sender, EventArgs e)
        {
            Statement statement = new Statement();
            statement.Show();
            this.Hide();
        }

        private void Balancebtn_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void FastCashbtn_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            fastCash.Show();
            this.Hide();                
        }
       
    }
}
