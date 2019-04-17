using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;


namespace DejotaGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static JanelaCombate janelaCombateObj;

        static SistemaJogo player01 = new SistemaJogo();        
        static SistemaJogo player02 = new SistemaJogo();


        static int life01 = 90;
        static int life02 = 90;
        public static void zerarPontosVida()
        {
            player01.pontosVida = 0;
            player02.pontosVida = 0;

        }
        public static void RestaurarPontosVida()
        {
            System.Threading.Thread.Sleep(2000);
            player01.pontosVida = life01;
            player02.pontosVida = life02;
        }


        public String avatarEscolhidoPlayer01 = "Charizard";
        public String avatarEscolhidoPlayer02 = "Pikachu";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void bnt_Pronto_Click(object sender, RoutedEventArgs e)
        {
            if (player01.pontosVida <= 0 || player02.pontosVida <= 0)
            {
                player01.pontosVida = life01;
                player02.pontosVida = life02;
            }

            janelaCombateObj = new JanelaCombate();
            janelaCombateObj.Show();
            janelaCombateObj.image_char01Combate.Source = new BitmapImage(new Uri("D:/zzProjects/C#/Visual Studio/DejotaGame/DejotaGame/img/" + avatarEscolhidoPlayer01 + ".jpg"));
            janelaCombateObj.image_char02Combate.Source = new BitmapImage(new Uri("D:/zzProjects/C#/Visual Studio/DejotaGame/DejotaGame/img/" + avatarEscolhidoPlayer02 + ".jpg"));

            if (textBox_nomeJogador1.Text != "")
            {
                janelaCombateObj.lbl_NomeJogador01Combate.Content = textBox_nomeJogador1.Text;
                player01.nomeJogador = textBox_nomeJogador1.Text;
            }
            else
            {
                player01.nomeJogador = "Noob01";
            }

            if (textBox_nomeJogador2.Text != "")
            {
                janelaCombateObj.lbl_NomeJogador02Combate.Content = textBox_nomeJogador2.Text;
                player02.nomeJogador = textBox_nomeJogador2.Text;
            }
            else
            {
                player02.nomeJogador = "Noob02";
            }

            janelaCombateObj.lbl_vidaJogador01Combate.Content = player01.pontosVida.ToString();
            janelaCombateObj.lbl_vidaJogador02Combate.Content = player02.pontosVida.ToString();

            Thread t01 = new Thread(new ThreadStart(fight01));
            Thread t02 = new Thread(new ThreadStart(fight02));
            t01.Start();
            t02.Start();
        }

        private void btn_resete_Click(object sender, RoutedEventArgs e)
        {
            //Resetar
            SistemaJogo.resetar(player01);
            SistemaJogo.resetar(player02);

            lbl_PHataque1.Content = player01.ataque;
            lbl_PHdefesa1.Content = player01.defesa;
            lbl_PHvida1.Content = player01.vida;
            lbl_PHvelocidade1.Content = player01.velocidade;
            lbl_PHcritico1.Content = player01.critico;
            lbl_PHesquiva1.Content = player01.esquiva;
            lbl_PHprecisao1.Content = player01.precisao;
            lbl_PH1.Content = player01.ph;

            lbl_PHataque2.Content = player02.ataque;
            lbl_PHdefesa2.Content = player02.defesa;
            lbl_PHvida2.Content = player02.vida;
            lbl_PHvelocidade2.Content = player02.velocidade;
            lbl_PHcritico2.Content = player02.critico;
            lbl_PHesquiva2.Content = player02.esquiva;
            lbl_PHprecisao2.Content = player02.precisao;
            lbl_PH2.Content = player02.ph;

        }

        //================Eventos Mause esquerdo=============================================================================================================================\\

        private void btn_ataque1_Click(object sender, RoutedEventArgs e)
        {     
                if (player01.ph > 0 )
                {
                    player01.ataque += 1;
                    lbl_PHataque1.Content = player01.ataque;
                    player01.ph -= 1;
                    lbl_PH1.Content = player01.ph;
                } 
        }

        private void btn_defesa1_Click(object sender, EventArgs e)
        {           
            if (player01.ph > 0 && player01.defesa <5 )
            {
                player01.defesa += 1;
                lbl_PHdefesa1.Content = player01.defesa;
                player01.ph -= 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_vida1_Click(object sender, RoutedEventArgs e)
        {
            if (player01.ph > 0)
            {
                player01.vida += 1;
                lbl_PHvida1.Content = player01.vida;
                SistemaJogo.AddVida(player01);
                life01 = player01.pontosVida;
                player01.ph -= 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_velocidade1_Click(object sender, RoutedEventArgs e)
        {
            if (player01.ph > 0)
            {
                player01.velocidade += 1;
                lbl_PHvelocidade1.Content = player01.velocidade;
                 player01.ph -= 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_critico1_Click(object sender, RoutedEventArgs e)
        {
            if (player01.ph > 0)
            {
                player01.critico += 1;
                lbl_PHcritico1.Content = player01.critico;
                player01.ph -= 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_esquiva1_Click(object sender, RoutedEventArgs e)
        {
            if (player01.ph > 0 && player01.esquiva < 5)
            {
                player01.esquiva += 1;
                lbl_PHesquiva1.Content = player01.esquiva;
                player01.ph -= 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_precisao1_Click(object sender, RoutedEventArgs e)
        {
            if (player01.ph > 0)
            {
                player01.precisao += 1;
                lbl_PHprecisao1.Content = player01.precisao;
                player01.ph -= 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_ataque2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0)
            {
                player02.ataque += 1;
                lbl_PHataque2.Content = player02.ataque;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_defesa2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0 && player02.defesa < 5)
            {
                player02.defesa += 1;
                lbl_PHdefesa2.Content = player02.defesa;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_vida2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0)
            {
                player02.vida += 1;
                lbl_PHvida2.Content = player02.vida;
                SistemaJogo.AddVida(player02);
                life02 = player02.pontosVida;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_velocidade2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0)
            {
                player02.velocidade += 1;
                lbl_PHvelocidade2.Content = player02.velocidade;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_critico2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0)
            {
                player02.critico += 1;
                lbl_PHcritico2.Content = player02.critico;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_PHesquiva2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0 && player02.esquiva < 5)
            {
                player02.esquiva += 1;
                lbl_PHesquiva2.Content = player02.esquiva;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_PHprecisao2_Click(object sender, RoutedEventArgs e)
        {
            if (player02.ph > 0)
            {
                player02.precisao += 1;
                lbl_PHprecisao2.Content = player02.precisao;
                player02.ph -= 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        //========================Eventos Mause Direiro=====================================================================================================================\\

        private void btn_ataque1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.ataque > 1)
            {
                player01.ataque -= 1;
                lbl_PHataque1.Content = player01.ataque;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_defesa1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.defesa > 1)
            {
                player01.defesa -= 1;
                lbl_PHdefesa1.Content = player01.defesa;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_vida1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.vida > 1)
            {
                player01.vida -= 1;
                lbl_PHvida1.Content = player01.vida;
                SistemaJogo.removerVida(player01);
                life01 = player01.pontosVida;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_velocidade1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.velocidade > 1)
            {
                player01.velocidade -= 1;
                lbl_PHvelocidade1.Content = player01.velocidade;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_critico1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.critico > 1)
            {
                player01.critico -= 1;
                lbl_PHcritico1.Content = player01.critico;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_esquiva1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.esquiva > 1)
            {
                player01.esquiva -= 1;
                lbl_PHesquiva1.Content = player01.esquiva;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_precisao1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player01.precisao > 1)
            {
                player01.precisao -= 1;
                lbl_PHprecisao1.Content = player01.precisao;
                player01.ph += 1;
                lbl_PH1.Content = player01.ph;
            }
        }

        private void btn_ataque2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.ataque > 1)
            {
                player02.ataque -= 1;
                lbl_PHataque2.Content = player02.ataque;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_defesa2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.defesa > 1)
            {
                player02.defesa -= 1;
                lbl_PHdefesa2.Content = player02.defesa;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_vida2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.vida > 1)
            {
                player02.vida -= 1;
                lbl_PHvida2.Content = player02.vida;
                SistemaJogo.removerVida(player02);
                life02 = player02.pontosVida;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_velocidade2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.velocidade > 1)
            {
                player02.velocidade -= 1;
                lbl_PHvelocidade2.Content = player02.velocidade;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_critico2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.critico > 1)
            {
                player02.critico -= 1;
                lbl_PHcritico2.Content = player02.critico;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_PHesquiva2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.esquiva > 1)
            {
                player02.esquiva -= 1;
                lbl_PHesquiva2.Content = player02.esquiva;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        private void btn_PHprecisao2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (player02.precisao > 1)
            {
                player02.precisao -= 1;
                lbl_PHprecisao2.Content = player02.precisao;
                player02.ph += 1;
                lbl_PH2.Content = player02.ph;
            }
        }

        //==========================ComboBox Avatares===================================================================================================================\\


        private void comboBox_avatar1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selecaoComboBox01 = (comboBox_avatar1.SelectedItem as ComboBoxItem).Content.ToString();
            avatarEscolhidoPlayer01 = selecaoComboBox01;
            image_char01.Source = new BitmapImage(new Uri("D:/zzProjects/C#/Visual Studio/DejotaGame/DejotaGame/img/"+ selecaoComboBox01 + ".jpg"));

        }

        private void comboBox_avatar2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selecaoComboBox02 = (comboBox_avatar2.SelectedItem as ComboBoxItem).Content.ToString();
            avatarEscolhidoPlayer02 = selecaoComboBox02;
            image_char02.Source = new BitmapImage(new Uri("D:/zzProjects/C#/Visual Studio/DejotaGame/DejotaGame/img/" + selecaoComboBox02 + ".jpg"));
        }


        //================================Iniciar Combate=============================================================================================================\\
        //salvando a pratria....thread rodando dentro da thread da interface. 
        //.Dispatcher.BeginInvoke((Action)(() => {  }));

        public static void fight01()
        {
            int danoVariavelLocal;
            while (player01.pontosVida > 0 && player02.pontosVida > 0)
            {
                
                System.Threading.Thread.Sleep(SistemaJogo.velocidadeAtaque(player01.velocidade));

                if ((SistemaJogo.acertar(player01.precisao)) >= (SistemaJogo.esquivar(player02.esquiva)))
                {
                    //acertou
                    if ((SistemaJogo.criticar(player01.critico)) > (SistemaJogo.defender(player02.defesa)))
                    {
                        //critico
                        danoVariavelLocal = (SistemaJogo.dano(player01.ataque));
                        if (danoVariavelLocal > 0)
                        { 
                            player02.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador01Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador02Combate.Content = player02.pontosVida.ToString(); }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player01.nomeJogador + ": " + danoVariavelLocal + " Crítico"); }));
                            }
                            else
                            {
                            danoVariavelLocal = 0;
                            player02.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador01Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador02Combate.Content = player02.pontosVida.ToString(); }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player01.nomeJogador + ": " + danoVariavelLocal + " Crítico"); }));
                            }

                      }
                     else 
                     {
                            //dano normal
                            danoVariavelLocal = ((SistemaJogo.dano(player01.ataque)) - SistemaJogo.defender(player02.defesa));
                        if (danoVariavelLocal > 0)
                        {
                            player02.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador01Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador02Combate.Content = player02.pontosVida.ToString(); }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player01.nomeJogador + ": " + danoVariavelLocal); }));
                        }
                        else
                        {
                            danoVariavelLocal = 0;
                            player02.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador01Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador02Combate.Content = player02.pontosVida.ToString(); }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player01.nomeJogador + ": " + danoVariavelLocal); }));
                        }
                    }
                }
                else
                {
                    //errou
                    janelaCombateObj.lbl_danoJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador01Combate.Content = "Errou"; }));
                    janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player01.nomeJogador + ": Errou"); }));
                    
                }

            }

        }

        public static void fight02()
        {
            int danoVariavelLocal;
            while (player01.pontosVida > 0 && player02.pontosVida > 0)
            {                
                System.Threading.Thread.Sleep(SistemaJogo.velocidadeAtaque(player02.velocidade));

                if ((SistemaJogo.acertar(player02.precisao)) >= (SistemaJogo.esquivar(player01.esquiva)))
                {
                    //acertou
                    if ((SistemaJogo.criticar(player02.critico)) > (SistemaJogo.defender(player01.defesa)))
                    {
                        //critico
                        danoVariavelLocal = (SistemaJogo.dano(player02.ataque));
                        if (danoVariavelLocal > 0)
                        {
                            player01.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador02Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador01Combate.Content = player01.pontosVida; }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player02.nomeJogador + ": " + danoVariavelLocal + " Crítico"); }));
                        }
                        else
                        {
                            danoVariavelLocal = 0;
                            player01.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador02Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador01Combate.Content = player01.pontosVida; }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player02.nomeJogador + ": " + danoVariavelLocal + " Crítico"); }));


                        }
                        }
                        else
                        {
                        //dano normal
                        danoVariavelLocal = ((SistemaJogo.dano(player02.ataque)) - SistemaJogo.defender(player01.defesa));
                        if (danoVariavelLocal > 0)
                        {
                            player01.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador02Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador01Combate.Content = player01.pontosVida; }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player02.nomeJogador + ": " + danoVariavelLocal); }));

                        }
                        else
                        {
                            danoVariavelLocal = 0;
                            player01.pontosVida -= danoVariavelLocal;
                            danoVariavelLocal.ToString();
                            janelaCombateObj.lbl_danoJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador02Combate.Content = danoVariavelLocal; }));
                            janelaCombateObj.lbl_vidaJogador01Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_vidaJogador01Combate.Content = player01.pontosVida; }));
                            janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player02.nomeJogador + ": " + danoVariavelLocal); }));


                        }

                    }
                }
                else
                {
                        //errou
                        janelaCombateObj.lbl_danoJogador02Combate.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.lbl_danoJogador02Combate.Content = "Errou"; }));
                        janelaCombateObj.listBox_combateLog.Dispatcher.BeginInvoke((Action)(() => { janelaCombateObj.listBox_combateLog.Items.Add(player02.nomeJogador + ": Errou"); }));
                    
                }

            }

        }
        
        //======END=====\\
    }
    }

