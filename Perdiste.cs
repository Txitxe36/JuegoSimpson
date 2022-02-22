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
    public partial class Perdiste : Form
    {
        public Perdiste()
        {
            InitializeComponent();
        }

        private void bReintentar_Click(object sender, EventArgs e)
        {
            
            Form form = new Form1();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
