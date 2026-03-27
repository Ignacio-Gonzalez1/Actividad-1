using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            int num1, num2, num3, num4, suma;
            double promedio;
            string linea;

            Console.Write("Ingrese el Primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el Segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el Tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingrese el Cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma= num1 + num2 + num3 + num4;
            promedio = (num1 + num2 + num3 + num4) / 4.0;
            Console.WriteLine("La suma es: ");
            Console.WriteLine(suma);
            Console.WriteLine("El Promedio es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();

        }
    }
}
