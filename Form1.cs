using System;
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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Homero = new Homero1();
            this.Hide();
            Homero.ShowDialog();

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            Form bart = new Bart1();
            this.Hide();
            bart.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form marge = new Marge1();
            this.Hide();
            marge.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form lisa = new Lisa1();
            this.Hide();
            lisa.ShowDialog();
        }
    }
}
