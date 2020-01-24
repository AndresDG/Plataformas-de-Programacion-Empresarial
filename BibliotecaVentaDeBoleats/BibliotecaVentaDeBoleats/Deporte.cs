using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Deporte: Espectaculo
    {

        private string equipo1;
        private string equipo2;

        public Deporte(string nombre, DateTime fecha, DateTime hora, Ciudad ciudad,int duracion, string lugar, int capacidad_Max, string tipo_Espectaculo) : base(tipo_Espectaculo, nombre, fecha, hora, ciudad,  duracion, lugar, capacidad_Max)
        {



        }

        public Deporte(string nombre, DateTime fecha, DateTime hora, Ciudad ciudad, int duracion, string lugar, int capacidad_Max, string tipo_Espectaculo, string equipo1, string equipo2) : base(tipo_Espectaculo, nombre, fecha, hora, ciudad, duracion, lugar, capacidad_Max)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }

        public string Equipo1 { get => equipo1; }
        public string Equipo2 { get => equipo2; }

    }
}
