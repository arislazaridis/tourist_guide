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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contactUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //contact us
            Form_contact frmcontact = new Form_contact();
            frmcontact.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about
            MessageBox.Show("Ο τουριστικός οδηγός εκπονήθηκε απο τους φοιτητές : " +
                "Άρη Λαζαρίδη και Μάκη Μακρανδρέου με ΑΜ : " +
                "20042,20045");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login as user
            Form_login frm2 = new Form_login();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //login as visitor
            Form_visitors visitor= new Form_visitors();
            visitor.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            //με το που πατησουμε το label  τοτε μας παει στην ιστσελιδα

            //φτιαχνουμε ενα αντικειμενο τυπου InternetPage οπου μεσα στον κονστρακτορα βαζουλε το λινκ που θα εχει

            InternetPage newpage = new InternetPage("https://mykonos.gr/en/");

            //στην συνεχεια καλουμε την μεθοδο ωστς να ανοιξει η ιστοσελιδα
            newpage.OpenWebPage();

        }
    }
}
