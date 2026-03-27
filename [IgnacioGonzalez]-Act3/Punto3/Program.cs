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
            //Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"
            int Num1, Num2, Num3;
            string linea;

            Console.WriteLine("El Primer Numero: ");
            linea = Console.ReadLine();
            Num1 = int.Parse(linea);

            Console.WriteLine("El Segundo Numero: ");
            linea = Console.ReadLine();
            Num2 = int.Parse(linea);

            Console.WriteLine("El Tercer Numero: ");
            linea = Console.ReadLine();
            Num3 = int.Parse(linea);

            if (Num1 < 10)
            {
                if (Num2 < 10)
                {
                    if (Num3 < 10)
                    {
                        Console.WriteLine("Todos los numeros son menores a 10");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
