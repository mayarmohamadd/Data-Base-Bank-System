namespace mainform
{
    partial class loanlist
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bankDataSet = new mainform.bankDataSet();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter = new mainform.bankDataSetTableAdapters.loanTableAdapter();
            this.loannumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loantypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loannumberDataGridViewTextBoxColumn,
            this.loanamountDataGridViewTextBoxColumn,
            this.loantypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(719, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.bankDataSet;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // loannumberDataGridViewTextBoxColumn
            // 
            this.loannumberDataGridViewTextBoxColumn.DataPropertyName = "loan_number";
            this.loannumberDataGridViewTextBoxColumn.HeaderText = "loan_number";
            this.loannumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.loannumberDataGridViewTextBoxColumn.Name = "loannumberDataGridViewTextBoxColumn";
            this.loannumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.loannumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // loanamountDataGridViewTextBoxColumn
            // 
            this.loanamountDataGridViewTextBoxColumn.DataPropertyName = "loan_amount";
            this.loanamountDataGridViewTextBoxColumn.HeaderText = "loan_amount";
            this.loanamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.loanamountDataGridViewTextBoxColumn.Name = "loanamountDataGridViewTextBoxColumn";
            this.loanamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanamountDataGridViewTextBoxColumn.Width = 150;
            // 
            // loantypeDataGridViewTextBoxColumn
            // 
            this.loantypeDataGridViewTextBoxColumn.DataPropertyName = "loan_type";
            this.loantypeDataGridViewTextBoxColumn.HeaderText = "loan_type";
            this.loantypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.loantypeDataGridViewTextBoxColumn.Name = "loantypeDataGridViewTextBoxColumn";
            this.loantypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.loantypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loanlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "loanlist";
            this.Text = "loanlist";
            this.Load += new System.EventHandler(this.loanlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private bankDataSetTableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loannumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loantypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}