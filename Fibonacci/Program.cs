
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, limite, i, auxiliar;
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            int[] fibo = new int[limite];
            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                fibo[i] = a;
            }
            for (int j = limite-1; j >= 0; j--)
            {
                Console.WriteLine(fibo[j]);            
            }
            Console.ReadKey();
        }
    }
}
