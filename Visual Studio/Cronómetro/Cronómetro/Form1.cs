using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            string showseconds = "00";
            string showminutes = "00";
            string showhours = "00";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Empezar") //Comprueba que el botón sea para empezar
            {
                timer1.Start(); //Empieza el timer
                button1.Text = "Pausa"; //Pone que el botón sea para pausar
            }
            else //Si es para pausar
            {
                timer1.Stop(); //Parar el timer
                button1.Text = "Empezar"; //Pone el botón para empezar
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Parar del todo y poner a 0
            timer1.Stop(); //Parar el timer
            button1.Text = "Empezar"; //Pone el botón para empezar por si se había cambiado previamente
            label2.Text = "00:00:00"; //Pone la cuenta a 0
            seconds = 0; //Pone la cuenta a 0
            minutes = 0; //Pone la cuenta a 0
            hours = 0; //Pone la cuenta a 0
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 59) //Si hay 59 segundos
            {
                seconds = 0; //Pone segundos a 0
                if (minutes == 59) //Si hay 59 minutos
                {
                    minutes = 0; //Pone minutos a 0
                    hours = hours + 1; //Y suma 1 hora
                }
                else //Si no hay 59 minutos aún
                {
                    minutes = minutes + 1; //Se suma un minuto
                }
            }
            else //Si no hay 59 segundos aún
            {
                seconds = seconds + 1; //Se suma un segundo a la cuenta anterior
            }
            if (seconds == 0 || seconds == 1 || seconds == 2 || seconds == 3 || seconds == 4 || seconds == 5 || seconds == 6 || seconds == 7 || seconds == 8 || seconds == 9) //Añade 0 delante
            {
                showseconds = "0" + seconds;
            }
            else
            {
                showseconds = Convert.ToString(seconds);
            }
            if (minutes == 0 || minutes == 1 || minutes == 2 || minutes == 3 || minutes == 4 || minutes == 5 || minutes == 6 || minutes == 7 || minutes == 8 || minutes == 9) //Añade 0 delante
            {
                showminutes = "0" + minutes;
            }
            else
            {
                showminutes = Convert.ToString(minutes);
            }
            if (hours == 0 || hours == 1 || hours == 2 || hours == 3 || hours == 4 || hours == 5 || hours == 6 || hours == 7 || hours == 8 || hours == 9) //Añade 0 delante
            {
                showhours = "0" + hours;
            }
            else
            {
                showhours = Convert.ToString(hours);
            }
            label2.Text = showhours + ":" + showminutes + ":" + showseconds; //Mostrar el tiempo que llevamos
        }
    }
}
