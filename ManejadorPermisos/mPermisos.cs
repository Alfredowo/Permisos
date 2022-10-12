using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud;
using EntidadesPermisos;
using AccesoDatosPermisos;
using System.Drawing;

namespace ManejadorPermisos
{
    public class mPermisos
    {
        aPermisos a = new aPermisos();
        Grafico g = new Grafico();
        public static int opcion;

        public void Borrar(Permisos Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(string.Format(
                    "Está seguro de quitarle todos los permisos a {0}?", Entidad.Usuario)
                ), "!Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                a.Borrar(Entidad);
        }

        public void Guardar(Permisos Entidad)
        {
            a.Guardar(Entidad, opcion);
            g.Mensaje("Guardado con exito Uwu", "!Atención",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Mostrar().Tables["permisos"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.SpringGreen));
            tabla.Columns.Insert(7, g.Boton("Borrar", Color.Salmon));
            tabla.Rows[tabla.Rows.Count - 1].Height = (int)0.1;
        }
    }
}
