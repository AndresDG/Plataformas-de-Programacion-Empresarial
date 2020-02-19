using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Romano numRomano = new Romano();
                Console.WriteLine("Ingrese el numero que desea convertir\n" + "(Del 1 al 100)\n");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numRomano.convertir(n) + "\n");
                while (n > 0 && n < 101)
                {
                    n = 0;
                    Console.WriteLine("Ingrese el numero que desea convertir\n" + "(Del 1 al 100)\n");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numRomano.convertir(n) + "\n");

                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }

    class Romano
    {
        private string numRomano;

        public Romano()
        {
            this.numRomano = "";
        }

        
        public string NumRomano { get => numRomano; set => numRomano = value; }


        public string convertir(int num)
        {
            try
            {
                this.numRomano = "";
                string[] decimas = new string[10] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
                int decenas, unidades;
                decenas = (num / 10) % 10;
                unidades = num % 10;
                if (num == 100)
                {
                    this.numRomano = decimas[9];
                    return this.numRomano;
                }
                while (num > 0 && num < 100)
                {


                    if (num > 10)
                    {

                        this.numRomano = decimas[decenas - 1];
                        num = num - (10 * decenas);

                    }
                    if (num < 10)
                    {

                        switch (unidades)
                        {
                            case 1:
                                this.numRomano += "I";
                                return this.numRomano;

                            case 2:
                                this.numRomano += "II";
                                return this.numRomano;

                            case 3:
                                this.numRomano += "III";
                                return this.numRomano;

                            case 4:
                                this.numRomano += "IV";
                                return this.numRomano;

                            case 5:
                                this.numRomano += "V";
                                return this.numRomano;

                            case 6:
                                this.numRomano += "VI";
                                return this.numRomano;

                            case 7:
                                this.numRomano += "VII";
                                return this.numRomano;

                            case 8:
                                this.numRomano += "VIII";
                                return this.numRomano;

                            case 9:
                                this.numRomano += "IX";
                                return this.numRomano;

                        }

                    }


                }


                return this.numRomano;
            }
            catch (Exception e)
            {
                return Convert.ToString(e);
            }
        }

    }
}
