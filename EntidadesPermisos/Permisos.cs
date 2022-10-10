using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class Permisos
    {
        public Permisos(int usuario, int modulo, bool lectura, bool escritura, bool actualizar, bool eliminar)
        {
            Usuario = usuario;
            Modulo = modulo;
            Lectura = lectura;
            Escritura = escritura;
            Actualizar = actualizar;
            Eliminar = eliminar;
        }

        public int Usuario { get; set; }
        public int Modulo { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
    }
}
