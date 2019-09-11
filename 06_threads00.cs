using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsAulas
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(t01).Start();
        }
        public static void t01()
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                System.Threading.Thread.Sleep(2000);
            }
        }

        public static void t02()
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                System.Threading.Thread.Sleep(1500);
            }

        }
    }
}
