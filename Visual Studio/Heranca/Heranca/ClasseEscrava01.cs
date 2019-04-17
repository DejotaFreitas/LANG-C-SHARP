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

