using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace Punto1
{
    partial class ReservaHotel
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;
        public string NombreCliente
        {
            set
            {
                nombreCliente = value;
            }
            get
            {
                return nombreCliente;
            }
        }
        public int CantidadNoches
        {
            set
            {
                cantidadNoches = value;
            }
            get
            {
                return cantidadNoches;
            }
        }
        public string TipoHabitacion
        {
            set
            {
                tipoHabitacion = value;
            }
            get
            {
                return tipoHabitacion;
            }
        }
        public ReservaHotel()
        {
            Console.WriteLine("Poner el Nombre del cliente: ");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Poner la cantidad de noches que se va a hospedar: ");
            do
            {
                string linea;
                linea = Console.ReadLine();
                if (int.Parse(linea)>0)
                {
                    cantidadNoches = int.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("La cantidad de noches debe ser mas de 0");
                }
            }while (true);
            Console.WriteLine("Elegir en el tipo de habitacion en la que se va hospedar");
            Console.WriteLine("Simple = $5000, Doble = $8000, Suite = $12000 por noche");
            
            do
            {
                string linea;
                linea = Console.ReadLine().ToLower();
                if (linea=="simple" || linea == "doble"|| linea == "suite")
                {
                    tipoHabitacion=linea;
                    break;
                }
                else
                {
                    Console.WriteLine("Poner una de las 3");
                }
            }while (true);
        }
    }
}
