using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;


namespace Home_page
{
    public partial class Form_login : Form
    {


        



        public Form_login()
        {
            InitializeComponent();
            

         
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textbox password
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
           
            string strAccessSelect = "select * from users where userName='" + textBox1.Text + "'";


            int login_counter = 0;
            using (OleDbCommand cmddupders = new OleDbCommand(strAccessSelect, con))
            {

                cmddupders.Parameters.AddWithValue("@username", textBox1.Text);
                cmddupders.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                OleDbDataReader reader = cmddupders.ExecuteReader(CommandBehavior.SingleRow);
                while (reader.Read())
                {
                    string name = reader["username"].ToString();
                    string pwd = reader["password"].ToString();
                    

                    if (name == textBox1.Text && pwd == textBox2.Text )
                    {
                        
                        MessageBox.Show("Succesfull login");
                        this.Hide();


                        login_counter++;
                        
                        break;
                        
                        
                    }
                  
                    
                }
                if (login_counter == 0)
                {
                    MessageBox.Show("Credentials not found,Try Again");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                if (login_counter != 0)
                {
                    this.Hide();

                    Usermenu login = new Usermenu();
                    login.Show();

                }
                




            }
            




















           
        }
       


        private void button2_Click(object sender, EventArgs e)
        {
            //back form_login to form1
            

            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

       
    }
}


