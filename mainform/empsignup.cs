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
    public partial class empsignup : Form
    {
        public empsignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "insert into emp_signup values('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("sign up succeessfully");

            emp emp = new emp();
            emp.Show();
            this.Hide();

        }
    }
}
