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
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        // None = 0, Alt = 1,  Control = 2, Shift = 4,  WinKey = 8
        // Alt+Control = 3, Alt+Shift = 5, Control+Shift = 6
        private int HOTKEY_MOD = 6;
        private int HOTKEY1 = Keys.A.GetHashCode();
        private int HOTKEY2 = Keys.S.GetHashCode();

        public Form1()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, HOTKEY1, HOTKEY_MOD, HOTKEY1);
            RegisterHotKey(this.Handle, HOTKEY2, HOTKEY_MOD, HOTKEY2);
        }

        protected override void OnClosed(EventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY1);
            UnregisterHotKey(this.Handle, HOTKEY2);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312) {

                // O modificador da tecla de atalho que foi pressionada.
                int kmod = ((int)m.LParam & 0xFFFF);
                // A tecla da tecla de atalho que foi pressionada.
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                // O ID da tecla de atalho que foi pressionada.
                int kid = m.WParam.ToInt32();


                Console.WriteLine("MOD: "+ kmod+", KEY: " + key + ", KEYID: "+ kid);

                if (key == Keys.A) {
                    Console.WriteLine("PRESS: A");
                }

                else if (key == Keys.S) {
                    Console.WriteLine("PRESS: S");
                }

            }
        }
		
        
    }
}
