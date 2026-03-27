using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.
            int num1, num2, suma, producto, division, diferencia;
            string linea;

            Console.WriteLine("Ingrese el Numero1: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el Numero2: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.WriteLine("Su Suma es");
                Console.WriteLine(suma);
                Console.WriteLine("Su Diferencia es");
                Console.WriteLine(diferencia);
            }
            else
                if (num1 < num2)
                {
                    producto = num1 * num2;
                    division = num1 / num2;
                    Console.WriteLine("Su Producto es");
                    Console.WriteLine(producto);
                    Console.WriteLine("Su Division es");
                    Console.WriteLine(division);
                }
            Console.ReadKey();


        }
    }
}