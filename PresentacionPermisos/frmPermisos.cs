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
    public partial class frmPermisos : Form
    {
        mPermisos manejador;
        public static Permisos entidad = new Permisos(0, 0, false, false, false, false);
        public static int opcion = mPermisos.opcion;
        public static string cmbusuario = "", cmbcategoria = "";
        int fila = 0, col = 0;

        public frmPermisos()
        {
            InitializeComponent();
            manejador = new mPermisos();
        }

        void Actualizar()
        {
            manejador.Mostrar(dtg);
        }

        //----------------------------------------------------------------------------------------------------------------

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            opcion = 1;
            frmPermisosRegistro frm = new frmPermisosRegistro();
            frm.ShowDialog();
            Actualizar();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtener los datos
            try
            {
                cmbusuario = dtg.Rows[fila].Cells[0].Value.ToString();
                cmbcategoria = dtg.Rows[fila].Cells[1].Value.ToString();
                entidad.Lectura = bool.Parse(dtg.Rows[fila].Cells[2].Value.ToString());
                entidad.Escritura = bool.Parse(dtg.Rows[fila].Cells[3].Value.ToString());
                entidad.Actualizar = bool.Parse(dtg.Rows[fila].Cells[4].Value.ToString());
                entidad.Eliminar = bool.Parse(dtg.Rows[fila].Cells[5].Value.ToString());
                switch (col)
                {
                    case 6:
                        { //editar
                            opcion = 2;
                            frmPermisosRegistro frm = new frmPermisosRegistro();
                            frm.ShowDialog();
                            txtBuscar.Text = "";
                            Actualizar();
                        }
                        break;
                    case 7:
                        { //borrar 
                            manejador.Borrar(entidad);
                            txtBuscar.Text = "";
                            Actualizar();
                        }
                        break;
                }
            }
            catch (Exception) { }
        }

        private void dtg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //se llenan los valores de la tabla con lo que hay en el dtg
            fila = e.RowIndex;
            col = e.ColumnIndex;
            dtg.Rows[fila].Cells[2].ReadOnly = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
