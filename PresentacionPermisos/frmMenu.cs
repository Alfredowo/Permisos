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
        aPermisos adp = new aPermisos();
        mPermisos mp = new mPermisos();
        public static bool mostrar, agregar, modificar, eliminar;
        public static int modulo;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var ds = adp.ExtraerPermisos(frmLogin.idUsuario);
            var dt = new DataTable();
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                agregar = bool.Parse(dt.Rows[i]["escritura"].ToString());
                mostrar = bool.Parse(dt.Rows[i]["lectura"].ToString());
                eliminar = bool.Parse(dt.Rows[i]["eliminar"].ToString());
                modificar = bool.Parse(dt.Rows[i]["actualizacion"].ToString());
                modulo = int.Parse(dt.Rows[i]["modulo"].ToString());
                mp.EvaluarPermisos(modulo, mostrar, agregar, modificar, eliminar, btnProductos, btnHerramientas);
            }
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
    }
}
