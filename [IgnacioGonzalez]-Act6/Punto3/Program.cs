using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        class Empleado
        {
            /* Confeccionar una clase que represente un empleado. Definir como atributos su
                nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
                sus datos y por último uno que imprima un mensaje si debe pagar impuestos
                (si el sueldo supera a 3000).
             */
            private int sueldo;
            private string nombre;
            public void CargarDatos()
            {
                string linea;
                Console.WriteLine("Poner el Nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Poner el Sueldo: ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
            }
            public void MostrarDatos()
            {
                Console.WriteLine("El Nombre del Empleado es: " + nombre);
                Console.WriteLine("Su sueldo es: " + sueldo);
            }
            public void Impuestos()
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine("Debe Pagar Impuestos");
                } else { Console.WriteLine("No debe Pagar Impuestos");
                }
            }

            static void Main(string[] args)
            {
                  Empleado Per1 = new Empleado();
                Per1.CargarDatos();
                Per1.MostrarDatos();
                Per1.Impuestos();
                Console.ReadKey();
            }
        }
    }
}
