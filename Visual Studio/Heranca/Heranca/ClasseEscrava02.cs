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

