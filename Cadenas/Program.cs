using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            cadena cadena = new cadena();
            Console.WriteLine(Convert.ToString(cadena.compare("AHSUEORLJA", "HOLA")));
            Console.ReadKey();
        }
    }

    class cadena
    {
        private string cadenaArray;

        public cadena()
        {
           
        }

        public string CadenaArray { get => cadenaArray; set => cadenaArray = value; }

        public int compare(string cadComp, string palabra)
        {
            string[] CadComp = new string[cadComp.Length];
            string[] Palabra = new string[palabra.Length];
            string pal = "",pal2 = "", palR = "";
            

            for (int i = 0; i < cadComp.Length; i++)
            {
                CadComp[i] = cadComp.ToCharArray().ToString();
            }
            for (int i = 0; i < palabra.Length; i++)
            {
                Palabra[i] = palabra.ToCharArray().ToString();
            }
            int contiene = cadComp.IndexOf(palabra);
            if (contiene != -1)
            {
                return 1;
            }
            else {
                
                for (int i = 0; i < Palabra.Length; i++)
                {
                    for (int j = 0; j < CadComp.Length; j++)
                    {
                        if (CadComp[j].Equals(Palabra[i]))
                        {
                            pal += CadComp[i];
                            
                        }
                    }
                }
                if (palabra.Equals(pal))
                {
                    return 2;
                }
                else
                {
                    
                    for (int j = CadComp.Length-1; j >= 0; j--)
                    {
                        pal2 += CadComp[j];
                    }
                    for (int j = Palabra.Length - 1; j >= 0; j--)
                    {
                        palR += Palabra[j];
                    }
                    if (pal2.Equals(palR))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
           
            return 0;
        }
    }
}
