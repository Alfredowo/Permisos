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
    public partial class frmHerramientasRegistro : Form
    {
        mHerramientas manejador;

        public frmHerramientasRegistro()
        {
            InitializeComponent();
            manejador = new mHerramientas();
            if (frmHerramientas.entidad.Codigo > 0) //actualizar 
            {
                txtNombre.Text = frmHerramientas.entidad.Nombre.ToString();
                txtDescripcion.Text = frmHerramientas.entidad.Descripcion.ToString();
                txtMarca.Text = frmHerramientas.entidad.Marca.ToString();
                txtMedida.Text = frmHerramientas.entidad.Medida.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                manejador.Guardar(new Herramientas(
                    frmHerramientas.entidad.Codigo,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtMarca.Text,
                    int.Parse(txtMedida.Text)
                    ));
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Campos incorrectos");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
