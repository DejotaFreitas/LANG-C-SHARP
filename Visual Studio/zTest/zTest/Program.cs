using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zTest
{
    class Program
    {
        enum nomeEnum : byte { enum01, enum02, enum03 };



        static void Main(string[] args)
        {
            Console.WriteLine("Escreve um numero de descubra os primos ate ele");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1, cont = 0; i<=num; i++)
            {
                for (int i2 = 1; i2 <= num; i2++)
                {
                    if (i % i2 == 0)
                        cont++;
                }
                if (cont<=2)
                    Console.WriteLine(i);
                cont = 0;
            }

        }

         

        

    }
}
