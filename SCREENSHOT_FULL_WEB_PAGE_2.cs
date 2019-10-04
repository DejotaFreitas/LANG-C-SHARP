using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SysScreen.mylib;

namespace SysScreen
{
    public partial class JanelaPrincipal : Form
    {
        private Bitmap b;

        public JanelaPrincipal()
        {
            InitializeComponent();            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private void Btn_capiturar_Click(object sender, EventArgs e)
        {
            this.CapiturarTela();
        }

        private void Btn_salvar_Click_1(object sender, EventArgs e)  {
            this.SalvarImagen();
        }

        private void Btn_capitirar_salvar_Click(object sender, EventArgs e)
        {
            if (this.CapiturarTela())  { this.SalvarImagen(); }
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            ConfigSQLite.loadConfig();
            switch (Config.navegador) {
                case "chrome": rb_chrome.Checked = true; break;
                case "firefox": rb_firefox.Checked = true; break;
                case "opera": rb_opera.Checked = true; break;                
                case "iexplore": rb_explorer.Checked = true; break;
                case "msedge": rb_msedge.Checked = true; break;
                case "Safari": rb_safari.Checked = true; break;
                default: rb_chrome.Checked = true;  break;
            }
            
            cb_salvar_computador.Checked = Config.salvar_computador;
            cb_salvar_nuvem.Checked = Config.salvar_nuvem;            
            cb_abrir_diretorio_imagem.Checked = Config.abrir_diretorio_image;
            cb_capiturar_modo_rapido.Checked = Config.capiture_modo_rapido;
        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (rb_chrome.Checked) { Config.navegador = "chrome"; }
            else if (rb_firefox.Checked) { Config.navegador = "firefox"; }
            else if (rb_opera.Checked) { Config.navegador = "opera"; }
            else if (rb_explorer.Checked) { Config.navegador = "iexplore"; }
            else if (rb_msedge.Checked) { Config.navegador = "msedge"; }
            else if (rb_safari.Checked) { Config.navegador = "Safari"; }

            Config.salvar_computador = cb_salvar_computador.Checked;
            Config.salvar_nuvem = cb_salvar_nuvem.Checked;
            Config.abrir_diretorio_image = cb_abrir_diretorio_imagem.Checked;
            Config.capiture_modo_rapido = cb_capiturar_modo_rapido.Checked;

            ConfigSQLite.saveConfig();
        }

        private void JanelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show(this, "Dejesa encerrar a aplicação ?", "Sair",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        //===========MY=FUNC=====================================================

        private bool CapiturarTela()
        {
            if (rb_chrome.Checked) { Config.navegador = "chrome"; }
            else if (rb_firefox.Checked) { Config.navegador = "firefox"; }
            else if (rb_opera.Checked) { Config.navegador = "opera"; }
            else if (rb_explorer.Checked) { Config.navegador = "iexplore"; }
            else if (rb_msedge.Checked) { Config.navegador = "msedge"; }
            else if (rb_safari.Checked) { Config.navegador = "Safari"; }
            else {
                MessageBox.Show("Nenhum navegador foi selecionado", "Mensagem");
                return false;
            }

            var processes = System.Diagnostics.Process.GetProcessesByName(Config.navegador);
            if (processes.Length > 0)
            {
                foreach (var process in processes)
                {
                    ShowWindow(process.MainWindowHandle, 2);
                    ShowWindow(process.MainWindowHandle, 3);
                }
                System.Threading.Thread.Sleep(1000);
                SendKeys.Send("{F11}");
                if (cb_capiturar_modo_rapido.Checked)
                {
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    if (Config.navegador == "chrome" || Config.navegador == "opera" ||
                        Config.navegador == "msedge" || Config.navegador == "safari")
                    {
                        System.Threading.Thread.Sleep(5000);
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(2000);
                    }
                }

                int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
                int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
                b = new Bitmap(TelaLargura, TelaAltura);
                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
                pb_screenshot.Image = b;
                pb_screenshot.SizeMode = PictureBoxSizeMode.StretchImage;
                SendKeys.Send("{F11}");
                System.Threading.Thread.Sleep(500);
                foreach (var process in processes) { ShowWindow(process.MainWindowHandle, 2); }
            }
            else
            {
                MessageBox.Show("O navegador especificado não está sendo executado.", "Mensagem");
                return false;
            }
            return true;
        }



        private bool SalvarImagen()
        {
            String ImgName = "_DATA_" + DateTime.Now.ToString("yyyy_MM_dd")
                      + "_HORA_" + DateTime.Now.ToString("HH_mm_ss") + "_SysScreen_";
            String ImgMine = "jpeg";

            if (pb_screenshot.Image != null)
            {
                if (cb_salvar_computador.Checked)
                {
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        FileName = ImgName,
                        Filter = Config.lastFormatSave,
                        InitialDirectory = Config.pathSaveImage,
                    };
                    try
                    {
                        
                        DialogResult res = sfd.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            string ext = Path.GetExtension(sfd.FileName);
                            if (ext == ".jpeg")
                            {
                                pb_screenshot.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                                Config.lastFormatSave = "JPEG|*.jpeg|PNG|*.png|PDF|*.pdf";
                                ImgMine = ".jpeg";

                            }
                            else if (ext == ".png")
                            {
                                pb_screenshot.Image.Save(sfd.FileName, ImageFormat.Png);
                                Config.lastFormatSave = "PNG|*.png|JPEG|*.jpeg|PDF|*.pdf";
                                ImgMine = ".png";
                            }
                            else if (ext == ".pdf")
                            {
                                ImgMine = ".pdf";
                                try
                                {
                                    MemoryStream ms = new MemoryStream();
                                    pb_screenshot.Image.Save(ms, ImageFormat.Jpeg);
                                    byte[] buff = ms.GetBuffer();

                                    Document doc = new Document(PageSize.A4.Rotate(), 2, 2, 2, 2);
                                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                                    doc.Open();
                                    var jpeg = new Jpeg(buff);
                                    jpeg.ScaleToFit(doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin), doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin));
                                    doc.Add(jpeg);
                                    doc.Close();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    MessageBox.Show("Tivemos algum problema ao salvar em PDF", "Mensagem");
                                    return false;
                                }
                                Config.lastFormatSave = "PDF|*.pdf|JPEG|*.jpeg|PNG|*.png";
                            }
                            Config.pathSaveImage = Path.GetDirectoryName(sfd.FileName);
                            if (cb_abrir_diretorio_imagem.Checked == true)
                            {
                                System.Diagnostics.Process.Start("Explorer", Config.pathSaveImage);
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Tivemos algum problema para salvar a imagem no computador", "Mensagem");
                        return false;
                    }
                    finally
                    {
                        sfd.Dispose();
                    }

                    
                }
                // =====================================================================================
                if (cb_salvar_nuvem.Checked)
                {
                    try
                    {
                        UploadImage(pb_screenshot, "http://sysscreenwebsite/api/uploadimageapi", ImgName, ImgMine);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Tivemos algum problema para enviat a imagem para nuvem", "Mensagem");
                        return false;
                    }
                }

            }
            else
            {
                MessageBox.Show("Nenhuma imagem foi capiturada.", "Mensagem");                
                return false;
            }
            return true;
        }

