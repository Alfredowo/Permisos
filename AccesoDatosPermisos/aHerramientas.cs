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
    public class aHerramientas
    {
        Base b = new Base("localhost", "root", "", "permisos", 3306);
        public void Borrar(Herramientas Entidad)
        {
            b.Comando(string.Format("delete from herramientas where id = {0}",
                Entidad.Codigo));
        }

        public void Guardar(Herramientas Entidad)
        {
            b.Comando(string.Format("CALL insertarherramientas({0}, '{1}', '{2}', '{3}', {4});",
                Entidad.Codigo, Entidad.Nombre, Entidad.Descripcion, Entidad.Marca, Entidad.medida));
        }

        public DataSet Mostrar()
        {
            return b.Obtener
                (string.Format("SELECT * FROM viewherramientas"), "herramientas");
        }
    }
}
