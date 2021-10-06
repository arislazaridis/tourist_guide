using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Home_page
{
    public partial class Form_map : Form
    {
        public Form_map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //αποθήκευση τηλεφώνων 
            TextWriter writer = new StreamWriter(@"C:\Users\arisl\Downloads\Home_page (1)\Home_page\Home_page\map.txt");

            writer.Write(richTextBox1.Text);
            MessageBox.Show("Αποθηκεύτηκε σε αρχείο");
            writer.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //fb
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //insta
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //twitter
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back to visitors form 
            Form_visitors frmVisit = new Form_visitors();
            frmVisit.Show();
        }
    }
}
