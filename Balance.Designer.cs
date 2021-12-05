
namespace ATM_Management_System
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Balancelbl = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.AccNumlbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(274, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCOUNT BALANCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(129, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Balance";
            // 
            // Balancelbl
            // 
            this.Balancelbl.AutoSize = true;
            this.Balancelbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balancelbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Balancelbl.Location = new System.Drawing.Point(400, 193);
            this.Balancelbl.Name = "Balancelbl";
            this.Balancelbl.Size = new System.Drawing.Size(214, 32);
            this.Balancelbl.TabIndex = 2;
            this.Balancelbl.Text = "Balance in Naira";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Location = new System.Drawing.Point(711, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 28);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AccNumlbl
            // 
            this.AccNumlbl.AutoSize = true;
            this.AccNumlbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AccNumlbl.Location = new System.Drawing.Point(409, 114);
            this.AccNumlbl.Name = "AccNumlbl";
            this.AccNumlbl.Size = new System.Drawing.Size(117, 32);
            this.AccNumlbl.TabIndex = 4;
            this.AccNumlbl.Text = "AccNum";
            this.AccNumlbl.Click += new System.EventHandler(this.AccNumlbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(129, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Account Number";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Back.Location = new System.Drawing.Point(205, 290);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 25);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back to Home";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logout.Location = new System.Drawing.Point(380, 290);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 25);
            this.Logout.TabIndex = 13;
            this.Logout.Text = "LOGOUT";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(750, 324);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AccNumlbl);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Balancelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Balancelbl;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label AccNumlbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label Logout;
    }
}