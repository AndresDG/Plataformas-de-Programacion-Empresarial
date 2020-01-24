using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Cliente
    {

        private string Nombre;
        private long Identificacion;
        private long Telefono;

        public Cliente(string nombre, long identificacion, long telefono)
        {
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Identificacion = identificacion;
            Telefono = telefono;
        }

        public string Nombre1 { get => Nombre; }
        public long Identificacion1 { get => Identificacion; }
        public long Telefono1 { get => Telefono; }

        public string infoCliente()
        {
            string imprimir = "";

            imprimir += Nombre;
            imprimir += Identificacion;
            imprimir += Telefono;

            return imprimir;
        }

    }
}
