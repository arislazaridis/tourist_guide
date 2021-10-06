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
    public partial class Form_calendar : Form
    {
        public Form_calendar()
        {
            InitializeComponent();

            //αρχικα το πανελ1 οπου εχει να δεις τα σχολια ειναι κρυμμενο
            panel_aksiologiseis.Hide();


            //η τιμη που θα εχει το dateTimePicker1.Value ειναι η σημερινη ημερομηνια
            dateTimePicker1.Value = DateTime.Today;
            //το textbox το οποιο εμφανιζιε τα σχολια το κανουμε να ειναι μονο για διαβασμα
            // και ετσι ωστε ο χρηστης να μην μπορει να σβησει τα σχολια
            richTextBox2.ReadOnly = true;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            //ypovoli

            //φτιαχνουμε ένα αντικειμενο τυπου datetime  του οποιου του δινουμε να εχει την σημερινη ωρα και ημερομηνια 
            //και την αποθηκευουμε σε μια μεταβλητη τυπου  string 
            DateTime date = DateTime.Now;
            string formattedDate = date.ToString("dddd, dd MMMM yyyy HH:mm");
            //στην συνεχεια θα κανουμε append  σε ενα αρχειο . αν αυτο το αρχειο δεν υπαρχιε θα το δημιουργησει
            
                using (StreamWriter sw1 = File.AppendText("comments.txt"))
                {
                    //ελεγχει αν το ονομα του χρηστη ειναι κενο,και του δινει το text  ανωνυμος
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "Anonymous";
                    }
                    //στην περιπτωση ομως που το text  του σχολιου ειναι κενο του λεει οτι πρεπει να γραψει μηνυμα
                    //αν ολα ειναι οκ τοτε φραφει το μηνυμα
                    if (richTextBox1.Text == "")
                    {
                        MessageBox.Show("you must type a comment");
                    }
                    else
                    {
                        //στην συνεχεια του λεμε να γράψει τα καταλληλα μηνυμα,σε περιπτωση που παραχθει καποιο
                        //exception  βγαινουν τα αντιστοιχα μηνυματα
                        try
                        {
                            sw1.WriteLine("---------------------------------------------------------------");
                            sw1.WriteLine("Ο χρήστης " + textBox1.Text + " την ημερομηνία " + formattedDate + " σχολίασε: ");
                            sw1.WriteLine(richTextBox1.Text);
                            MessageBox.Show("Το σχόλιο σας υποβλήθηκε επιτυχώς");
                        }
                        catch (IOException e1)
                        //όταν ο χρήστης εισάγει ακατάλληλα δεδομένα στο πρόγραμμα. Αυτοί μπορεί να είναι τύποι δεδομένων που
                        //δεν μπορεί να χειριστεί το πρόγραμμα ή όνομα αρχείου που δεν υπάρχει.
                        //Όταν συμβεί αυτό, εμφανίζεται μια εξαίρεση (IOException) που λέει στον μεταγλωττιστή ότι έχει
                        //συμβεί μη έγκυρη είσοδος ή μη έγκυρη έξοδος.
                        {
                            MessageBox.Show(e1.GetType().Name);
                        }
                        catch (ObjectDisposedException e2)

                        //Ένα ObjectDisposedException ρίχνεται όταν προσπαθείτε να αποκτήσετε πρόσβαση σε ένα μέλος
                        //ενός αντικειμένου που υλοποιεί τη διεπαφή IDisposable και το αντικείμενο έχει απορριφθεί.
                        {
                            MessageBox.Show("Object Disposed Exception");
                        }
                    }

                }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //akksiologiseis
            //με το πατημα του κουμπιου εμφανιζεται το panel1  οπου περιεχει το textbox3 οπου θα  εμφανισιε το περιεχομενο 
            //του txt αρχειου οπου καταχωρουνται τα σχολια
            panel_aksiologiseis.Show();
            try
            {
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader("comments.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                    richTextBox2.Text = sb.ToString();
                }
            }
            catch (IOException e3)
            {
                MessageBox.Show(e3.GetType().Name);
            }
            catch (ArgumentException e4)
            {
                MessageBox.Show(e4.GetType().Name);
            }
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //calendar
        }

        private void panel_aksiologiseis_Paint(object sender, PaintEventArgs e)
        {
            //panel aksiologisewn 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //gia sxolia
        }

        private void Form_calendar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_aksiologiseis.Hide();
        }
    }
}
