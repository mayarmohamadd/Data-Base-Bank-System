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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminSignup adminSignup = new adminSignup();    
            adminSignup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminsignin adminsignin = new adminsignin();
            adminsignin.Show();
            this.Hide();
        }
    }
}
