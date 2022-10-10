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
        public void EvaluarLectura(bool mostrar, Button boton)
        {
            if (mostrar == true)
                boton.Enabled = true;
        }
    }
}
