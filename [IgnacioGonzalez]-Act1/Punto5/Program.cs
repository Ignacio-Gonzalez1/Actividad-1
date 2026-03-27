using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
            int radio;
            double circunferencia, area;
            string linea;

            Console.WriteLine("Escribir el Radio: ");
            linea = Console.ReadLine();
            radio = int.Parse(linea);

            circunferencia = (radio * 2) * 3.1415;
            area = (radio * radio) * 3.1415;
            Console.WriteLine("La Circunferencia del Circulo es: " + circunferencia);

            Console.WriteLine("El Area del Circulo es: " + area);

            Console.ReadKey();
        }
    }
}
