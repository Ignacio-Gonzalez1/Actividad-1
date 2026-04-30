using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Programa
    {
        /*  Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
            primer fila con la segunda. Imprimir luego la matriz.
        */
        private int[,] matriz; 
        private int m, n;

        public void cargarMyN()
        {
            m = 0;
            n= 0;
            string linea;
            int corte = 0;
            do
            {

                Console.WriteLine("Cargar cuantas Filas quieres crear: ");
                linea = Console.ReadLine();
                n=int.Parse(linea);
                if (n >= 2)
                {
                    break;
                }

            } while (corte != 1);
            

            Console.WriteLine("Cargar cuantas Columnas quieres crear: ");
            linea = Console.ReadLine();
            m = int.Parse(linea);

        }
        public void cargardatos()
        {
            matriz = new int[n, m];
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Fila: " + (i + 1));
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Ingresar los datos: ");
                    string linea;
                    linea = Console.ReadLine();
                    matriz[i, j] = int.Parse(linea);
                }
            }
        }
        public void cambiarDatos()
        {
            for (int g = 0; g < 1; g++)
            {
                for(int h = 0; h < 1; h++)
                {
                    int Aux;
                    Aux = matriz[g+1, h];
                    matriz[g + 1, h] = matriz[g, h];
                    matriz[g, h]=Aux;
                }
            }
        }
        public void imprimirTodo()
        {
            Console.WriteLine("La Matriz total es:");
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                Console.WriteLine("Fila: " + (f + 1));
                for (int ñ = 0; ñ < matriz.GetLength(1); ñ++)
                {
                    Console.WriteLine(matriz[f, ñ] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Programa per1= new Programa();
            per1.cargarMyN();
            per1.cargardatos();
            per1.cambiarDatos();
            per1.imprimirTodo();
            Console.ReadKey();
        }
    }
}
