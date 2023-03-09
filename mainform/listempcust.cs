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
    public partial class listempcust : Form
    {
        public listempcust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminfun adminfun = new adminfun();
            adminfun.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT l.loan_number,l.loan_type,l.loan_amount,c.name,e.ename from loan l INNER JOIN borrower as b ON b.loan_number=l.loan_number INNER JOIN add_loan as a ON a.loan_number=l.loan_number INNER JOIN customer as c ON c.ssn=b.ssn INNER JOIN employee as e ON e.id=a.id", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }
    }
}
