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
    public partial class frmMenu : Form
    {
        aPermisos a = new aPermisos();
        public static int mostrar = 0, agregar = 1, modificar = 2, eliminar = 3;
        public static bool permisoMostrar;
        public static bool[,] permisos = new bool[2, 4];
        public static string usuario = frmLogin.nombre;

        public frmMenu()
        {
            InitializeComponent();
        }

        public void Administrador()
        {
            if(usuario == "Alfred")
            {
                btnPermisos.Enabled = true;
                btnPermisos.Visible = true;
                btnModulos.Enabled = true;
                btnModulos.Visible = true;
            }
            else
            {
                btnPermisos.Enabled = false;
                btnPermisos.Visible = false;
                btnModulos.Enabled = false;
                btnModulos.Visible = false;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            List<string> modulos = new List<string>();
            //modulos:
            modulos.Add("productos");
            modulos.Add("herramientas");

            var ds = a.ExtraerPermisos(frmLogin.idUsuario);
            var dt = new DataTable();
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                permisos[i, mostrar] = bool.Parse(dt.Rows[i]["lectura"].ToString());
                permisos[i, agregar] = bool.Parse(dt.Rows[i]["escritura"].ToString());
                permisos[i, modificar] = bool.Parse(dt.Rows[i]["actualizar"].ToString());
                permisos[i, eliminar] = bool.Parse(dt.Rows[i]["eliminar"].ToString());
                //m.EvaluarLectura(permisoMostrar, modulos[i]);
            }
            Administrador();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (permisos[0, mostrar] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                frmProductos frm = new frmProductos();
                frm.Show();
            }
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos frm = new frmPermisos();
            frm.Show();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            frmModulos frm = new frmModulos();
            frm.Show();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            if (permisos[1, mostrar] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                frmHerramientas frm = new frmHerramientas();
                frm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
