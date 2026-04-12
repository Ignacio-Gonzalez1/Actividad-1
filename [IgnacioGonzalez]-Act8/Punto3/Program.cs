using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Ordenar
    {
        /*  Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
            (el orden lo pueden elegir ustedes).
        */
        private int[] VectorOrdenar;
        private int i;
        private string linea;
        public void CantidadN()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que van a ir en el Vector: ");
            linea = Console.ReadLine();
            i = int.Parse(linea);
        }
        public void CargarElementos()
        {
            VectorOrdenar=new int[i];
            for(int k=0; k<VectorOrdenar.Length; k++)
            {
                Console.WriteLine("Ingresar los Elementos: ");
                linea = Console.ReadLine();
                VectorOrdenar[k] = int.Parse(linea);
            }
        }
        public void OrdenarElVector()
        {
            for(int j=0; j<VectorOrdenar.Length - 1; j++)
            {
                for (int l = 0; l < VectorOrdenar.Length -1 - j; l++)
                {
                    if (VectorOrdenar[l] < VectorOrdenar[l+1])
                    {
                        int auxiliar;
                        auxiliar = VectorOrdenar[l];
                        VectorOrdenar[l]=VectorOrdenar[l+1];
                        VectorOrdenar[l + 1] = auxiliar;
                    }
                }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Los Elementos Dados Ordenados de Mayor a Menor: ");
            for (int p = 0; p < VectorOrdenar.Length; p++)
            {
                Console.WriteLine(VectorOrdenar[p]);
            }
        }




        static void Main(string[] args)
        {
            Ordenar Vector1 = new Ordenar();
            Vector1.CantidadN();
            Vector1.CargarElementos();
            Vector1.OrdenarElVector();
            Vector1.Imprimir();
            Console.ReadKey();
        }
    }
}
