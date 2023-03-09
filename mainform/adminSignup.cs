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
    public partial class adminSignup : Form
    {
        public adminSignup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "insert into admin_signup values('" + textBox3.Text + "','" + textBox4.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("sign up succeessfully");

            admin admin = new admin();
            admin.Show();
            this.Hide();
        }
    }
}
