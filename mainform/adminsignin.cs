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
    public partial class adminsignin : Form
    {
        
        public adminsignin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            string name = textBox1.Text;
            string pass= textBox2.Text;
            SqlCommand cmd = new SqlCommand("select name,pass from admin_signup where name='" + textBox1.Text + "'and pass='" + textBox2.Text + "'", sqlconnection);           
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess");
                adminfun adminfun = new adminfun();
                adminfun.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

        sqlconnection.Close();






        }
    }
}
