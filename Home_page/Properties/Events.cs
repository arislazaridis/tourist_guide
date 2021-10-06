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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Events_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\wednesday.JPG";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\monday.JPG";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\tuesday.JPG";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\thursday.JPG";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\friday.JPG";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\saturday.JPG";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\arisl\Desktop\tourist_guide\Home_page\photos\photos\nightlife\sunday.JPG";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //back form_login to usermenu
            Usermenu usermn = new Usermenu();
            usermn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
