
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mainform
{
    public partial class loanopp : Form
    {
        public loanopp()
        {
            InitializeComponent();
        }

        private void loanopp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.hold_by' table. You can move, or remove it, as needed.
            this.hold_byTableAdapter.Fill(this.bankDataSet.hold_by);
            // TODO: This line of code loads data into the 'bankDataSet.add_loan' table. You can move, or remove it, as needed.
            this.add_loanTableAdapter.Fill(this.bankDataSet.add_loan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "insert into hold_by  values(" + textBox1.Text + "," + textBox2.Text + ",'" + textBox3.Text + "')";

     
            MessageBox.Show("save succeessfully");
            empfun empfun = new empfun();
            empfun.Show();
            this.Hide();
            sqlconnection.Close();



        }
    }
}
