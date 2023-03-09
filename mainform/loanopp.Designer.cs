namespace mainform
{
    partial class loanopp
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bankDataSet = new mainform.bankDataSet();
            this.addloanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_loanTableAdapter = new mainform.bankDataSetTableAdapters.add_loanTableAdapter();
            this.holdbyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hold_byTableAdapter = new mainform.bankDataSetTableAdapters.hold_byTableAdapter();
            this.holdbyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addloanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdbyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdbyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 27);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "accuant number";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addloanBindingSource
            // 
            this.addloanBindingSource.DataMember = "add_loan";
            this.addloanBindingSource.DataSource = this.bankDataSet;
            // 
            // add_loanTableAdapter
            // 
            this.add_loanTableAdapter.ClearBeforeFill = true;
            // 
            // holdbyBindingSource
            // 
            this.holdbyBindingSource.DataMember = "hold_by";
            this.holdbyBindingSource.DataSource = this.bankDataSet;
            // 
            // hold_byTableAdapter
            // 
            this.hold_byTableAdapter.ClearBeforeFill = true;
            // 
            // holdbyBindingSource1
            // 
            this.holdbyBindingSource1.DataMember = "hold_by";
            this.holdbyBindingSource1.DataSource = this.bankDataSet;
            // 
            // loanopp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "loanopp";
            this.Text = "loanopp";
            this.Load += new System.EventHandler(this.loanopp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addloanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdbyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holdbyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource addloanBindingSource;
        private bankDataSetTableAdapters.add_loanTableAdapter add_loanTableAdapter;
        private System.Windows.Forms.BindingSource holdbyBindingSource;
        private bankDataSetTableAdapters.hold_byTableAdapter hold_byTableAdapter;
        private System.Windows.Forms.BindingSource holdbyBindingSource1;
    }
}