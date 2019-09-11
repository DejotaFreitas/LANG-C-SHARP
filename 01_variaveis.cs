using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            //Tipos de Variaveis.
            lista.Add("==========Tipos de Variaveis===========");
            lista.Add("=======================================");
            bool b = true; // 1 byte memoria.
            lista.Add("bool");
            lista.Add("false");
            lista.Add("true");
            lista.Add("1 byte memoria");
            lista.Add("=======================================");

            byte bb = 255; // 1 byte memoria.
            lista.Add("byte");
            lista.Add(Convert.ToString(byte.MinValue));
            lista.Add(Convert.ToString(byte.MaxValue));
            lista.Add("1 byte memoria");
            lista.Add("=======================================");

            sbyte sb = 127; // 1 byte memoria.
            lista.Add("sbyte");
            lista.Add(Convert.ToString(sbyte.MinValue));
            lista.Add(Convert.ToString(sbyte.MaxValue));
            lista.Add("1 byte memoria");
            lista.Add("=======================================");

            Int16 i16 = 32767; // 2 bytes memoria
            lista.Add("Int16 /ou short");
            lista.Add(Convert.ToString(Int16.MinValue));
            lista.Add(Convert.ToString(Int16.MaxValue));
            lista.Add("2 byte memoria");
            lista.Add("=======================================");

            Int32 i32 = 2147483647; // 4 bytes memoria
            lista.Add("Int32 /ou int");
            lista.Add(Convert.ToString(Int32.MinValue));
            lista.Add(Convert.ToString(Int32.MaxValue));
            lista.Add("4 byte memoria");
            lista.Add("=======================================");

            Int64 i64 = 9223372036854775807; // 8 bytes memoria
            lista.Add("Int64 /ou long");
            lista.Add(Convert.ToString(Int64.MinValue));
            lista.Add(Convert.ToString(Int64.MaxValue));
            lista.Add("8 byte memoria");
            lista.Add("=======================================");

            UInt16 ui16 = 214; // 2 Bytes memoria
            lista.Add("UInt16 /ou ushort");
            lista.Add(Convert.ToString(UInt16.MinValue));
            lista.Add(Convert.ToString(UInt16.MaxValue));
            lista.Add("2 byte memoria");
            lista.Add("=======================================");

            UInt32 ui32 = 2147483647; // 4 Bytes memoria
            lista.Add("UInt32 /ou uint");
            lista.Add(Convert.ToString(UInt32.MinValue));
            lista.Add(Convert.ToString(UInt32.MaxValue));
            lista.Add("4 byte memoria");
            lista.Add("=======================================");

            UInt64 ui64 = 2147483647; // 8 Bytes memoria
            lista.Add("UInt64 /ou ulong");
            lista.Add(Convert.ToString(UInt64.MinValue));
            lista.Add(Convert.ToString(UInt64.MaxValue));
            lista.Add("8 byte memoria");
            lista.Add("=======================================");


            short s = 32767; // 2 bytes memoria.
            lista.Add("short");
            lista.Add(Convert.ToString(short.MinValue));
            lista.Add(Convert.ToString(short.MaxValue));
            lista.Add("2 byte memoria");
            lista.Add("=======================================");

            ushort us = 65535; // 2 bytes memoria.
            lista.Add("ushort");
            lista.Add(Convert.ToString(ushort.MinValue));
            lista.Add(Convert.ToString(ushort.MaxValue));
            lista.Add("2 byte memoria");
            lista.Add("=======================================");

            int i = 2147483647; // 4 bytes memoria
            lista.Add("int");
            lista.Add(Convert.ToString(int.MinValue));
            lista.Add(Convert.ToString(int.MaxValue));
            lista.Add("4 byte memoria");
            lista.Add("=======================================");

            uint ui = 4294967295; // 4 bytes memoria
            lista.Add("uint");
            lista.Add(Convert.ToString(uint.MinValue));
            lista.Add(Convert.ToString(uint.MaxValue));
            lista.Add("4 byte memoria");
            lista.Add("=======================================");

            float f = 1.1234567f; // 7 digitos de precisão. // 4 bytes memoria
            lista.Add("float");
            lista.Add(Convert.ToString(float.MinValue));
            lista.Add(Convert.ToString(float.MaxValue));
            lista.Add("4 byte memoria");
            lista.Add("=======================================");

            long l = 9223372036854775807; // 8 bytes de memoria.
            lista.Add("long");
            lista.Add(Convert.ToString(long.MinValue));
            lista.Add(Convert.ToString(long.MaxValue));
            lista.Add("8 byte memoria");
            lista.Add("=======================================");

            ulong ul = 18446744073709551615; // 8 bytes de memoria.
            lista.Add("ulong");
            lista.Add(Convert.ToString(ulong.MinValue));
            lista.Add(Convert.ToString(ulong.MaxValue));
            lista.Add("8 byte memoria");
            lista.Add("=======================================");

            double d = 3.1234567890123345; // 15-16 digitos de precisão. // 8 bytes de memoria.
            lista.Add("double");
            lista.Add(Convert.ToString(double.MinValue));
            lista.Add(Convert.ToString(double.MaxValue));
            lista.Add("15-16 digitos de precisão");
            lista.Add("8 byte memoria");
            lista.Add("=======================================");

            decimal dm = 9999999999999999999999999999m; // 28-29 digitos de precisão. // 16 bytes memorias;
            lista.Add("decimal");
            lista.Add(Convert.ToString(decimal.MinValue));
            lista.Add(Convert.ToString(decimal.MaxValue));
            lista.Add("28-29 digitos de precisão");
            lista.Add("16 byte memoria");
            lista.Add("=======================================");

            char c = 'c'; // um caracter entre aspas simples 'a'; // 2 bytes memoria.
            lista.Add("char");
            lista.Add("1 Caracter");
            lista.Add("Escrito entre aspas simples ex: 'c'");
            lista.Add("2 byte memoria");
            lista.Add("=======================================");

            //variavel sencitiva.
            var v0 = 0;
            var v1 = 3.5;
            var v2 = 'v';
            var v4 = "sddasd";

            lista.Add("var");
            lista.Add("Assume o tipo de variável dependendo do valor atribuido a ela.");
            lista.Add("Depois que assume um tipo, não pode assumir outro tipo.");
            lista.Add("=======================================");

            //Pegando conteudo adicionado no array e escrevendo em um arquivo de texto.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\zzTI\000 Dejota\C#\Variaveis.txt"))

                foreach (string line in lista)
                {
                    file.WriteLine(line);
                }
            Console.WriteLine("Deu Certo");
            Console.ReadKey();
        }
    }
}
