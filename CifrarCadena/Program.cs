using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifrarCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string cad = Console.ReadLine();
            Cadena cadena = new Cadena(cad);
            string[] datos = cadena.datos(a,b);
            cadenaCifrada CadenaCifrada = new cadenaCifrada(datos[0],datos[1],datos[2]);
            Console.WriteLine(CadenaCifrada.cifrar());
            Console.ReadKey();
        }
    }
    class Cadena
    {
        private string cad;

        public Cadena(string cad)
        {
            this.cad = cad ?? throw new ArgumentNullException(nameof(cad));
        }

        public string Cad { get => cad; set => cad = value; }

        public string[] datos(string a, string b)
        {
            string[] data = new string[3];

            data[0] = a;
            data[1] = b;
            data[2] = this.cad;

            return data;
        }
    }
    class cadenaCifrada
    {
        private string a;
        private string b;
        private string cadC;

        public cadenaCifrada(string a, string b, string cadC)
        {
            this.a = a ?? throw new ArgumentNullException(nameof(a));
            this.b = b ?? throw new ArgumentNullException(nameof(b));
            this.cadC = cadC ?? throw new ArgumentNullException(nameof(cadC));
        }

        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string CadC { get => cadC; set => cadC = value; }

        public string cifrar()
        {
            char a1 = Convert.ToChar(this.a);
            char a2 = Convert.ToChar(this.b);
            int  diferencia = a1-a2;

            for (int i = 0; i < cadC.Length; i++)
            {
                this.CadC += Convert.ToString(Convert.ToChar(cadC[i]) + diferencia);
            }

            return this.cadC.ToString();
        }
    }
}
