using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Exposicion: Espectaculo
    {
        private string Nombre_Expositor;
        private string Nombre_Obra;

        public Exposicion(string nombre_Expositor, string nombre_Obra, string nombre, DateTime fecha, DateTime hora, Ciudad ciudad, int duracion, string lugar, int capacidad_Max, string tipo_Espectaculo) : base(tipo_Espectaculo, nombre, fecha, hora, ciudad, duracion, lugar, capacidad_Max)
        {
            Nombre_Expositor = nombre_Expositor ?? throw new ArgumentNullException(nameof(nombre_Expositor));
            Nombre_Obra = nombre_Obra ?? throw new ArgumentNullException(nameof(nombre_Obra));
        }

        public string Nombre_Expositor1 {get => Nombre_Expositor; }


        public string Nombre_Obra1 { get => Nombre_Obra; }

    }
}
