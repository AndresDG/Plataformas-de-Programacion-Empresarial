using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NrosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Primo primo = new Primo();
            Console.WriteLine("Ingrese la posicion del numero primo que desea conocer");
            int posi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + "El numero primo en la posicion " + posi +" es: ");

            Console.WriteLine(primo.NroPrimo(posi));


            Console.ReadKey();
            
        }
    }
}
