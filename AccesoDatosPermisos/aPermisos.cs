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
        public void Borrar(Permisos Entidad)
        {
            b.Comando(string.Format("DELETE FROM permisos WHERE fkusuario = {0} AND modulo = {1};",
                Entidad.Usuario, Entidad.Modulo));
        }

        public void Guardar(Permisos Entidad, int opcion)
        {
            b.Comando(string.Format("CALL insertarpermisos({0}, {1}, {2}, {3}, {4}, {5}, {6});",
                Entidad.Usuario, Entidad.Modulo, Entidad.Lectura, Entidad.Escritura, Entidad.Actualizar, 
                Entidad.Eliminar, opcion));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("SELECT * FROM viewpermisos"), "permisos");
        }
    }
}
