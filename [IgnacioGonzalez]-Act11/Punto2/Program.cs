using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Programa
    {
        /*  Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
            primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
            (crearla sin la intervención del operador)
            Realizar la carga por teclado e imprimir posteriormente.
        */
        private int[][] matriz;
        public void cantidadColumnas()
        {
            matriz = new int[5][];
            matriz[0] = new int[1];
            matriz[1] = new int[2];
            matriz[2] = new int[3];
            matriz[3] = new int[4];
            matriz[4] = new int[5];
        }
        public void CargarDatos()
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine("Cagar datos de la fila: " + (i + 1));
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.WriteLine("Poner datos: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[i][j]=int.Parse(linea);
                }
            }

        }
        public void ImprimirTodo()
        {
            Console.WriteLine("La Matriz es asi: ");
            for (int i = 0;i < matriz.Length; i++)
            {
                Console.Write("Los datos de la Fila: " + i + "  es: ");
                for (int j = 0;j < matriz[i].Length; j++)
                {
                    Console.Write(" " + matriz[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Programa matriz1= new Programa();
            matriz1.cantidadColumnas();    
            matriz1.CargarDatos();
            matriz1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
