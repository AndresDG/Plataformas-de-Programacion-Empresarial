using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine;
using System.IO;

namespace Venta_de_Boletas_de_cine
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea1, linea2, director;
            string[] split;
            int contador1 = 0, contador2 = 0;
            bool cont = false;
            bool compra = false;
            List<Boleta> boletasC, boletasE;


            //Variables necesarias para vender las boletas

            string /*nombreUsuario = "",*/ tipoUsuario = "", tipoEntrada = "";
            int NroTarjeta = 0, cantidadSillas = 0; // SaldoTarjeta = 0, IdUsuario = 0, telefono = 0;
            
            Cliente Cesar = new Cliente(12345, 0, 1, "Cesar", 1234567890);
            
            Taquilla Taquilla1 = new Taquilla(new Taquillero(2, "Pedro", 1234543210, 123));
            Taquilla Taquilla2 = new Taquilla(new Taquillero(1, "Carlos", 0987654321, 321));
            List<Sala> Salas = new List<Sala>();
            List<Pelicula> peliculas = new List<Pelicula>();
            List<Cliente> clientes = new List<Cliente>();
            List<Director> directores = new List<Director>();
            directores.Add(new Director(1985, "Canada", 2, "Andres", 0981237645));

            StreamReader ArchPelicuals = new StreamReader("Peliculas.txt");
            StreamReader ArchSalas = new StreamReader("Salas.txt");

            int hora = 0;
            List<Funcion> Funciones = new List<Funcion>();


            try
            {

                

                while ((linea1 = ArchPelicuals.ReadLine()) != null)
                {

                    bool censura = false;
                    int NDirector = 0;
                    split = linea1.Split(',');
                    if (split[3].Equals("No")) censura = false;
                    if (split[3].Equals("Si")) censura = true;

                    foreach (Director i in directores)
                    {

                        
                        peliculas.Add(new Pelicula(split[0], split[1], directores[NDirector], split[2], censura, Convert.ToInt32(split[4])));
                        NDirector++;

                    }
                    

                }
                    
                

                while ((linea2 = ArchSalas.ReadLine()) != null)
                {

                    split = linea2.Split(',');
                    Salas.Add(new Sala(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2]), Convert.ToInt32(split[3])));

                }
                
                while(Funciones.Count() < 12)
                {

                    if (contador1 < 3)
                    {

                        Funciones.Add(new Funcion(DateTime.Now.AddHours(hora), peliculas[contador2], Salas[contador2])); //Hay error
                        contador1++;
                        hora += 4;
                    }
                    else
                    {
                        hora = 0;
                        contador2++;
                        contador1 = 0;
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.ReadKey();

            }
            Menu:
            try
                { 
                Taquilla.AgregarFunciones(Funciones);


                while (cont == false)
                {

                    /*Console.WriteLine("Ingrese el nombre del comprador");
                    nombreUsuario = Console.ReadLine();

                    Console.WriteLine("Ingrese la identificación del comprador");
                    IdUsuario = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el telefono del comprador");
                    telefono = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el tipo de comprador que es: " + "Cliente o Espectador");
                    tipoUsuario = Console.ReadLine();

                    Console.WriteLine("Ingrese el tipo de entrada que desea el comprador");
                    tipoEntrada = Console.ReadLine();*/

                    Console.WriteLine("Ingrese el tipo de comprador que es: " + "Cliente o Espectador");
                    tipoUsuario = Console.ReadLine();

                    if (tipoUsuario.ToUpper().Equals("CLIENTE"))
                    {

                        Console.WriteLine("Ingrese el número de la tarjeta del cliente");
                        NroTarjeta = Convert.ToInt32(Console.ReadLine());

                        //Se debe pedir el saldo de la tarjeta?

                        //clientes.Add(new Cliente(NroTarjeta, 0, IdUsuario, nombreUsuario, telefono));

                        if (Cesar.Nro_Tarjeta1 == NroTarjeta)
                        {

                            while (compra == false)
                            {

                                /*if (tipoUsuario.ToUpper().Equals("Cliente"))
                                {*/
                                    //Controlar si es la primera vez que va a comprar con la tarjeta
                                    int opcion = 0;

                                    Console.WriteLine("Menu: " + "\n"
                                                        + "1). Consultar saldo" + "\n"
                                                        + "2). Recargar la tarjeta" + "\n"
                                                        + "3). Comprar boleta" + "\n"
                                                        + "4). Salir" + "\n");
                                    opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (opcion)
                                    {

                                        case 1:

                                            Console.WriteLine("El saldo de la tarjeta es: " + "\n");
                                            Console.WriteLine(Taquilla1.saldoTarjeta(Cesar));
                                            Console.ReadKey();

                                            break;


                                        case 2:

                                            float recarga;
                                            Console.WriteLine("Ingrese la cantidad que desea recargar en la tarjeta de: " + Cesar.Nombre_Personas);
                                            recarga = (float)Convert.ToDouble(Console.ReadLine());

                                            if (Taquilla1.RecargarTarjeta(Cesar, recarga) == true) Console.WriteLine("\n" + "Recarga exitosa");
                                            else
                                            {

                                                Console.WriteLine("\n" + "No se pudo efectuar la recarga" );

                                            }

                                            break;

                                        case 3:

                                            int x = 0;
                                            string sillas = "";

                                            Console.WriteLine("\n" + "Elija la función que desea ver:" + "\n" + Taquilla1.ImprimirFuncionesTaquilla());
                                            x = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("\n" + "Sillas " + "\n" + Taquilla1.SillasFuncion(x));

                                            Console.WriteLine("\n" + "Ingrese el tipo de entrada que desea el comprador");
                                            tipoEntrada = Console.ReadLine();

                                            Console.WriteLine("\n" + "Cuantas sillas desea?");
                                            cantidadSillas = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("\n" + "Ingrese la posicion de la silla que desea separadas por ',' y las sillas separadas por '-'");
                                            sillas = Console.ReadLine();

                                            

                                            if (x > 0 && tipoEntrada != null && cantidadSillas > 0 && sillas != null)
                                            {

                                                boletasC = Taquilla1.venderBoletaCliente(Cesar, tipoEntrada, cantidadSillas, sillas, Funciones[x]);

                                                Console.WriteLine("Desea saber más a cerca del Director? " + "Y/N");
                                                director = Console.ReadLine();

                                                if (director.ToUpper().Equals("Y"))
                                                {
                                                    
                                                    int Ndirector = 0;
                                                    foreach (Pelicula i in peliculas)
                                                    {

                                                        if (Convert.ToString(directores[Ndirector])[0].Equals(director))
                                                        {

                                                            Console.WriteLine(Taquilla1.consultarDirector(directores[Ndirector]));
                                                            

                                                        }

                                                    }

                                                }
                                                
                                                Console.ReadKey();
                                                Console.Clear();

                                                foreach (Boleta i in boletasC)
                                                {

                                                    Console.WriteLine(i.imprimirBoleta() + "\n");
                                                    Console.ReadKey();
                                                    Console.Clear();

                                                }

                                            }
                                            else
                                            {

                                                Console.WriteLine("No se pudo comprar la boleta porque los datos no son correctos");

                                            }


                                            


                                            break;


                                        case 4:

                                            string salir = "";

                                            Console.WriteLine("Desea salir? " + "Y/N");
                                            salir = Console.ReadLine();

                                            if (salir.Equals("Y"))
                                            {

                                                compra = true;

                                            }
                                            else
                                            {

                                                compra = false;

                                            }

                                            break;


                                    }

                                /*}
                                else
                                {



                                }*/

                            }

                        }
                        else
                        {

                            Console.WriteLine("El cliente no está registrado");

                        }

                    }
                    else
                    {

                        if (tipoUsuario.ToUpper().Equals("ESPECTADOR"))
                        {

                            int x = 0;
                            string sillas = "";

                            Console.WriteLine("Elija la función que desea ver:" + "\n" + Taquilla1.ImprimirFuncionesTaquilla());
                            x = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Sillas " + "\n" + Taquilla1.SillasFuncion(x));

                            Console.WriteLine("Ingrese el tipo de entrada que desea el comprador");
                            tipoEntrada = Console.ReadLine();

                            Console.WriteLine("Cuantas sillas desea?");
                            cantidadSillas = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese la posicion de la silla que desea separadas por ',' y las sillas separadas por '-'");
                            sillas = Console.ReadLine();

                            if (x > 0 && tipoEntrada != null && cantidadSillas > 0 && sillas != null)
                            {

                                boletasE = Taquilla2.venderBoletaEspectador(tipoEntrada, cantidadSillas, sillas, Funciones[x]);
                                Console.ReadKey();
                                
                                Console.Clear();

                                foreach (Boleta i in boletasE)
                                {

                                    Console.WriteLine(i.imprimirBoleta() + "\n");
                                    Console.ReadKey();
                                    Console.Clear();

                                }

                            }
                            else
                            {

                                Console.WriteLine("No se pudo comprar la boleta porque los datos no son correctos" + "\n");

                            }


                        }

                    }

                    string cerrarP = "";
                    Console.WriteLine("Desea cerrar el programa?" + "Y/N");
                    cerrarP = Console.ReadLine();

                    if (cerrarP.ToUpper().Equals("Y"))
                    {

                        cont = true;

                    }
                    else
                    {

                        cont = false;
                        Console.Clear();

                    }


                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();
                Console.Clear();
                goto Menu;

            }
        }
    }
}
