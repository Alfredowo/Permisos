using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Herramientas
    {
        public Herramientas(int codigo, string nombre, string descripcion, string marca, int medida)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
            this.medida = medida;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int medida { get; set; }
    }
}
