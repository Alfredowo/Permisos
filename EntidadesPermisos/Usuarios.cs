using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Usuarios
    {
        public Usuarios(int id, string nombre, string apellidop, string apellidom, string fecha, string rfc, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Apellidop = apellidop;
            Apellidom = apellidom;
            Fecha = fecha;
            Rfc = rfc;
            Contraseña = contraseña;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string Fecha { get; set; }
        public string Rfc { get; set; }
        public string Contraseña { get; set; }
    }
}
