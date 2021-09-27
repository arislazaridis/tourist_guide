using System;
using System.Collections;
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
        //dilwnoume mia lista opou tha valoume oles tis onomasies txt pou tha dimiourgoun ta koumpia mas pou ftiaxnoun to istoriko
        ArrayList mytxtlist = new ArrayList();
        public Form_visitors()
        {
            InitializeComponent();

            player.SoundLocation = "piano.wav";

            mytxtlist.Add("desthistory.txt");
            mytxtlist.Add("maphistory.txt");
            mytxtlist.Add("beachhistory.txt");
            mytxtlist.Add("acthistory.txt");
            mytxtlist.Add("viewhistory.txt");

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
            //ginete kokkino otan patisei o xristis to koumpi-istoriko
            button1.ForeColor = Color.Red;
            Form_proorismos frmDest = new Form_proorismos();
            frmDest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //χαρτης
            button2.ForeColor = Color.Red;
            Form_map frmMap = new Form_map();
            frmMap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //αξιοθέατα
            button3.ForeColor = Color.Red;
            Form_aksiotheata frm3 = new Form_aksiotheata();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //παραλίες
            button4.ForeColor = Color.Red;
            Form_beaches frmbeach = new Form_beaches();
            frmbeach.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //εκδηλώσεις
            button5.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //back home form from visitor forms
            button6.ForeColor = Color.Red;
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

        private void button8_Click(object sender, EventArgs e)
        {
            //reset history button

            //otan o xrhsths pathsei ekatharisei istorikoy tote epanaferontai ta koumpia opvw htan prin
            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;

            //τωρα εδω θα σβησουμε το μονιμο ιστορικο αφου το επιθυμει ο χρηστης πατωντας αυτο το κουμπι
            //αρχικα κλινουμε τον  timer 2 ετσι ωστε να μην ανανεωνεται το αρχεια συνεχως
            timer2.Stop();
            //στην συνεχεια θα φτιαξουμε ενα αντικειμενο τυπου HistoryTrack
            HistoryTrack deletehist = new HistoryTrack();
            //και εδω καλουμε την μεθοδο ετσι ωστε να ελεγξει αν υπαρχουν τα αρχεια και να τα σβησει
            deletehist.DeleteHistory(mytxtlist);

        }

       

        private void button8_MouseHover_1(object sender, EventArgs e)
        {
            //οταν περασει το ποντικι πανω απο το αντιστοιχο κουμπι δινει το καταλληλο hint  στον χρηστη
            toolTip1.Show("Διαγραφή του ιστορικού περιήγησης", button8);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
                //αυτος  o timer ειναι ετσι ωστε να ανανεωνεται συνεχως η ο ελεγχος για ποια κουμπια ειναι πατημενα
                //φτιαχνω ενα αντικειμενο τυπου HistoryTrack ωστε να καλεσω της μεθοδους και να παρακολουθησω το ιστορικο του χρηστη
                HistoryTrack ht = new HistoryTrack();
                //καλω της μεθοδους ωστε για το καθε κουμπι να ελεγξω αν ειναι πατημενο καθως και να γραψει το καταλληλο μηνυμα στο αρχειο του
                ht.PrintHistory(button1, "desthistory.txt");
                ht.PrintHistory(button2, "maphistory.txt");
                ht.PrintHistory(button3, "beachhistory.txt");
                ht.PrintHistory(button4, "acthistory.txt");
                ht.PrintHistory(button5, "viewhistory.txt");

            

        }

    }
    }



