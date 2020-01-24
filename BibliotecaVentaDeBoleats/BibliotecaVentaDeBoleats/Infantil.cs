using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Infantil: Espectaculo
    {

        public Infantil(string nombre, DateTime fecha, DateTime hora, Ciudad ciudad, int duracion, string lugar, int capacidad_Max, string tipo_Espectaculo) : base
            (tipo_Espectaculo, nombre, fecha, hora, ciudad, duracion, lugar, capacidad_Max)
        {



        }

    }
}
