using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_page
{
    public partial class Form_proorismos : Form
    {
        public Form_proorismos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back to visitors form 
            Form_visitors frmVisit = new Form_visitors();
            frmVisit.Show();
        }
    }
}
