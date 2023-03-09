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
    public partial class adminfun : Form
    {
        public adminfun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "insert into bank values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            sqlCommand.ExecuteNonQuery();

            sqlconnection.Close();
            MessageBox.Show("add new bank succeessfully");
        }

        private void adminfun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.branches' table. You can move, or remove it, as needed.
           // this.bankTableAdapter.Fill(this.bankDataSet.bank);

            //this.branchesTableAdapter.Fill(this.bankDataSet.branches);
            // TODO: This line of code loads data into the 'bankDataSet.bank' table. You can move, or remove it, as needed.

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bankTableAdapter.Fill(this.bankDataSet.bank);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=otaku;Initial Catalog=bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "insert into branches values('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            MessageBox.Show("add new bank succeessfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.branchesTableAdapter.Fill(this.bankDataSet.branches);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatemp updatemp = new updatemp();
            updatemp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listempcust listempcust = new listempcust();
            listempcust.Show();
            this.Hide();
        }
    }
    }

