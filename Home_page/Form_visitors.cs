﻿using System;
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
        public Form_visitors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //προορισμος
            Form_proorismos frmDest = new Form_proorismos();
            frmDest.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //χαρτης
            Form_map frmMap = new Form_map();
            frmMap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //αξιοθέατα
            Form_aksiotheata frm3 = new Form_aksiotheata();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //παραλίες
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //εκδηλώσεις
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //back home form from visitor forms
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}