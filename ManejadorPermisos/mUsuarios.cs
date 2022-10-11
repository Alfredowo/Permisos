using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosPermisos;
using EntidadesPermisos;
using Crud;

namespace ManejadorPermisos
{
    public class mUsuarios
    {
        aUsuarios a = new aUsuarios();
        Grafico g = new Grafico();

        public void Guardar(Usuarios Entidad)
        {
            try
            {
                a.Guardar(Entidad);
                g.Mensaje("Usuario registrado con exito Uwu", "!Atención",
                    MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                g.Mensaje("Revisa los campos", "Error", MessageBoxIcon.Error);
            }
        }
        public void Borrar(Usuarios Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format(string.Format("Está seguro de borrar su cuenta, {0}?",
                Entidad.Nombre)), "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                a.Borrar(Entidad);
        }
    }
}
