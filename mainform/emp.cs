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
    public partial class emp : Form
    {
        public emp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empsignup empsignup = new empsignup();
            empsignup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empsignin empsignin = new empsignin();
            empsignin.Show();
            this.Hide();
        }
    }
}
