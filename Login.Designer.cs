
namespace ATM_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.SignUp = new System.Windows.Forms.Label();
            this.AcctNumtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pintb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.ForgotPinlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SignUp.Location = new System.Drawing.Point(399, 387);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(85, 25);
            this.SignUp.TabIndex = 10;
            this.SignUp.Text = "Sign up";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // AcctNumtb
            // 
            this.AcctNumtb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.AcctNumtb.Location = new System.Drawing.Point(424, 128);
            this.AcctNumtb.Name = "AcctNumtb";
            this.AcctNumtb.Size = new System.Drawing.Size(274, 30);
            this.AcctNumtb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(304, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "LOGIN PAGE";
            // 
            // Pintb
            // 
            this.Pintb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pintb.Location = new System.Drawing.Point(424, 212);
            this.Pintb.Name = "Pintb";
            this.Pintb.PasswordChar = '*';
            this.Pintb.Size = new System.Drawing.Size(274, 30);
            this.Pintb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(134, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(134, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "ACCOUNT NUMBER";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Location = new System.Drawing.Point(735, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 28);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.DimGray;
            this.Loginbtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Loginbtn.Location = new System.Drawing.Point(295, 310);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(141, 38);
            this.Loginbtn.TabIndex = 17;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // ForgotPinlbl
            // 
            this.ForgotPinlbl.AutoSize = true;
            this.ForgotPinlbl.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPinlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ForgotPinlbl.Location = new System.Drawing.Point(223, 387);
            this.ForgotPinlbl.Name = "ForgotPinlbl";
            this.ForgotPinlbl.Size = new System.Drawing.Size(114, 25);
            this.ForgotPinlbl.TabIndex = 18;
            this.ForgotPinlbl.Text = "Forgot Pin";
            this.ForgotPinlbl.Click += new System.EventHandler(this.ForgotPinlbl_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.ForgotPinlbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pintb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.AcctNumtb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.TextBox AcctNumtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pintb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label ForgotPinlbl;
    }
}