﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class Bart1 : Form
    {
        public Bart1()
        {
            InitializeComponent();
        }

       
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            Form bart = new Bart2();
            this.Hide();
            this.Close();
            bart.ShowDialog();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form per = new Perdiste();
            this.Hide();
            this.Close();
            per.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form per = new Perdiste();
            this.Hide();
            this.Close();
            per.ShowDialog();
        }
    }
}
