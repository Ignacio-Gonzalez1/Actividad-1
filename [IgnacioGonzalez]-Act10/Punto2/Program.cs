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
            Console.WriteLine("Cargar cuantas Filas quieres crear: ");
            string linea;
            linea = Console.ReadLine();
            n= int.Parse(linea);
            Console.WriteLine("Cargar cuantas Columnas quieres crear: ");
            linea = Console.ReadLine();
            m = int.Parse(linea);

        }
        public void cargardatos()
        {
            matriz = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Fila: " + (i + 1));
                for (int j = 0; j < m; j++)
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
            for (int g = 0; g < n; g++)
            {
                for(int h = 0; h < m; h++)
                {
                    int Aux;
                    Aux = matriz[g+1, h];
                    matriz[g + 1, h] = matriz[g, h];
                    
                }
            }
        }


        static void Main(string[] args)
        {
            Programa per1= new Programa();
            per1.cargarMyN();
            per1.cargardatos();
            Console.ReadKey();
        }
    }
}
