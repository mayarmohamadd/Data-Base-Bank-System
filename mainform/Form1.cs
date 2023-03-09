using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emp emp = new emp();
            emp.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cust cust = new cust();
            cust.Show();
            this.Hide();

        }
    }
}
