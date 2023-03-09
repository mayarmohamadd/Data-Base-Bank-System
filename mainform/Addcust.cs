
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
    public partial class Addcust : Form
    {
        public Addcust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "insert into customer  values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + ")";
            sqlCommand.ExecuteNonQuery();

           
            MessageBox.Show("add new customer succeessfully");
            empfun empfun = new empfun();
            empfun.Show();
            this.Hide();
            sqlconnection.Close();

        }
    }
}
