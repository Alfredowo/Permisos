using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using EntidadesPermisos;
using AccesoDatosPermisos;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorPermisos
{
    public class mModulos
    {
        aModulos a = new aModulos();
        Grafico g = new Grafico();

        public void Borrar(Modulos Entidad)
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

        public void Guardar(Modulos Entidad)
        {
            a.Guardar(Entidad);
            g.Mensaje("Guardado con exito Uwu", "!Atención",
                MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Mostrar().Tables["modulos"];
            tabla.Columns.Insert(2, g.Boton("Borrar", Color.Salmon));
            tabla.Rows[tabla.Rows.Count - 1].Height = (int)0.1;
        }
    }
}
