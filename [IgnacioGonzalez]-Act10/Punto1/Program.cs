using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Programa
    {
        /*  Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
            componentes por columna (es decir primero ingresar toda la primer
            columna, luego la segunda columna y así sucesivamente)
            Imprimir luego la matriz.
        */

        private int[,] Matriz;

        public void Cargardatos()
        {
            Matriz = new int[2, 5];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Fila: " +(i + 1));
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Ingresar los datos: ");
                    string linea;
                    linea = Console.ReadLine();
                    Matriz[i,j]=int.Parse(linea);
                }
            }
        }
        public void ImprimirTodo()
        {
            Console.WriteLine("La Matriz total es:");
            for (int f = 0; f < 2; f++)
            {
                Console.WriteLine("Fila: " + (f + 1));
                for (int g = 0; g < 5; g++)
                {
                    Console.WriteLine(Matriz[f,g] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Programa Per1 = new Programa();
            Per1.Cargardatos();
            Per1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
