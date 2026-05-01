using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Matriz
    {
        /*  Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
            cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
            etc.)
        */
        private int[,] Matriz1;
        private int[] Vertices;
        private int m, n;
        public void cargarMyN()
        {
            m = 0;
            n = 0;
            string linea;
            int corte = 0;
            //puse un Do while ya que si el trabajo pide que se intercambie la primera fila con la segunda me hace pensar que es nesesario que haya
            //al menos 2 filas por esto agrego esta restriccion
            do
            {

                Console.WriteLine("Cargar cuantas Filas quieres crear: ");
                linea = Console.ReadLine();
                n = int.Parse(linea);
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
            Matriz1 = new int[n, m];
            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                Console.WriteLine("Fila: " + (i + 1));
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    Console.WriteLine("Ingresar los datos: ");
                    string linea;
                    linea = Console.ReadLine();
                    Matriz1[i, j] = int.Parse(linea);
                }
            }
        }
        public void Vertices1al4()
        {
            Vertices=new int[4];
            Vertices[0] = Matriz1[0,0];
            Vertices[1] = Matriz1[0, Matriz1.GetLength(1)-1];
            Vertices[2] = Matriz1[Matriz1.GetLength(0) - 1, 0];
            Vertices[3] = Matriz1[Matriz1.GetLength(0) - 1, Matriz1.GetLength(1) - 1];
        }
        public void ImprimirTodo()
        {
            Console.WriteLine("Las Vertices de esa Matriz son: ");
            for (int i = 0;i < 4; i++)
            {
                Console.WriteLine(Vertices[i]);
            }
        }




        static void Main(string[] args)
        {
            Matriz per1 = new Matriz();
            per1.cargarMyN();
            per1.cargardatos();
            per1.Vertices1al4();
            per1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
