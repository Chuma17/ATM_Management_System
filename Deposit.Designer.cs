
namespace ATM_Management_System
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.AmountDepositedtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Depositbtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmountDepositedtb
            // 
            this.AmountDepositedtb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.AmountDepositedtb.Location = new System.Drawing.Point(280, 77);
            this.AmountDepositedtb.Multiline = true;
            this.AmountDepositedtb.Name = "AmountDepositedtb";
            this.AmountDepositedtb.Size = new System.Drawing.Size(304, 59);
            this.AmountDepositedtb.TabIndex = 4;
            this.AmountDepositedtb.TextChanged += new System.EventHandler(this.AmountDepositedtb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(91, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "AMOUNT";
            // 
            // Depositbtn
            // 
            this.Depositbtn.BackColor = System.Drawing.Color.DimGray;
            this.Depositbtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Depositbtn.Location = new System.Drawing.Point(212, 173);
            this.Depositbtn.Name = "Depositbtn";
            this.Depositbtn.Size = new System.Drawing.Size(141, 38);
            this.Depositbtn.TabIndex = 5;
            this.Depositbtn.Text = "DEPOSIT";
            this.Depositbtn.UseVisualStyleBackColor = false;
            this.Depositbtn.Click += new System.EventHandler(this.Depositbtn_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logout.Location = new System.Drawing.Point(327, 246);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 25);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "LOGOUT";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "DEPOSIT";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Location = new System.Drawing.Point(559, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Back.Location = new System.Drawing.Point(114, 246);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 25);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back to Home";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(596, 280);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Depositbtn);
            this.Controls.Add(this.AmountDepositedtb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountDepositedtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Depositbtn;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Back;
    }
}