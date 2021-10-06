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
    public partial class farmakeia : Form
    {
        public farmakeia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back form_login to usermenu
            Usermenu usermn = new Usermenu();
            usermn.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Δ. Παπασταύρου, Ελευθερίας 23, τηλ:6978599967");


        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Δ. Μήτσου, Παύλου 23, τηλ:6787992334");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Θ. Ασπροβοτσαλος, Λυδίας Α3, τηλ:6978599967");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Θ. Ορνόπουλος, Ασπρίας 6, τηλ:6978599967");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Θ. Δημητρίου, Καταστάλας, τηλ:233319098");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Θ. Βοτσαλάκης, Αφροδίτης, τηλ:6978599967");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Μαυρονίκου, Σωτηρίας 2, τηλ:6978599967");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Σκλαβενίτης, Αγιάς Ελεούσας, τηλ:6978599967");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Θανασάκης, Καλλιθέας 46, τηλ:6978599967");

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Ηροδότου, Αφρούλας 54, τηλ:6978599967");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Βουρλής, Πλατεία, τηλ:6978599967");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Παπαδοπόύλου Ε., Άνω Μερά, τηλ:6978599967");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Φαρμακείο Παπαδοπόύλου Ε., Κάτω Μερά, τηλ:6978538455");

        }

        private void farmakeia_Load(object sender, EventArgs e)
        {

        }
    }
}
