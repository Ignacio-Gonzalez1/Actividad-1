using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Empleado
    {
        /*  Confeccionar una clase que represente un empleado. Definir como atributos su
            nombre y su sueldo. En el constructor cargar los atributos y luego en otro
            método imprimir sus datos y por último uno que imprima un mensaje si debe
            pagar impuestos (si el sueldo supera a 3000)
        */
        private string nombre;
        private int sueldo;
        public Empleado()
        {
            Console.WriteLine("Poner El Nombre del Empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Poner El Sueldo de "+nombre+": ");
            string linea;
            linea= Console.ReadLine();
            sueldo= int.Parse(linea);
        }
        public void Imprimirdatos()
        {
            Console.WriteLine("El nombre del Empleado es: "+nombre);
            Console.WriteLine("Su sueldo es: "+sueldo);
        }
        public void PagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe Pagar Impuestos " + nombre);
            }
            else
            {
                Console.WriteLine("No Debe Pagar Impuestos " + nombre);
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado1= new Empleado();
            empleado1.Imprimirdatos();
            empleado1.PagaImpuestos();
            Console.ReadKey();
        }
    }
}
