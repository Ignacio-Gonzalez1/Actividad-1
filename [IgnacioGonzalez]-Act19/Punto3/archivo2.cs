using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        public string RetornarSuperaAlRecord()
        {
            int Record = 6789912;
            string SuperoRecord="";
            if (Record>=puntajeMaximo)
            {
                SuperoRecord = "No supero el record de puntos";
            }
            else
            {
                SuperoRecord = "Supero el record de puntos";
            }
            return SuperoRecord;
        }
    }
}
