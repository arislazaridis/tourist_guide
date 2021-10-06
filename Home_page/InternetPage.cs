using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Home_page
{
    class InternetPage
    {
        private String urlname;

        //ο κοντρακτορας τησ κλασης οπου αρχικοποιουμε το url της σελιδας που θελουμε αν ανοιξουμε
        public InternetPage(String urlname)
        {
            this.urlname = urlname;
        }


        //μεθοδος στην οποια οταν καλεστει ανοιγει την σελιδα που θελουμε
        public void OpenWebPage()
        {
            try
            {
                Process.Start(urlname);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show("Win32 Exception"); //για ανύπαρκτο εκτελέσιμο
            }
            catch (ObjectDisposedException e1)
            {
                MessageBox.Show("Object Disposed Exception"); //οταν το αντικείμενο έχει απορριφθεί ενώ προσπαθούμε να αποκτήσουμε πρόσβαση σε αυτό
            }
            catch (System.IO.FileNotFoundException e2) //δεν βρεθηκε το αρχείο
            {
                MessageBox.Show("File Not Found");
            }
        }
    }
}

