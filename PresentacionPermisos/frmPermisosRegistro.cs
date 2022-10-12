using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPermisos;
using ManejadorPermisos;

namespace PresentacionPermisos
{
    public partial class frmPermisosRegistro : Form
    {
        mPermisos manejador;

        public frmPermisosRegistro()
        {
            InitializeComponent();
            manejador = new mPermisos();
            manejador.ExtraerUsuarios(cmbUsuario);
            manejador.ExtraerModulos(cmbModulo);
            if (frmPermisos.opcion == 2)//actualizar 
            {
                cmbUsuario.Enabled = false;
                cmbModulo.Enabled = false;
                cmbUsuario.Text = frmPermisos.cmbusuario;
                cmbModulo.Text = frmPermisos.cmbcategoria;
                chbEscritura.Checked = frmPermisos.entidad.Escritura;
                chbLectura.Checked = frmPermisos.entidad.Lectura;
                chbActualizar.Checked = frmPermisos.entidad.Actualizar;
                chbEliminar.Checked = frmPermisos.entidad.Eliminar;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text == "" || cmbModulo.Text == "")
                MessageBox.Show("esta nulo el conchaesumare", "Error");
            else
            {
                manejador.Guardar(new Permisos(
                    int.Parse(cmbUsuario.SelectedValue.ToString()),
                    int.Parse(cmbModulo.SelectedValue.ToString()),
                    chbLectura.Checked,
                    chbEscritura.Checked,
                    chbActualizar.Checked,
                    chbEliminar.Checked
                    ));
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
