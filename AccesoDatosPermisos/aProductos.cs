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
    public class aProductos
    {
        Base b = new Base("localhost", "root", "", "permisos", 3306);
        public void Borrar(Productos Entidad)
        {
            b.Comando(string.Format("delete from productos where id = {0}",
                Entidad.Codigo));
        }

        public void Guardar(Productos Entidad)
        {
            b.Comando(string.Format("CALL insertarproductos({0}, '{1}', '{2}', '{3}');",
                Entidad.Codigo, Entidad.Nombre, Entidad.Descripcion, Entidad.Marca));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("SELECT * FROM productos"), "productos");
        }
    }
}
