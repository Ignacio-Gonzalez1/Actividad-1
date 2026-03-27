using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
            int num1, num2, num3, num4, suma, producto;
            string linea;

            Console.Write("Ingrese el Primer numero para sumar: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el Segundo numero para sumar: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el Primer numero para el producto: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Ingrese el Segundo numero para el producto: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;
            Console.WriteLine("La suma es: ");
            Console.WriteLine(suma);
            Console.WriteLine("El producto es: ");
            Console.WriteLine(producto);

            Console.ReadKey();
           
        }
    }
}
