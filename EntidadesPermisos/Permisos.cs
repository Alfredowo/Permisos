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
            FkUsuario = usuario;
            FkModulo = modulo;
            Lectura = lectura;
            Escritura = escritura;
            Actualizar = actualizar;
            Eliminar = eliminar;
        }

        public int FkUsuario { get; set; }
        public int FkModulo { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
    }
}
