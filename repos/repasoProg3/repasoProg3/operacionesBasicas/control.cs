using System;
using System.Collections.Generic;
using System.Text;

namespace repasoProg3.operacionesBasicas
{
    class control
    {

        //controles para los ingresos y operaciones
        public bool ingreso(string ingreso)
        {
            if ( int.Parse(ingreso) >= 0 || int.Parse(ingreso) <= 0) {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
