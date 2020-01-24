using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Concierto: Espectaculo
    {

        private string Nombre_Banda;

        public Concierto(string nombre_Banda, string nombre, DateTime fecha, DateTime hora, Ciudad ciudad, int duracion, string lugar, int capacidad_Max, string tipo_Espectaculo) : base
            (tipo_Espectaculo, nombre, fecha, hora, ciudad, duracion, lugar, capacidad_Max)
        {
            Nombre_Banda = nombre_Banda ?? throw new ArgumentNullException(nameof(nombre_Banda));
        }

        public string Nombre_Banda1 { get => Nombre_Banda; }
    }
}
