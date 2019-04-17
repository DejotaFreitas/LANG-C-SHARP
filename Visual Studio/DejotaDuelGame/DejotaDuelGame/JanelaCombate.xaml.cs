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
using System.Windows.Shapes;

namespace DejotaGame
{
    /// <summary>
    /// Interaction logic for JanelaCombate.xaml
    /// </summary>
    public partial class JanelaCombate : Window
    {
        public JanelaCombate()
        {
            InitializeComponent();
 
        }

        private void JanelaDeCombate_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.zerarPontosVida();

        }

        private void JanelaDeCombate_Closed(object sender, EventArgs e)
        {
            MainWindow.RestaurarPontosVida();
        }
    }
}
