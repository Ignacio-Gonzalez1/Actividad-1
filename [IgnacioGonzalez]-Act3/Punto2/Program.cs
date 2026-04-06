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
            //Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
            int Num1, Num2, Num3, multiplicacion, suma;
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

            if (Num1==Num2)
            {
                if (Num2==Num3) {
                    suma = Num1 + Num2;
                    multiplicacion = suma * Num3;
                    Console.WriteLine("El resultado de la suma de los primeros dos numeros es: ");
                    Console.WriteLine(suma);
                    Console.WriteLine("El resultado de la multiplicacion es: ");
                    Console.WriteLine(multiplicacion);
                }
            }
            else
            {
                Console.WriteLine("Los Numeros no son Iguales");
            }



            Console.ReadKey();
        }
    }
}
