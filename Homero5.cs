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
    public partial class Homero5 : Form
    {
        public Homero5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form homero = new Homero6();
            this.Hide();
            this.Close();
            homero.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form per = new Perdiste();
            this.Hide();
            this.Close();
            per.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form per = new Perdiste();
            this.Hide();
            this.Close();
            per.ShowDialog();
        }
    }
}
