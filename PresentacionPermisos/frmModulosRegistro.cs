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
    public partial class frmModulosRegistro : Form
    {
        mModulos manejador;

        public frmModulosRegistro()
        {
            InitializeComponent();
            manejador = new mModulos();
            if (frmModulos.entidad.Id > 0) //actualizar 
            {
                txtNombre.Text = frmModulos.entidad.Nombre.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == null)
            {
                MessageBox.Show("esta nulo el conchaesumare", "Error");
            }
            else
            {
                manejador.Guardar(new Modulos(
                    frmModulos.entidad.Id,
                    txtNombre.Text
                    ));
                Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
