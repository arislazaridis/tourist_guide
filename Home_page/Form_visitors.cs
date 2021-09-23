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
    public partial class Form_visitors : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form_visitors()
        {
            InitializeComponent();

            player.SoundLocation = "piano.wav";
            
        }
        private int imageno = 0;  //slider

        private void loadimage()
        {
            if (imageno == 4)
            {
                imageno = 0;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", imageno);
            imageno++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //προορισμος
            Form_proorismos frmDest = new Form_proorismos();
            frmDest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //χαρτης
            Form_map frmMap = new Form_map();
            frmMap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //αξιοθέατα
            Form_aksiotheata frm3 = new Form_aksiotheata();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //παραλίες
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //εκδηλώσεις
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //back home form from visitor forms
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Form_visitors_Load(object sender, EventArgs e)
        {
            //form visitors load 
            player.Play();
        
       

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //mute music
            player.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //slideshow
            loadimage();
        }

        
    }

}
