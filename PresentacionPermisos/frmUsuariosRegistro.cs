using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorPermisos;
using EntidadesPermisos;

namespace PresentacionPermisos
{
    public partial class frmUsuariosRegistro : Form
    {
        mUsuarios manejador;

        public frmUsuariosRegistro()
        {
            InitializeComponent();
            manejador = new mUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != txtContraseña1.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error");
            }
            else
            {
                manejador.Guardar(new Usuarios(
                    0,
                    txtNombre.Text,
                    txtApellidop.Text,
                    txtApellidom.Text,
                    txtFecha.Text,
                    txtRfc.Text,
                    txtContraseña.Text
                    ));
                Close();
            }
        }
    }
}
