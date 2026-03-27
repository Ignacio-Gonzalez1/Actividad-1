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
            //Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 
            int X, Y;
            string linea;
            Console.WriteLine("Escribir X: ");
            linea = Console.ReadLine();
            X = int.Parse(linea);

            Console.WriteLine("Escribir Y: ");
            linea = Console.ReadLine();
            Y = int.Parse(linea);

            if (X > 0)
            {
                if (Y > 0)
                {
                    Console.WriteLine("Se encuentra en el cuadrante 1°");
                }
            }
            else
                if (X < 0)
                {
                    if (Y > 0)
                    {
                        Console.WriteLine("Se encuentra en el cuadrante 2°");
                    }
                }

            Console.ReadKey();
        }
    }
}
