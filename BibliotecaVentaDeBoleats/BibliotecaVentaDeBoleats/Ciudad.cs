using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Ciudad
    {

        private string NombreCiudad;

        public Ciudad(string nombreCiudad)
        {
            NombreCiudad = nombreCiudad ?? throw new ArgumentNullException(nameof(nombreCiudad));
        }

        public string NombreCiudad1 { get => NombreCiudad; }
    }
}
