using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadss2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bt = true;
            Thread t1 = new Thread(() => { while (bt) { Thread.Sleep(500); Console.WriteLine("t1"); } });
            t1.Start();

            Thread t2 = new Thread(() => { while (bt) { Thread.Sleep(600); Console.WriteLine("t2"); } });
            t2.Start();

            Console.ReadKey();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("t1 " + (t1.IsAlive == true ? "Viva" : "Morta"));
                Console.WriteLine("t2 " + (t2.IsAlive == true ? "Viva" : "Morta"));
                bt = false;
                System.Threading.Thread.Sleep(500);
            }


            //Join() espera a thread terminar a execução.
            t1.Join();
            Console.WriteLine("t1.Join() returned.");

            t2.Join();
            Console.WriteLine("t2.Join() returned.");

            Console.ReadKey();
        }
    }
}
