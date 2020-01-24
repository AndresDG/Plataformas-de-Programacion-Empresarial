using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BibliotecaVentaDeBoleats
{
    public class Reserva
    {

        private DateTime Tiempo_Reserva;
        private Cliente cliente;
        private string TipoEvento;
        private string nombreEvento;
        private DateTime Fecha;
        private string Lugar;
        private DateTime Hora;
        private int NroBoletas;
        private List<Reserva> reservas = new List<Reserva>();

        public Reserva()
        {
        }

        public Reserva(DateTime tiempo_Reserva, Cliente cliente, string tipoEvento, string nombreEvento, DateTime fecha, string lugar, DateTime hora, int nroBoletas)
        {
            Tiempo_Reserva = tiempo_Reserva;
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            TipoEvento = tipoEvento ?? throw new ArgumentNullException(nameof(tipoEvento));
            this.nombreEvento = nombreEvento ?? throw new ArgumentNullException(nameof(nombreEvento));
            Fecha = fecha;
            Lugar = lugar ?? throw new ArgumentNullException(nameof(lugar));
            Hora = hora;
            NroBoletas = nroBoletas;
        }

        public DateTime Tiempo_Reserva1 { get => Tiempo_Reserva; }
        public Cliente Cliente1 { get => cliente; }
        public string TipoEvento1 { get => TipoEvento; }
        public string NombreEvento { get => nombreEvento; }
        public DateTime Fecha1 { get => Fecha; }
        public string Lugar1 { get => Lugar; }
        public DateTime Hora1 { get => Hora; }
        public int NroBoletas1 { get => NroBoletas; }

        
        public bool infoReserva(string Nombre, string identificación, long Telefono)
        {
            string Linea;
            bool imprimir = false;
            StreamReader archivo = new StreamReader("Reservas.txt");

            while ((Linea = archivo.ReadLine()) != null)
            {

                string[] splt,spltFecha;

                splt = Linea.Split(',');
                
                Cliente clienteReserva = new Cliente(splt[1],Convert.ToInt64(splt[2]),Convert.ToInt64(splt[3]));
                spltFecha = splt[6].Split('/');
                DateTime fecha = new DateTime(Convert.ToInt32(spltFecha[2]),Convert.ToInt32(spltFecha[1]),Convert.ToInt32(spltFecha[0]));
                Reserva reserva = new Reserva(Convert.ToDateTime(splt[0]),clienteReserva,splt[4],splt[5],fecha,splt[7],Convert.ToDateTime(splt[8]),Convert.ToInt32(splt[9]));
                reservas.Add(reserva);

                

            }
            foreach (Reserva i in reservas)
            {

                if ((i.Cliente1.Nombre1.Equals(Nombre)) && (i.Cliente1.Identificacion1.Equals(identificación)) && (i.Cliente1.Telefono1.Equals(Convert.ToInt64(Telefono))))
                {

                    imprimir = true;

                }

            }

            return imprimir;
        }

    }
}
