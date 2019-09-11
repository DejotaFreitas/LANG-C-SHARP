using System;

namespace Heranca
{
	public abstract class SuperClasse
	{
		public int numero;
		public string nome;

		abstract public void exibir();

	}
}

//==========================================================================
using System;

namespace Heranca
{
	public class ClasseEscrava00 : SuperClasse
	{
        public override void exibir()
        {
            Console.WriteLine("===========ClasseEscrava00===========");
            Console.WriteLine(nome);
            Console.WriteLine(numero);
            Console.WriteLine("======================");
        }

    }
}

//==========================================================================
using System;

namespace Heranca
{
	public class ClasseEscrava01 : ClasseEscrava00
	{
		public string nomeEscravo;
		public int numeroEscravo;

        public override void exibir()
        {
            Console.WriteLine("==========ClasseEscrava01============");
            Console.WriteLine(nome);
			Console.WriteLine(numero);
			Console.WriteLine(nomeEscravo);
			Console.WriteLine(numeroEscravo);
			Console.WriteLine("======================");
		}


	}
}


//==========================================================================
using System;

namespace Heranca
{
	public class ClasseEscrava02 : ClasseEscrava01
	{
		public string nomeEscravo02;
		public int numeroEscravo02;

        public override void exibir()
        {
            Console.WriteLine("===========ClasseEscrava02===========");
            Console.WriteLine(nome);
			Console.WriteLine(numero);
			Console.WriteLine(nomeEscravo);
			Console.WriteLine(numeroEscravo);
			Console.WriteLine(nomeEscravo02);
			Console.WriteLine(numeroEscravo02);
			Console.WriteLine("======================");
		}


	}
}

//==========================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseEscrava00 s0 = new ClasseEscrava00();
            s0.nome = "nome";
            s0.numero = 00;
            s0.exibir();

            ClasseEscrava01 s1 = new ClasseEscrava01();
            s1.nome = "nome";
            s1.numero = 00;
            s1.nomeEscravo = "nome1";
            s1.numeroEscravo = 01;
            s1.exibir();

            ClasseEscrava02 s2 = new ClasseEscrava02();
            s2.nome = "nome";
            s2.numero = 00;
            s2.nomeEscravo = "nome1";
            s2.numeroEscravo = 01;
            s2.nomeEscravo02 = "nome2";
            s2.numeroEscravo02 = 02;
            s2.exibir();

            SuperClasse[] array = { s0, s1, s2 };

            for (int i = 0; i < array.Length; i++)
                array[i].exibir();



            Console.ReadKey();
        }
    }
}
