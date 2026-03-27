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
            //Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
            int nota1, nota2, nota3, nota4, nota5, nota6, promedio;
            string linea;

            Console.WriteLine("La Primera nota: ");
            linea = Console.ReadLine();
            nota1= int.Parse(linea);

            Console.WriteLine("La Segundo nota: ");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);

            Console.WriteLine("La Tercera nota: ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            Console.WriteLine("La Cuarta nota: ");
            linea = Console.ReadLine();
            nota4 = int.Parse(linea);

            Console.WriteLine("La Quinta nota: ");
            linea = Console.ReadLine();
            nota5 = int.Parse(linea);

            Console.WriteLine("La Sexta nota: ");
            linea = Console.ReadLine();
            nota6 = int.Parse(linea);
            promedio = ( nota1 + nota2 + nota3 + nota4 + nota5 + nota6 ) / 6;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }else
                if (promedio<7)
                {
                    Console.WriteLine("No Promocionado");
                }


            Console.ReadKey();
        }
    }
}
