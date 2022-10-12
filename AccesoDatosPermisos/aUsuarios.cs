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

        public void Guardar(Usuarios Entidad)
        {
            b.Comando(string.Format("call insertarusuarios({6}, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", 
                Entidad.Id, Entidad.Nombre, Entidad.Apellidop, Entidad.Apellidom, Entidad.Fecha, Entidad.Rfc,
                Entidad.Contraseña));
        }

        public void Borrar(Usuarios Entidad)
        {
            b.Comando(string.Format("delete from usuarios where id = {0}",
                Entidad.Id));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("SELECT * FROM usuarios"), "usuarios");
        }
    }
}
