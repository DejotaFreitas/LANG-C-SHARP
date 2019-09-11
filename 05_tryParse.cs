using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

        inicio:
            Console.WriteLine("Escreva um numero inteiro");
            string numString = Console.ReadLine();
            int num;

            //verifica se pode transforma a string em numero e se possivel ela tranforma.
            bool result = int.TryParse(numString, out num);

            if (result)
            { //(result == true)
                Console.WriteLine("Conversão de String para Inteiro foi perfeita");
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("numero escrito inválido, tente novamente");
                goto inicio;
            }


            Console.ReadKey();
        }
    }
}
