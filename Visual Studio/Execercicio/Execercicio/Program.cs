using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                list.Add("-");
            }
            foreach (object x in list)
            Console.Write("{0}",x);

            Console.ReadKey();
             
        }
    }
}
