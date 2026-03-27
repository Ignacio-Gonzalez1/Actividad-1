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
            //Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)
            int positivo;
            string linea;

            Console.WriteLine("Ingrese el Numero: ");
            linea = Console.ReadLine();
            positivo = int.Parse(linea);

            if (positivo >= 1)
            {
                if (positivo <= 99)
                {
                    if (positivo < 10)
                    {
                        Console.WriteLine("El numero tiene 1 digito");
                    }
                    else
                    {
                        Console.WriteLine("El numero tiene 2 digitos");
                    }
                }
            }
            else
            {
                Console.WriteLine("Agrega un numero positivo");
            }

            Console.ReadKey();

        }
    }
}
