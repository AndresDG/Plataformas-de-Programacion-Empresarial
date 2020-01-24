using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVentaDeBoleats
{
    public class Boleta
    {

        private List<Cliente> Datos_Cliente;
        private static int Costo_Domicilio = 5000;

        public Boleta(List<Cliente> datos_Cliente)
        {
            Datos_Cliente = datos_Cliente ?? throw new ArgumentNullException(nameof(datos_Cliente));
        }

        public List<Cliente> Datos_Cliente1 { get => Datos_Cliente; }
        public static int Costo_Domicilio1 { get => Costo_Domicilio; }

        
    }
}
