using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
            int Num1, Num2, Num3;
            string linea;

            Console.WriteLine("Ingrese el Primer Numero: ");
            linea = Console.ReadLine();
            Num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el Segundo Numero: ");
            linea = Console.ReadLine();
            Num2 = int.Parse(linea);

            Console.WriteLine("Ingrese el Tercer Numero: ");
            linea = Console.ReadLine();
            Num3 = int.Parse(linea);

            if (Num1 > Num2)
            {
                if (Num1 > Num3)
                {
                    Console.WriteLine("El Numero 1 es el Mayor");
                }
            }
            else
                if (Num2 > Num3)
                {
                    Console.WriteLine("El Numero 2 es el Mayor");
                }
                else
                {
                    Console.WriteLine("El Numero 3 es el Mayor");
                }


            Console.ReadKey();
        }
    }
}
