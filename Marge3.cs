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
    public partial class Marge3 : Form
    {
        public Marge3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form marge = new Marge4();

            this.Hide();
            this.Close();
            marge.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form per = new Perdiste();
            this.Hide();
            this.Close();
            per.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form per = new Perdiste();
            this.Hide();
            this.Close();
            per.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
