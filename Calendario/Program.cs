using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    class Program
    {
        static void Main(string[] args)
        {

            calendario fechas = new calendario(0, "", 0);
            CalendarioHAAB haab = new CalendarioHAAB(0, "", 0);
            Console.WriteLine(haab.convertir());
            Console.ReadKey();
        }
    }
    public class CalendarioHAAB
    {
        private int dia;
        private string mes;
        private int año;

        public CalendarioHAAB(int dia, string mes, int año)
        {
            this.dia = dia;
            this.mes = mes ?? throw new ArgumentNullException(nameof(mes));
            this.año = año;
        }

        public int Dia { get => dia; set => dia = value; }
        public string Mes { get => mes; set => mes = value; }
        public int Año { get => año; set => año = value; }

        public calendario convertir()
        {
            try
            {
                StreamReader archivo = new StreamReader("C:/Users/andre/source/repos/Calendario/bin/Debug/FechaHAAB.txt");
                string linea, NomDia = "";
                int contador = 0, dia2=0, diaAux = dia + 1, año= 0 ;
                while ((linea = archivo.ReadLine()) != null)
                {
                    string[] splt = (linea.Split(' '));
                    calendario fecha = new calendario(Convert.ToInt32(splt[0]), splt[1], Convert.ToInt32(splt[2]));

                    if (fecha.NombreDia.Equals("pop"))
                    {

                        if (fecha.Dia <= 13)
                        {
                            dia2 = diaAux;
                            NomDia = fecha.NomDia(fecha.Dia + 1);
                            año = 
                            contador++;
                        }
                        else
                        {
                            diaAux = fecha.Dia - 13;
                            dia2 = diaAux;
                            NomDia = fecha.NomDia(fecha.Dia + 1);
                            contador++;
                        }

                    }
                    else
                    {
                        fecha.Dia = fecha.Dia - 7;
                        if (fecha.Dia <= 13)
                        {
                            dia2 = diaAux;
                            NomDia = fecha.NomDia(fecha.Dia + 1);
                            contador++;
                        }
                        else
                        {
                            diaAux = fecha.Dia - 13;
                            dia2 = diaAux;
                            NomDia = fecha.NomDia(fecha.Dia + 1);
                            contador++;
                        }

                    }

                }

                return new calendario(dia2, NomDia, año);

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e);
            }
            return null;
        }
    }
    public class calendario
    {
        private int dia;
        private string nombreDia;
        private int año;

        public calendario(int dia, string nombreDia, int año)
        {
            this.Dia = dia;
            this.NombreDia = nombreDia ?? throw new ArgumentNullException(nameof(nombreDia));
            this.Año = año;
        }

        public int Dia { get => dia; set => dia = value; }
        public string NombreDia { get => nombreDia; set => nombreDia = value; }
        public int Año { get => año; set => año = value; }

        public string NomDia(int num)
        {
            switch (num)
            {
                case 1:
                    return "imix";
                    
                case 2:
                    return "ik";
                    
                case 3:
                    return "akbal";
                   
                case 4:
                    return "kan";
                    
                case 5:
                    return "chicchan";
                    
                case 6:
                    return "cimi";
                    
                case 7:
                    return "manik";
                    
                case 8:
                    return "lamat";
                    
                case 9:
                    return "muluk";
                    
                case 10:
                    return "ok";
                    
                case 11:
                    return "chuen";
                    
                case 12:
                    return "eb";
                    
                case 13:
                    return "ben";
                    
                case 14:
                    return "ix";
                    
                case 15:
                    return "mem";
                case 16:
                    return "cib";
                case 17:
                    return "caban";
                    
                case 18:
                    return "eznab";
                    
                case 19:
                    return "canac";
                    
                case 20:
                    return "ahau";
                    
            }

            return "";
        }
       

    }
}
