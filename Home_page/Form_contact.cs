using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Home_page
{
    public partial class Form_contact : Form
    {
        private MailMessage msg;
        public Form_contact()
        {
            InitializeComponent();

        }

        private void Form_contact_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean isValid = Regex.IsMatch(textBox1.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9_\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.ECMAScript);
            if (isValid == false && textBox1.Text != "")
            {
                MessageBox.Show("Λαθος μορφή email , Πληκτρολόγησε ξανα ");
            }
            if (textBox1.Text != "" && richTextBox1.Text != "" && isValid ==true)
            {
                MessageBox.Show("Το μήνυμα σας έχει αποσταλεί");
            }
            else if (textBox1.Text != "" && richTextBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το πεδίο 'Μήνυμα' ");
            }
            else if (textBox1.Text == "" && richTextBox1.Text == "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το πεδίο 'Email' και 'Μήνυμα' ");
            }
            else if (textBox1.Text == "" && richTextBox1.Text != "")
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε το πεδίο 'Email' ");
            }
        }

        
    }
}
