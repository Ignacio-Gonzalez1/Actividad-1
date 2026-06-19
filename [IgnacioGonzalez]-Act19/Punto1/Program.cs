using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto1
{
    class Prueba
    {
        /*  Plantear una clase parcial ReservaHotel.
            En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
            TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
            noches sea mayor a 0. Estos valores son cargados desde la consola.
            En el segundo archivo, agregar un método que calcule el total a pagar según la
            habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
            noche).
            Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
        */
        private ReservaHotel[] totalReservaHotel;
        public Prueba()
        {
            totalReservaHotel = new ReservaHotel[3];
            for (int i = 0;i < totalReservaHotel.Length; i++)
            {
                totalReservaHotel[i] = new ReservaHotel();
            }
        }
        public void MasPaga()
        {
            int mayor = totalReservaHotel[0].retornarPrecio() * totalReservaHotel[0].CantidadNoches;
            int k = 0;
            for (int i = 1;i<totalReservaHotel.Length ; i++)
            {
                if (mayor < (totalReservaHotel[i].retornarPrecio() * totalReservaHotel[i].CantidadNoches))
                {
                    mayor=totalReservaHotel[i].retornarPrecio() * totalReservaHotel[i].CantidadNoches;
                    k = i;
                }
            }
            Console.WriteLine("El que mas paga es: " + totalReservaHotel[k].NombreCliente + " que se queda en total unas: " + totalReservaHotel[k].CantidadNoches + " Noches" + " esta en la habitacion: " + totalReservaHotel[k].TipoHabitacion + " lo que pagara en total seria: "+ mayor);
        }
        static void Main(string[] args)
        {
            Prueba prueba1 = new Prueba();
            prueba1.MasPaga();
            Console.ReadKey();
        }
    }
}
