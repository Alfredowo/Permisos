using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace ManejadorPermisos
{
    public class mUsuarios
    {
        aUsuarios a = new aUsuarios();
        
        public string login(string hola)
        {
            DataGridView tabla = new DataGridView();
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Validar("").Tables["usuarios"];
            return tabla.Rows[0].ToString();
        }
        public bool Validar(string hola)
        {
            DataGridView tabla = new DataGridView();
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Validar("").Tables["usuarios"];
            if (tabla.Rows.Count > 1)
                return true;
            else
                return false;
        }
    }
}
