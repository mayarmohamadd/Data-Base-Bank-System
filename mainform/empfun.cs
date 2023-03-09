
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
    public partial class empfun : Form
    {
        public empfun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addcust Addcust = new Addcust();
            Addcust.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            custlist custlist = new custlist();
            custlist.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loanlist loanlist = new loanlist();
            loanlist.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loanopp loanopp = new loanopp();
            loanopp.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            updatecust updatecust = new updatecust();
            updatecust.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select bnum from branches where bnum not in (select bnum from customer)", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select *from branches where bnum not in (select bnum from employee);", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select TOP 1 PERCENT e.ename, count(*) as counts from employee as e join add_loan on add_loan.id=e.id group by ename order by counts desc ", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select TOP 1 PERCENT c.name, count(*) as counts from customer as c join borrower on borrower.ssn=c.ssn group by name order by counts desc", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT c.ssn,c.name FROM customer c LEFT JOIN borrower t ON t.ssn = c.ssn LEFT JOIN loan l ON l.loan_number = t.loan_number WHERE l.loan_number   IS NULL", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT cu.ssn,cu.address,cu.name,cu.phone,cu.bnum,cb.id from customer as cu INNER JOIN cust_banker as cb ON cu.ssn=cb.ssn", sqlconnection);
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconnection.Close();
        }

        private void empfun_Load(object sender, EventArgs e)
        {

        }
    }
}
