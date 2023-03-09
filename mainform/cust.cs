
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
    public partial class cust : Form
    {
        public cust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            custsignup custsignup = new custsignup();
            custsignup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }
    }
}
