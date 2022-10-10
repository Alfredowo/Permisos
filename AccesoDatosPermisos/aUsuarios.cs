using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesPermisos;

namespace AccesoDatosPermisos
{
    public class aUsuarios
    {
        Base b = new Base("localhost", "root", "", "permisos", 3306);

        public DataSet Login(string usuario)
        {
            return b.Obtener(string.Format("select * from usuarios where nombre = '{0}'", usuario), "usuarios");
        }
    }
}
