using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPalindroma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string numero;
                Console.WriteLine("Ingrese un numero");
                numero = Console.ReadLine();
                Console.WriteLine();

                //string[] splt = (numero.Split());

                Numero num = new Numero(numero);

                num.palindrome();

                Console.ReadKey();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
        }

        public class Numero
        {
            private string CadenaNumeros;

            public Numero(string num)
            {
                CadenaNumeros = num;
            }
            public string CadenaNumeros1 { get => CadenaNumeros; set => CadenaNumeros = value; }

            public string palindrome()
            {

                Console.Write(CadenaNumeros + " - ");

                for (int i = CadenaNumeros.Length - 1; i >= 0; i--)
                {

                    Console.Write(CadenaNumeros[i]);

                }

                return "";

            }

        }
    }
}
