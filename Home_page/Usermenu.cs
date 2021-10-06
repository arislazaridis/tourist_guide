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
    public partial class Usermenu : Form
    {
        public Usermenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           pictureBox8.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            Events evs  = new Events();
            evs.Show();
            this.Hide(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_beaches frm = new Form_beaches();
            frm.Show(); 
        }

        private void Usermenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            Form_proorismos frm = new Form_proorismos();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            Form_map frm = new Form_map();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            Form_aksiotheata frm = new Form_aksiotheata();
            frm.Show();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            Form_calendar frm = new Form_calendar();
            frm.Show();
            
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            pictureBox7.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            farmakeia frmkeio = new farmakeia();
            frmkeio.Show(); 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            pictureBox6.ImageLocation = "C:/Users/efmak/Downloads/Home_page/photos/orange.PNG";
            ktel ktl = new ktel();
            ktl.Show(); 
        }
    }
}
