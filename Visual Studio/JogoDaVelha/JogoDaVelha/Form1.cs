using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class janelaPrincipal : Form
    {
        string XO = "O";
        int vitorias = 0, derrotas = 0, empates = 0, contadorRodada = 0;

        public janelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fechar a execução do programa ?", "Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            Close();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            XouO(bt1);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            XouO(bt2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            XouO(bt3);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            XouO(bt4);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            XouO(bt5);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            XouO(bt6);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            XouO(bt7);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            XouO(bt8);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            XouO(bt9);
        }





//=============metodos dejota==============================
        public void XouO(Button x)
        {
            if (x.Text == "")
            {
                if (XO == "O")
                {
                    x.Text = "X";
                    XO = "X";
                } else if (XO == "X")
                {
                    x.Text = "O";
                    XO = "O";
                }

                VerificarVitoria();
            }            
        }

        public void LimparBotoes()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
        }

        public void VerificarVitoria()
        {
            contadorRodada += 1;


                if (((bt1.Text == bt2.Text && bt1.Text == bt3.Text && bt1.Text != "") ||

                    (bt1.Text == bt4.Text && bt1.Text == bt7.Text && bt1.Text != "") ||

                    (bt1.Text == bt5.Text && bt1.Text == bt9.Text && bt1.Text != "") ||

                    (bt5.Text == bt4.Text && bt5.Text == bt6.Text && bt5.Text != "") ||

                    (bt5.Text == bt2.Text && bt5.Text == bt8.Text && bt5.Text != "") ||

                    (bt5.Text == bt3.Text && bt5.Text == bt7.Text && bt5.Text != "") ||

                    (bt9.Text == bt8.Text && bt9.Text == bt7.Text && bt9.Text != "") ||

                    (bt9.Text == bt6.Text && bt9.Text == bt3.Text && bt9.Text != "")))
                {
                    MessageBox.Show("Alguem ganhou!");
                    vitorias +=1;
                    lb_vitorias.Text = vitorias.ToString();
                    LimparBotoes();
                    contadorRodada = 0;
                }else if (contadorRodada >= 9)
                {
                    MessageBox.Show("Ocorreu Empate!");
                    empates += 1;
                    lb_empates.Text = empates.ToString();
                    LimparBotoes();
                    contadorRodada = 0;
                 }


        }

    }
}
