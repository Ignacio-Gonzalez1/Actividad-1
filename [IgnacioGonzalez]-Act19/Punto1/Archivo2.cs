using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        public int retornarPrecio()
        {
            int precioPagar=0;
            if (TipoHabitacion=="simple")
            {
                precioPagar = 5000;
            }
            else if (TipoHabitacion == "doble")
            {
                precioPagar = 8000;
            }
            else
            {
                precioPagar = 12000;
            }
            return precioPagar;
        }
    }
}
