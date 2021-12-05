using System;
using System.Windows.Forms;


namespace ATM_Management_System
{
    
    public partial class Opening : Form
    {
        public static Opening opening = new Opening();
        public Opening()
        {
            InitializeComponent();
        }
        

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 2;
            progressBar1.Value = starting;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Opening_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
