using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            Console.WriteLine("De Volta Ao Início");
            ConsoleKeyInfo v = Console.ReadKey();
            if (v.Key == ConsoleKey.Enter)
                goto inicio;
        }
    }
}
