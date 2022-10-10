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
    public class aPermisos
    {
        Base b = new Base("localhost", "root", "", "permisos", 3306);
        public DataSet ExtraerPermisos(int idUsuario)
        {
            return b.Obtener(string.Format("select * from permisos where fkusuario = {0}", idUsuario), "permisos");
        }
    }
}
