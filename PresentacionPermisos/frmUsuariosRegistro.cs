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
        public static Usuarios entidad = new Usuarios(0, "", "", "", "", "", "");

        public frmUsuariosRegistro()
        {
            InitializeComponent();
            manejador = new mUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entidad.Id = 0;
            if (txtContraseña.Text != txtContraseña1.Text)
                MessageBox.Show("Las contraseñas no coinciden", "Error");
            else if (txtNombre.Text == "" || txtApellidop.Text == "" || txtApellidom.Text == "" ||
                txtFecha.Text == "" || txtRfc.Text == "" || txtContraseña.Text == "")
                MessageBox.Show("No puedes dejar campos vacios", "Error");
            else
            {
                manejador.Guardar(new Usuarios(
                    entidad.Id,
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
