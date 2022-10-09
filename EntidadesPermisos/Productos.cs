using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Productos
    {
        public Productos(int codigo, string nombre, string descripcion, string marca)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
