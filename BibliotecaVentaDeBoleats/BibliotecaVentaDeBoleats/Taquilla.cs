using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BibliotecaVentaDeBoleats
{
    public class Taquilla
    {

        private Ciudad ciudad;
        private string Lugar;
        private int Nro_Boletas_Cliente;
        private static float Costo_Manejo = 0.8F;
        

        public Taquilla(Ciudad ciudad, string lugar, int nro_Boletas_Cliente)
        {
            this.ciudad = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            Lugar = lugar ?? throw new ArgumentNullException(nameof(lugar));
            Nro_Boletas_Cliente = nro_Boletas_Cliente;
        }

        public Ciudad Ciudad { get => ciudad; }
        public string Lugar1 { get => Lugar; }
        public int Nro_Boletas_Cliente1 { get => Nro_Boletas_Cliente; }
        public static float Costo_Manejo1 { get => Costo_Manejo; }
        

        public void Reservar(Cliente cliente, int NroBoletas, string TipoEvento, string Evento, DateTime fecha, string lugar, DateTime hora)
        {

            StreamWriter Reservar = new StreamWriter("Reservas.txt");

            if (NroBoletas > 0 && NroBoletas < 6)
            {

                Reservar.WriteLine(cliente.Nombre1 + "," + cliente.Identificacion1 + "," + cliente.Telefono1 + "," + TipoEvento + "," + Evento + "," + fecha + "," + lugar + "," + hora + "," + NroBoletas + "," + DateTime.Now, true);


            }

        }

        public void Comprar(Cliente cliente, int NroBoletas, string TipoEvento, string Evento)
        {

            StreamWriter Comprar = new StreamWriter(cliente.Nombre1 + "-" + cliente.Identificacion1 + "-" + Evento + "-" + "Boleta.txt" );
            int i = 0;

            if (NroBoletas > 0 && NroBoletas < 6)
            {

                while (i <= 5)
                {

                    Comprar.WriteLine(cliente.Nombre1 + "\n" + cliente.Identificacion1 + "\n" + cliente.Telefono1 + "\n" + TipoEvento + "\n" + Evento + "\n" + NroBoletas, true);
                    i++;

                }


            }
        }


        public void Registrar(Cliente cliente)
        {

            StreamWriter Registrar = new StreamWriter("Clientes.txt");

            Registrar.WriteLine(cliente.Nombre1 + "," + cliente.Identificacion1 + "," + cliente.Telefono1);


        }

    }
}
