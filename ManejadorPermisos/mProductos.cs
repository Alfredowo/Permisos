using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosPermisos;
using EntidadesPermisos;
using Crud;

namespace ManejadorPermisos
{
    public class mProductos
    {
        aProductos a = new aProductos();
        Grafico g = new Grafico();

        public void Borrar(Productos Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(string.Format(
                    "Está seguro de borrar?: {0}", Entidad.Nombre)
                ), "!Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                a.Borrar(Entidad);
        }

        public void Guardar(Productos Entidad)
        {
            a.Guardar(Entidad);
            g.Mensaje("Guardado con exito Uwu", "!Atención",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Mostrar().Tables["productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.SpringGreen));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Salmon));
            tabla.Rows[tabla.Rows.Count - 1].Height = (int)0.5;
            //tabla.Columns[0].Visible = false;
        }
    }
}
