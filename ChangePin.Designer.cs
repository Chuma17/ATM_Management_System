
namespace ATM_Management_System
{
    partial class ChangePin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePin));
            this.ConfirmPin = new System.Windows.Forms.TextBox();
            this.UpdatePinbtn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.NewPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmPin
            // 
            this.ConfirmPin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.ConfirmPin.Location = new System.Drawing.Point(388, 175);
            this.ConfirmPin.Name = "ConfirmPin";
            this.ConfirmPin.Size = new System.Drawing.Size(224, 30);
            this.ConfirmPin.TabIndex = 3;
            // 
            // UpdatePinbtn
            // 
            this.UpdatePinbtn.BackColor = System.Drawing.Color.DimGray;
            this.UpdatePinbtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePinbtn.Location = new System.Drawing.Point(275, 232);
            this.UpdatePinbtn.Name = "UpdatePinbtn";
            this.UpdatePinbtn.Size = new System.Drawing.Size(141, 38);
            this.UpdatePinbtn.TabIndex = 4;
            this.UpdatePinbtn.Text = "UPDATE";
            this.UpdatePinbtn.UseVisualStyleBackColor = false;
            this.UpdatePinbtn.Click += new System.EventHandler(this.UpdatePinbtn_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(667, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(355, 334);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(144, 25);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "Back to Login";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // NewPin
            // 
            this.NewPin.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.NewPin.Location = new System.Drawing.Point(388, 101);
            this.NewPin.Name = "NewPin";
            this.NewPin.Size = new System.Drawing.Size(224, 30);
            this.NewPin.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "NEW PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "CONFIRM PIN";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(177, 334);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 25);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back to Home";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "CHANGE PIN";
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(704, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPin);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UpdatePinbtn);
            this.Controls.Add(this.ConfirmPin);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ConfirmPin;
        private System.Windows.Forms.Button UpdatePinbtn;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.TextBox NewPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label label2;
    }
}