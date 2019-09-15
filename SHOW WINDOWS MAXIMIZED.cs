using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zTEST
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();            
        }

       

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private void Button1_Click(object sender, EventArgs e)
        {

            var processes = Process.GetProcessesByName("chrome");


            foreach (var process in processes)
            {
                ShowWindow(process.MainWindowHandle, 2);
                ShowWindow(process.MainWindowHandle, 3);
            }
            System.Threading.Thread.Sleep(500);
            SendKeys.Send("{F11}");
            System.Threading.Thread.Sleep(5000);
            //===================

            System.Threading.Thread.Sleep(500);
            //define a largura e altura para serem iguais a da tela
            int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
            int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
            //armazena a imagem no bitmap
            Bitmap b = new Bitmap(TelaLargura, TelaAltura);
            //copia a tela no bitmap
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            //atribui a imagem ao picturebox exibindo-a
            pictureBox1.Image = b;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //======================
            SendKeys.Send("{F11}");
            System.Threading.Thread.Sleep(500);

            foreach (var process in processes)
            {
                ShowWindow(process.MainWindowHandle, 2);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            //abre a janela de dialogo SaveDialog para salvar o arquivo gerado na captura
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "zImage";
            sfd.DefaultExt = "jpeg";
            sfd.Filter = "JPEG|*.jpeg|PNG|*.png|PDF|*.pdf";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DialogResult res = sfd.ShowDialog();
            Console.WriteLine(sfd.FileName);
            if (res == DialogResult.OK)
            {
                //obtem a extensão do arquivo salvo
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                if (ext == ".jpeg") pictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (ext == ".png") pictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
