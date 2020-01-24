using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Conferencia: Espectaculo
    {

        private string Nombre_Conferencista;

        public Conferencia(string nombre_Conferencista, string nombre, DateTime fecha, DateTime hora, Ciudad ciudad, int duracion, string lugar, int capacidad_Max, string tipo_Espectaculo) : base(tipo_Espectaculo, nombre, fecha, hora, ciudad, duracion, lugar, capacidad_Max)
        {
            Nombre_Conferencista = nombre_Conferencista ?? throw new ArgumentNullException(nameof(nombre_Conferencista));
        }

        public string Nombre_Conferencista1 { get => Nombre_Conferencista; set => Nombre_Conferencista = value; }
    }
}
