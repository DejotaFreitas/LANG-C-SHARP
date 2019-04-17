using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bclick_Click(object sender, EventArgs e)
        {
            txtSaida.Text = txtEntrada.Text;
            txtEntrada.Focus();
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEntrada_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
        }

        private void txtEntrada_MouseHover(object sender, EventArgs e)
        {
            txtEntrada.Text = "Digite seu nome";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtEntrada.Focus();
            txtEntrada.Copy();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            txtEntrada.Focus();
            txtEntrada.Cut();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtSaida.Paste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSaida.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtSaida.Show();
        }
    }
}
