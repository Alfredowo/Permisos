using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Usuarios
    {
        public Usuarios(int id, string nombre, string apellidop, string apellidom, string aFecha, string rfc)
        {
            Id = id;
            Nombre = nombre;
            Apellidop = apellidop;
            Apellidom = apellidom;
            AFecha = aFecha;
            Rfc = rfc;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string AFecha { get; set; }
        public string Rfc { get; set; }
    }
}
