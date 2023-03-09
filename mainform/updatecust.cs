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
    public partial class updatecust : Form
    {
        public updatecust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = (" update customer set address = '" + textBox2.Text + "', name = '" + textBox3.Text + "',phone = " + textBox4.Text + ", bnum = " + textBox5.Text + " where ssn = " + textBox1.Text + ";");
            sqlCommand.ExecuteNonQuery();
         
            MessageBox.Show("Update was successfully completed");
            empfun empfun = new empfun();
            empfun.Show();
            this.Hide();
            sqlconnection.Close();

        }


    }
}

