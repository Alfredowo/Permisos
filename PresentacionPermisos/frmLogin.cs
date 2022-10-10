using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosPermisos;
using ManejadorPermisos;

namespace PresentacionPermisos
{
    public partial class frmLogin : Form
    {
        mUsuarios m = new mUsuarios();
        aUsuarios a = new aUsuarios();
        public static int idUsuario;
        public static string usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = a.Validar(txtNombre.Text);
                var dt = new DataTable();
                dt = ds.Tables[0];
                idUsuario = int.Parse(dt.Rows[0]["id"].ToString());

                usuario = dt.Rows[0]["nombre"].ToString();
                if (usuario == txtNombre.Text)
                {
                    MessageBox.Show("bienvenido");
                    frmMenu menu = new frmMenu();
                    Visible = false;
                    menu.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario incorrecto");
            }
            
        }
    }
}
