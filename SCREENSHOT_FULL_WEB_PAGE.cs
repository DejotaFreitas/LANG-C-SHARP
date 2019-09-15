using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;

namespace Screenshot_Capture
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        private String url;
        private String path;
        private FolderBrowserDialog folderBrowserDialog;

        public Form1()
        {
            InitializeComponent();
            this.url = "https://www.mercadopago.com.br/";
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        }

        private void capiturar_screenshot(object sender, EventArgs e)
        {
            if (this.driver != null) {
                try
                {
                    //ScreenshotImageFormat format;
                    //JPG
                    if (rb_formato_jpg.Checked == true)
                    {     
                        //format = ScreenshotImageFormat.Jpeg;
                        String filePathName = path + "\\" + "Screenshot_Capture_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".jpeg";
                        //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filePathName, format);

                        var bytesArray = driver.TakeScreenshot(new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting()));
                        MemoryStream ms = new MemoryStream(bytesArray, 0, bytesArray.Length);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                        image.Save(filePathName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytesArray = null;
                        image.Dispose();

                        //PNG
                    } else if (rb_formato_png.Checked == true) {
                        //format = ScreenshotImageFormat.Png;
                        String filePathName = path + "\\" + "Screenshot_Capture_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".png";
                        //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filePathName, format)

                        var bytesArray = driver.TakeScreenshot(new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting()));
                        MemoryStream ms = new MemoryStream(bytesArray, 0, bytesArray.Length);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                        image.Save(filePathName, System.Drawing.Imaging.ImageFormat.Png);
                        bytesArray = null;
                        image.Dispose();

                        //PDF
                    } else if (rb_formato_pdf.Checked == true){
                        //format = ScreenshotImageFormat.Jpeg;

                        String filePath = path;
                        String fileName = "Screenshot_Capture_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
                        String filePathName = filePath + "\\" + fileName;
                        //((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filePathName+ ".jpeg", format);

                        var bytesArray = driver.TakeScreenshot(new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting()));
                        MemoryStream ms = new MemoryStream(bytesArray, 0, bytesArray.Length);
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                        image.Save(filePathName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytesArray = null;
                        image.Dispose();

                        //criando pdf
                        Document doc = new Document();
                        try {
                            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filePathName + ".pdf", FileMode.Create));
                            doc.Open();
                            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(filePathName + ".jpeg");
                            jpg.Border = iTextSharp.text.Rectangle.BOX;
                            var jpeg = new Jpeg(jpg);
                            jpeg.ScaleToFit(doc.PageSize.Width - (doc.LeftMargin + doc.RightMargin),
                              doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin));
                            doc.Add(jpeg);                    
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex);
                            MessageBox.Show("Tivemos algum problema ao salvar em PDF", "Mensagem");
                        } finally {
                            doc.Close();
                            File.Delete(filePathName + ".jpeg");
                        }
                    }   
                
                    System.Diagnostics.Process.Start("Explorer", path);

                    /*
                    var result = MessageBox.Show("Imagem salva com sucesso, " +
                        "deseja abrir diretorio onde a screenshot esta salva ?", 
                        "Mensagem",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)  {
                        System.Diagnostics.Process.Start("Explorer", path);
                    }
                    */

                } catch (Exception ex) {
                    Console.WriteLine(ex);
                    MessageBox.Show("Tivemos algum problema ao salvar a screenshot, " +
                        "provavelmente o navegar foi fechado ou a sua primeira aba, " +
                        "onde seria realizada a screenshot.", "Mensagem");
                    if (this.driver != null) { this.driver.Quit(); }
                }
            } else {
                MessageBox.Show("Abra o navegar através do nosso aplicativo " +
                    "antes de tentar capiturar a screenshot.", "Mensagem");
            }

        }

        private void execute_navegador(object sender, EventArgs e)
        {
            try
            {
                //Chrome
                if (rb_navegador_chorme.Checked == true) {
                    var driverService = ChromeDriverService.CreateDefaultService();
                    driverService.HideCommandPromptWindow = true;
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    driver = new ChromeDriver(driverService, options);
                    driver.Url = url;
                }
                // Firefox
                else if(rb_navegador_firefox.Checked == true) {
                    var driverService = FirefoxDriverService.CreateDefaultService();
                    driverService.HideCommandPromptWindow = true;
                    FirefoxOptions options = new FirefoxOptions();
                    options.AddArgument("--start-maximized");
                    driver = new FirefoxDriver(driverService, options);
                    //driver.Url = url;
                    driver.Navigate().GoToUrl(url);
                } else {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tivemos algum erro ao tentar abrir o navegador de internet", "Mensagem");
                Console.WriteLine(ex);
            }
        }

       
        // selecionar path salvar imagens
        private void path_select(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    String caminho = folderBrowserDialog.SelectedPath;
                    tb_path.Text = caminho;
                    this.path = caminho;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Tivemos algum problema ao tentar definir esse diretório.", "Mensagem");
            }            
            
        }

        // ao carrgar aplicação
        private void janela_principal_load(object sender, EventArgs e)
        {
            try
            {
                tb_path.Text = this.path;
                tb_url.Text = this.url;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Tivemos algum problema ao abrir a aplicação.", "Mensagem");
            }
        }

        // ao fechar aplicação
        private void janela_principal_closed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (this.driver != null) { this.driver.Quit(); }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void salvar_url(object sender, EventArgs e)
        {
            try
            {
                this.url = tb_url.Text;
                MessageBox.Show("URL salva com sucesso.", "Mensagem");
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                MessageBox.Show("Tivemos algum problema ao salvar a URL.", "Mensagem");
            }
        }


    }// fim classe
}
