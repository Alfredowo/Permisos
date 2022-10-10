using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorPermisos
{
    public class mPermisos
    {
        public void EvaluarPermisos(int modulo, bool mostrar, bool agregar, bool modificar, bool eliminar,
            Button productos, Button herramientas)
        {
            if (modulo == 1)
            {
                if (mostrar == true)
                    productos.Enabled = true;
                
            }
            if (modulo == 2)
            {
                if (mostrar == true)
                    herramientas.Enabled = true;
            }
        }
    }
}
