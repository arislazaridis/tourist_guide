using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;


namespace Home_page
{
    public partial class Form_proorismos : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
      


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

        private void button2_Click(object sender, EventArgs e)
        {

            //stop speech

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //start speech
            string toSpeak = richTextBox2.Text;

            speech.Speak(toSpeak);
            speech.Dispose();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //english
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            button_speech.Visible = true;
            button_stop.Visible = true;

        }

        private void button_greek_Click(object sender, EventArgs e)
        {
            //greek
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            button_speech.Visible = false;
            button_stop.Visible = false;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //greek text
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            //english text
        }

        private void Form_proorismos_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            button_speech.Visible = false;
            button_stop.Visible = false;
        }
    }
    }

