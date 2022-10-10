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
    public partial class frmLogin : Form
    {
        mUsuarios m = new mUsuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.Show();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            frmHerramientas frm = new frmHerramientas();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m.login(txtNombre.Text));
            bool valid = m.Validar(txtNombre.Text);
            if (valid == true)
            {
                btnHerramientas.Enabled = true;
                btnProductos.Enabled = true;
                MessageBox.Show("Usuario correcto");
            }
            else
                MessageBox.Show("Error");
        }
    }
}
