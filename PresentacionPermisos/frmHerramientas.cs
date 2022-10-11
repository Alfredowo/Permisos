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
    public partial class frmHerramientas : Form
    {
        mHerramientas manejador;
        public static Herramientas entidad = new Herramientas(0, "", "", "", 0);
        public static bool[,] permisos = frmMenu.permisos;
        public static int agregar = 1, modificar = 2, eliminar = 3, modulo = 1;
        int fila = 0, col = 0;

        public frmHerramientas()
        {
            InitializeComponent();
            manejador = new mHerramientas();
        }

        void Actualizar()
        {
            manejador.Mostrar(dtg);
        }

        //Eventos: ---------------------------------------------------------------------------------------------------

        private void frmHerramientas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entidad.Codigo = -1;
            if (permisos[modulo, agregar] == false)
                MessageBox.Show("no tienes permiso");
            else
            {
                frmHerramientasRegistro frm = new frmHerramientasRegistro();
                frm.ShowDialog();
                Actualizar();
            }
        }
        
        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtener los datos
            entidad.Codigo = int.Parse(dtg.Rows[fila].Cells[0].Value.ToString());
            entidad.Nombre = dtg.Rows[fila].Cells[1].Value.ToString();
            entidad.Descripcion = dtg.Rows[fila].Cells[2].Value.ToString();
            entidad.Marca = dtg.Rows[fila].Cells[3].Value.ToString();
            entidad.Medida = int.Parse(dtg.Rows[fila].Cells[4].Value.ToString());
            switch (col)
            {
                case 5:
                    { //editar
                        if (permisos[modulo, modificar] == false)
                            MessageBox.Show("no tienes permiso");
                        else
                        {
                            frmHerramientasRegistro frm = new frmHerramientasRegistro();
                            frm.ShowDialog();
                            txtBuscar.Text = "";
                            Actualizar();
                        }
                    }
                    break;
                case 6:
                    { //borrar 
                        if (permisos[modulo, eliminar] == false)
                            MessageBox.Show("no tienes permiso");
                        else
                        {
                            manejador.Borrar(entidad);
                            txtBuscar.Text = "";
                            Actualizar();
                        }
                    }
                    break;
            }
        }

        private void dtg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //se llenan los vaores de la tabla con lo que hay en el dtg
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
