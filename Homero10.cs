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
    public partial class Homero10 : Form
    {
        public Homero10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form gana = new Ganaste();
            this.Hide();
            this.Close();
            gana.ShowDialog();
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
