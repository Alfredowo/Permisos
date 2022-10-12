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
            if (frmPermisos.opcion == 2)//actualizar 
            {
                cmbUsuario.Text = frmPermisos.entidad.Usuario.ToString();
                cmbModulo.Text = frmPermisos.entidad.Modulo.ToString();
                chbEscritura.Checked = frmPermisos.entidad.Escritura;
                chbEscritura.Checked = frmPermisos.entidad.Escritura;
                chbEscritura.Checked = frmPermisos.entidad.Escritura;
                chbEscritura.Checked = frmPermisos.entidad.Escritura;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text == "" || cmbModulo.Text == "")
                MessageBox.Show("esta nulo el conchaesumare", "Error");
            else
            {
                manejador.Guardar(new Permisos(
                    frmPermisos.entidad.Usuario,
                    frmPermisos.entidad.Modulo,
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
