using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.
            */
            int valorLado, equilateroCantidad, isoscelesCantidad, escalenoCantidad, lado1, lado2, lado3, cantidadTriangulos;
            string linea;
            equilateroCantidad = 0;
            isoscelesCantidad= 0;
            escalenoCantidad = 0;
            cantidadTriangulos = 0;
            Console.WriteLine("Cantidad de Triangulos: ");
            linea = Console.ReadLine();
            cantidadTriangulos= int.Parse(linea);
            for (int i = 0; i < cantidadTriangulos; i++)
            {
                Console.WriteLine("Cantidad de Lado1: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.WriteLine("Cantidad de Lado1: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.WriteLine("Cantidad de Lado1: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Es Equilatero");
                    equilateroCantidad++;
                }
                else
                    if (lado1 == lado2 || lado2 == lado3)
                    {
                        Console.WriteLine("Es Isosceles");
                        isoscelesCantidad++;
                    }
                    else
                    {
                        Console.WriteLine("Es Escaleno");
                        escalenoCantidad++;
                    }
            

            }
            Console.WriteLine("La cantidad de Equilateros es: " + equilateroCantidad);
            Console.WriteLine("La cantidad de Isosceles es: " + isoscelesCantidad);
            Console.WriteLine("La cantidad de Escalenos es: " + escalenoCantidad);

            if (escalenoCantidad<equilateroCantidad && escalenoCantidad <isoscelesCantidad )
            {
                Console.WriteLine("La que tiene Menor cantidad de Triangulos es Escaleno");
            }else
                if (equilateroCantidad< escalenoCantidad && equilateroCantidad < isoscelesCantidad)
                {
                    Console.WriteLine("La que tiene Menor cantidad de Triangulos es Equilatero");
                }else
                {
                    Console.WriteLine("La que tiene Menor cantidad de Triangulos es Isosceles");
                }

            
            




        }
    }
}
