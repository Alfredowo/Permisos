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
            var ds = a.Login(txtNombre.Text);
            var dt = new DataTable();
            dt = ds.Tables[0];
            idUsuario = int.Parse(dt.Rows[0]["id"].ToString());

            usuario = dt.Rows[0]["nombre"].ToString();
            if (usuario == txtNombre.Text)
            {
                try
                {
                    MessageBox.Show("Bienvenido" + txtNombre.Text);
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                }
                catch (Exception)
                {
                    DialogResult rs = MessageBox.Show(string.Format("El usuario que ingreso no existe," +
                    "quiere crear una cuenta?"), "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        frmUsuariosRegistro frmq = new frmUsuariosRegistro();
                        frmq.ShowDialog();
                    }
                }

            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmUsuariosRegistro frm = new frmUsuariosRegistro();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
