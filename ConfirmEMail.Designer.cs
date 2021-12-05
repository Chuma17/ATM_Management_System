
namespace ATM_Management_System
{
    partial class ConfirmEMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Emailtb = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.ConfirmEmailbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "CONFIRM EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter E-Mail Address";
            // 
            // Emailtb
            // 
            this.Emailtb.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.Emailtb.Location = new System.Drawing.Point(334, 102);
            this.Emailtb.Multiline = true;
            this.Emailtb.Name = "Emailtb";
            this.Emailtb.Size = new System.Drawing.Size(224, 59);
            this.Emailtb.TabIndex = 26;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(226, 266);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(144, 25);
            this.Logout.TabIndex = 25;
            this.Logout.Text = "Back to Login";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(595, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 24;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ConfirmEmailbtn
            // 
            this.ConfirmEmailbtn.BackColor = System.Drawing.Color.DimGray;
            this.ConfirmEmailbtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmEmailbtn.Location = new System.Drawing.Point(229, 206);
            this.ConfirmEmailbtn.Name = "ConfirmEmailbtn";
            this.ConfirmEmailbtn.Size = new System.Drawing.Size(141, 38);
            this.ConfirmEmailbtn.TabIndex = 23;
            this.ConfirmEmailbtn.Text = "CONFIRM";
            this.ConfirmEmailbtn.UseVisualStyleBackColor = false;
            this.ConfirmEmailbtn.Click += new System.EventHandler(this.ConfirmEmailbtn_Click);
            // 
            // ConfirmEMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(632, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emailtb);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConfirmEmailbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmEMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmEMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Emailtb;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button ConfirmEmailbtn;
    }
}