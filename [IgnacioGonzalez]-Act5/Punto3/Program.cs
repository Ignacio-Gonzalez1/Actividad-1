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
            /* Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
                a) La cantidad de valores ingresados negativos.
                b) La cantidad de valores ingresados positivos.
                c) La cantidad de múltiplos de 15.
                d) El valor acumulado de los números ingresados que son pares.
            */
            int numero, negativos, positivos, multiplos15, numerosPares;
            string linea;
            positivos = 0;
            numerosPares = 0;
            multiplos15 = 0;
            negativos = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el Valor");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero > 0)
                {
                    positivos = positivos + 1;
                }
                else
                if (numero < 0)
                {
                    negativos = negativos + 1;
                }
                if (numero % 15 == 0)
                {
                    multiplos15 = multiplos15 + 1;
                }
                if (numero % 2 == 0)
                {
                    numerosPares = numero + numerosPares;
                }

            }
            Console.WriteLine("La cantidad de valores ingresados negativos: " + negativos);
            Console.WriteLine("La cantidad de valores ingresados positivos." + positivos);
            Console.WriteLine("La cantidad de múltiplos de 15: " + multiplos15);
            Console.WriteLine("El valor acumulado de los números ingresados que son pares: " + numerosPares);



            Console.ReadKey();
        }
    }
}