        private void Btn_screenshot_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(500);
            int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
            int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
            b = new Bitmap(TelaLargura, TelaAltura);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            pb_screenshot.Image = b;
            pb_screenshot.SizeMode = PictureBoxSizeMode.StretchImage;
            System.Threading.Thread.Sleep(500);
            this.Show();
        }

        private void Btn_site_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.br/");        
        }

        private void Btn_licenca_Click(object sender, EventArgs e)
        {
            new form_licenciar(this.lbl_tempo_licenca).ShowDialog();
        }

        private async void UploadImage(PictureBox pb, string url, string ImgName, string ImgMine)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();

                form.Add(new StringContent("1"), "userid");
                
                form.Add(new StringContent("Dejota"), "username");
                form.Add(new StringContent("djxgs@gmil.com"), "email");
                form.Add(new StringContent("0123"), "password");

                MemoryStream ms = new MemoryStream();
                if (ImgMine == ".jpeg")
                {
                    pb.Image.Save(ms, ImageFormat.Jpeg);
                }
                else if (ImgMine == ".png")
                {
                    pb.Image.Save(ms, ImageFormat.Png);
                }
                else
                {
                    pb.Image.Save(ms, ImageFormat.Jpeg);
                    ImgMine = ".jpeg";
                }

                byte[] img = ms.ToArray();

                form.Add(new ByteArrayContent(img, 0, img.Length), "imagem", ImgName + ImgMine);
                HttpResponseMessage response = await httpClient.PostAsync(url, form);

                response.EnsureSuccessStatusCode();
                httpClient.Dispose();
                string result = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show(result, "RESPOSTA HTTP");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Mensagem");
            }
        }
    }
}
