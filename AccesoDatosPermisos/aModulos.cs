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
    public class aModulos
    {
        Base b = new Base("localhost", "root", "", "permisos", 3306);

        public void Borrar(Modulos Entidad)
        {
            b.Comando(string.Format("delete from modulos where id = {0}",
                Entidad.Id));
        }

        public void Guardar(Modulos Entidad)
        {
            b.Comando(string.Format("call insertarmodulos({0}, '{1}');",
                Entidad.Id, Entidad.Nombre));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("SELECT * FROM modulos"), "modulos");
        }
    }
}
