﻿using System;
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
    public partial class frmModulos : Form
    {
        mModulos manejador;
        public static Modulos entidad = new Modulos(0, "");
        public static int id;
        int fila = 0, col = 0;

        public frmModulos()
        {
            InitializeComponent();
            manejador = new mModulos();
        }

        void Actualizar()
        {
            manejador.Mostrar(dtg);
        }

        //----------------------------------------------------------------------------------------------------------------

        private void frmModulos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            frmModulosRegistro frm = new frmModulosRegistro();
            frm.ShowDialog();
            Actualizar();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtener los datos
            entidad.Id = int.Parse(dtg.Rows[fila].Cells[0].Value.ToString());
            entidad.Nombre = dtg.Rows[fila].Cells[1].Value.ToString();
            switch (col)
            {
                case 4:
                    { //editar
                        frmModulosRegistro frm = new frmModulosRegistro();
                        frm.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 3:
                    { //borrar 
                        manejador.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //se llenan los valores de la tabla con lo que hay en el dtg
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
