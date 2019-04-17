using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideLitt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho da Matriz");
            int t = int.Parse(Console.ReadLine());


            int[,] pyr = new int[t, t];


            int x = 0;
            int y = 1;

            int z = 1;

            while (pyr[(t - 1) / 2, (t - 1) / 2] == 0)
            {


                for (int i = 0; i < t; i++)
                {
                    for (int j = 0; j < t; j++)
                    {

                        if (pyr[i, j] == 0)
                        {

                            if (i == (x) || j == (x) || i == (t - y) || j == (t - y))
                            {

                                pyr[i, j] = z;

                            }

                        }


                    }

                }


                x++;
                y++;
                z++;
            }


            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    pyr[i, j] = pyr[i, j] - 1;
                }
            }




            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("{0} ", pyr[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
