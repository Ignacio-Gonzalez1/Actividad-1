using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Realizar un programa que acumule (sume) valores ingresados por teclado hasta
               ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
               valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
             */
            int numero, sumas, maximo, corte;
            string linea;
            numero = 0;
            maximo = 9999;
            sumas = 0;
            corte = 0;

            do
            {
                Console.WriteLine("Ingresar los Numeros: (al poner 9999 termina) ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero == 9999) {
                corte = 1;
                }
                else
                {
                    sumas = sumas + numero;
                }
                

            } while (corte != 1);
            Console.WriteLine("El acumulado es: ");
            Console.WriteLine(sumas);
            if (sumas > 0)
            {
                Console.WriteLine("El acumulado es Mayor a 0");
            }
            else
                if (sumas < 0)
                {
                    Console.WriteLine("El acumulado es menor a 0");
                    
                }
                else
                {
                    Console.WriteLine("El acumulado es Igual a 0");
                }

            Console.ReadKey();
        }
    }
}
