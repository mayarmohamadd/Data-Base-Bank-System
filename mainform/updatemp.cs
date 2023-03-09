
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
    public partial class updatemp : Form
    {
        public updatemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = (" update employee set ename = '" + textBox2.Text + "', salary = " + textBox3.Text + ", bnum = " + textBox4.Text + " where id = " + textBox1.Text + ";");
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Update was successfully completed");
            adminfun adminfun = new adminfun();
            adminfun.Show();
            this.Hide();
            sqlconnection.Close();


        }
    }
}
