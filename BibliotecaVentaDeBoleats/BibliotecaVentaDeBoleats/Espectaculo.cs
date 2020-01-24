using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Espectaculo
    {

        protected string tipo_Espectaculo;
        protected string nombre;
        protected DateTime fecha;
        protected DateTime hora;
        protected Ciudad ciudad;
        protected int duracion;
        protected string lugar;
        protected int capacidad_Max;
        

        public Espectaculo(string tipo_Espectaculo, string nombre, DateTime fecha, DateTime hora, Ciudad ciudad, int duracion, string lugar, int capacidad_Max)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.fecha = fecha;
            this.hora = hora;
            this.ciudad = ciudad ?? throw new ArgumentNullException(nameof(ciudad));
            this.duracion = duracion;
            this.lugar = lugar ?? throw new ArgumentNullException(nameof(lugar));
            this.capacidad_Max = capacidad_Max;
            this.tipo_Espectaculo = tipo_Espectaculo ?? throw new ArgumentNullException(nameof(tipo_Espectaculo));
        }

        public string Nombre { get => nombre; }
        public DateTime Fecha { get => fecha; }
        public DateTime Hora { get => hora; }
        public Ciudad Ciudad { get => ciudad; }
        public int Duracion { get => duracion; }
        public string Lugar { get => lugar; }
        public int Capacidad_Max { get => capacidad_Max; }
        public string Tipo_Espectaculo { get => tipo_Espectaculo; }
    }
}
