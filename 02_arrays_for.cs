using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            //Array e for
            //==================================\\

            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add(1.1);
            lista.Add('a');
            lista.Add("Array List é fodão!!!");

            foreach (var x in lista)
                Console.WriteLine(x);

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);

            Console.WriteLine("===========================");
            //==================================\\

            int[] vetor = new int[3];

            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine(vetor[i]);

            Console.WriteLine("===========================");
            //==================================\\

            int[,] vetorb = new int[2, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    vetorb[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(vetorb[i, j]);

            Console.WriteLine("===========================");

            //==================================\\

            int[,,] vetort = new int[2, 2, 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int h = 0; h < 2; h++)
                        vetort[i, j, h] = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int h = 0; h < 2; h++)
                        Console.WriteLine(vetort[i, j, h]);

            //==================================\\
            Console.ReadKey();
        }
    }
}
