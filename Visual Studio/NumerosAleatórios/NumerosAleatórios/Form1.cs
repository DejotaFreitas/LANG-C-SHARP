using System;
using System.Windows.Forms;

namespace NumerosAleatórios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraNumeros_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();

            for (int i = 0; i < 10; i++)
                listaResultado.Items.Add(randNum.Next(100));
        }

        private void btnGerarNumerosComSeed_Click(object sender, EventArgs e)
        {
            Random randNum = new Random(2012);
            for (int i = 0; i < 10; i++)
                listaResultado.Items.Add(randNum.Next());
        }

        private void btnGerarNumerosDouble_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
                listaResultado.Items.Add(randNum.NextDouble());
        }

        private void btnGerarNumeroNextByte_Click(object sender, EventArgs e)
        {
            byte[] randBytes = new byte[100];
            Random randNum = new Random();
            randNum.NextBytes(randBytes);

            for (int i = 0; i < 10; i++)
                listaResultado.Items.Add(randBytes[i]);
        }

        public string GerarSenhas()
        {
            int Tamanho = 10; // Numero de digitos da senha
            string senha = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;
        }

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            string senha = GerarSenhas();
            listaResultado.Items.Add(" Senha gerada : " + senha.ToUpper());
        }

        private void btnGerarNumerosNext2_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
                listaResultado.Items.Add(randNum.Next(100,200));
        }
    }
}
