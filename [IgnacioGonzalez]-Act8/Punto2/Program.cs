using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Paises
    {
        /*  Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
            algoritmo de ordenamiento alfabético.
        */
        private string[] NombresPaises;
        private string pasado, siguiente;

        public void IngresarPaises()
        {
            NombresPaises = new string[5];
            for (int i = 0; i < NombresPaises.Length; i++)
            {
                Console.WriteLine("Ingrese los Paises: ");
                NombresPaises[i] = Console.ReadLine();
            }
        }
        public void Ordenar()
        {
            //a b c d e/e d c b a/0 1 2 3 4/4 2 1 3 0/zambia colombia argentina/ argentina colombia zambia
            for(int k=0; k<4; k++)
            {
                for (int j = 0; j < 4 - k; j++)
                {
                    pasado = NombresPaises[j];
                    siguiente= NombresPaises[j + 1];
                    if (pasado.CompareTo(siguiente) > 0)
                    {
                        string auxiliar;
                        auxiliar = pasado;
                        NombresPaises[j] = siguiente;
                        NombresPaises[j+1] = auxiliar;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los Paises Ordenas Alfabeticamente: ");
            for(int l=0;  l<5; l++)
            {
                Console.WriteLine(NombresPaises[l]);
            }
        }



        static void Main(string[] args)
        {
            Paises paises1=new Paises();
            paises1.IngresarPaises();
            paises1.Ordenar();
            paises1.Imprimir();
            Console.ReadKey();
        }
    }
}
