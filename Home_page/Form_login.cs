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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textbox password
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back form_login to form1
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
