
namespace ATM_Management_System
{
    partial class Withdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrawal));
            this.Exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountWithdrawntb = new System.Windows.Forms.TextBox();
            this.Logoutlbl = new System.Windows.Forms.Label();
            this.Withdrawbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.AvailableBalancelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Location = new System.Drawing.Point(557, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 28);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(69, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "AMOUNT";
            // 
            // AmountWithdrawntb
            // 
            this.AmountWithdrawntb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.AmountWithdrawntb.Location = new System.Drawing.Point(222, 103);
            this.AmountWithdrawntb.Multiline = true;
            this.AmountWithdrawntb.Name = "AmountWithdrawntb";
            this.AmountWithdrawntb.Size = new System.Drawing.Size(362, 60);
            this.AmountWithdrawntb.TabIndex = 17;
            // 
            // Logoutlbl
            // 
            this.Logoutlbl.AutoSize = true;
            this.Logoutlbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logoutlbl.Location = new System.Drawing.Point(347, 246);
            this.Logoutlbl.Name = "Logoutlbl";
            this.Logoutlbl.Size = new System.Drawing.Size(95, 25);
            this.Logoutlbl.TabIndex = 18;
            this.Logoutlbl.Text = "LOGOUT";
            this.Logoutlbl.Click += new System.EventHandler(this.Logoutlbl_Click);
            // 
            // Withdrawbtn
            // 
            this.Withdrawbtn.BackColor = System.Drawing.Color.DimGray;
            this.Withdrawbtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdrawbtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Withdrawbtn.Location = new System.Drawing.Point(222, 185);
            this.Withdrawbtn.Name = "Withdrawbtn";
            this.Withdrawbtn.Size = new System.Drawing.Size(141, 38);
            this.Withdrawbtn.TabIndex = 19;
            this.Withdrawbtn.Text = "WITHDRAW";
            this.Withdrawbtn.UseVisualStyleBackColor = false;
            this.Withdrawbtn.Click += new System.EventHandler(this.Withdrawbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "WITHDRAWAL";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Back.Location = new System.Drawing.Point(110, 246);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 25);
            this.Back.TabIndex = 21;
            this.Back.Text = "Back to Home";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AvailableBalancelbl
            // 
            this.AvailableBalancelbl.AutoSize = true;
            this.AvailableBalancelbl.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBalancelbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AvailableBalancelbl.Location = new System.Drawing.Point(270, 58);
            this.AvailableBalancelbl.Name = "AvailableBalancelbl";
            this.AvailableBalancelbl.Size = new System.Drawing.Size(245, 28);
            this.AvailableBalancelbl.TabIndex = 22;
            this.AvailableBalancelbl.Text = "AVAILABLE BALANCE";
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(596, 280);
            this.Controls.Add(this.AvailableBalancelbl);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Withdrawbtn);
            this.Controls.Add(this.Logoutlbl);
            this.Controls.Add(this.AmountWithdrawntb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exit);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Withdrawal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.Withdrawal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountWithdrawntb;
        private System.Windows.Forms.Label Logoutlbl;
        private System.Windows.Forms.Button Withdrawbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label AvailableBalancelbl;
    }
}