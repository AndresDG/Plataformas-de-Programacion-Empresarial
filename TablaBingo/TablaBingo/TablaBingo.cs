using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaBingo
{
    class TablaBingo
    {
        DataTable Tabla = new DataTable();

        public TablaBingo()
        {
            Tabla.Columns.Add("B");
            Tabla.Columns.Add("I");
            Tabla.Columns.Add("N");
            Tabla.Columns.Add("G");
            Tabla.Columns.Add("O");
        }

        public DataTable Tabla1 { get => Tabla; }

        public void Generar()
        {
            Tabla.Clear();
            Random r = new Random();
            int aux;
            for (int i=0; i<5; i++)
            {
                int min = 1, max = 15;
                DataRow fila = Tabla.NewRow();
                for(int j=0; j<5; j++)
                {
                    do
                    {
                        aux = r.Next(min, max + 1);
                    }while (Contains(i, j, aux));
                    fila[j] = aux;
                    min += 15;
                    max += 15;
                }
                if (i == 2) fila[i] = "UPB";
                Tabla.Rows.Add(fila);
            }
        }

        bool Contains(int pos,int col,int val)
        {
            
            for(int i=0; i<pos; i++)
            {
                if (Tabla.Rows[i][col].ToString().Equals(val+"")) return true;
            }
            return false;
        }
    }
}
