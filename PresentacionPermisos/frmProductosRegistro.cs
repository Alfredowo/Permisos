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
    public partial class frmProductosRegistro : Form
    {
        mProductos manejador;

        public frmProductosRegistro()
        {
            InitializeComponent();
            manejador = new mProductos();
            if (frmProductos.entidad.Codigo > 0) //actualizar 
            {
                txtNombre.Text = frmProductos.entidad.Nombre.ToString();
                txtDescripcion.Text = frmProductos.entidad.Descripcion.ToString();
                txtMarca.Text = frmProductos.entidad.Marca.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == null || txtDescripcion.Text == null || txtMarca.Text == null)
            {
                MessageBox.Show("esta nulo el conchaesumare", "Error");
            }
            else
            {
                manejador.Guardar(new Productos(
                    frmProductos.entidad.Codigo,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtMarca.Text
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
