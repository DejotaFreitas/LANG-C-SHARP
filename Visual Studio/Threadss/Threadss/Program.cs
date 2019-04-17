using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar Threads
            Thread t1 = new Thread(t01);
            Thread t2 = new Thread(t02);
            //Iniciar Threads
            t1.Start();
            t2.Start();

            Console.WriteLine("=======================");
            //Matar Threads
            Console.ReadKey();
            t1.Abort();
            t2.Abort();

        }
        //Metodos Staticos para colocar em uma Thread.
        public static void t01()
        {
            while (true)
            {
                Console.WriteLine("Hello World! 01");
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void t02()
        {
            while (true)
            {
                Console.WriteLine("Hello World! 02");
                System.Threading.Thread.Sleep(1250);
            }
        }
    }
}
