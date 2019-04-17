using System;

namespace MetodosGetSet
{
    class Program
    {
            public static void Main(string[] args)
            {
               MetodoGetSet m = new MetodoGetSet();
                Console.WriteLine(m.idadeGetSet);
                Console.WriteLine(m.nomeGetSet);

                m.idadeGetSet = 100;
                m.nomeGetSet = "Xuxa";

                Console.WriteLine(m.idadeGetSet);
                Console.WriteLine(m.nomeGetSet);

                Console.ReadKey();
            }
        }
//================classe Pivada Get Set =======================
                public class MetodoGetSet
                {
                    private int idade = 10;
                    private string nome = "kkkkkkk";

                    public int idadeGetSet
                    {
                        get { return idade; }
                        set { idade = value; }
                    }

                    public string nomeGetSet
                    {
                        get { return nome; }
                        set { nome = value; }
                    }


    }
}