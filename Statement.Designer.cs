
namespace ATM_Management_System
{
    partial class Statement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statement));
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.aTMdbDataSet = new ATM_Management_System.ATMdbDataSet();
            this.transactionTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTblTableAdapter = new ATM_Management_System.ATMdbDataSetTableAdapters.TransactionTblTableAdapter();
            this.transactionTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "STATEMENT";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Logout.Location = new System.Drawing.Point(462, 416);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 25);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "LOGOUT";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.acctNumDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.tDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionTblBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 367);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Location = new System.Drawing.Point(727, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Back.Location = new System.Drawing.Point(202, 416);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 25);
            this.Back.TabIndex = 15;
            this.Back.Text = "Back to Home";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // aTMdbDataSet
            // 
            this.aTMdbDataSet.DataSetName = "ATMdbDataSet";
            this.aTMdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTblBindingSource
            // 
            this.transactionTblBindingSource.DataMember = "TransactionTbl";
            this.transactionTblBindingSource.DataSource = this.aTMdbDataSet;
            // 
            // transactionTblTableAdapter
            // 
            this.transactionTblTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTblBindingSource1
            // 
            this.transactionTblBindingSource1.DataMember = "TransactionTbl";
            this.transactionTblBindingSource1.DataSource = this.aTMdbDataSet;
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "Tid";
            this.tidDataGridViewTextBoxColumn.HeaderText = "Tid";
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            // 
            // acctNumDataGridViewTextBoxColumn
            // 
            this.acctNumDataGridViewTextBoxColumn.DataPropertyName = "AcctNum";
            this.acctNumDataGridViewTextBoxColumn.HeaderText = "AcctNum";
            this.acctNumDataGridViewTextBoxColumn.Name = "acctNumDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // tDateDataGridViewTextBoxColumn
            // 
            this.tDateDataGridViewTextBoxColumn.DataPropertyName = "TDate";
            this.tDateDataGridViewTextBoxColumn.HeaderText = "TDate";
            this.tDateDataGridViewTextBoxColumn.Name = "tDateDataGridViewTextBoxColumn";
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statement";
            this.Load += new System.EventHandler(this.Statement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTMdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Back;
        private ATMdbDataSet aTMdbDataSet;
        private System.Windows.Forms.BindingSource transactionTblBindingSource;
        private ATMdbDataSetTableAdapters.TransactionTblTableAdapter transactionTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acctNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionTblBindingSource1;
    }
}