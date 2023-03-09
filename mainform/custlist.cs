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
    public partial class custlist : Form
    {
        public custlist()
        {
            InitializeComponent();
        }

        private void custlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankDataSet.customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            empfun empfun = new empfun();
            empfun.Show();
            this.Hide();
        }
    }
}
