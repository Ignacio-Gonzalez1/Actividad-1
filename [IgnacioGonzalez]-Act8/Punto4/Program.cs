using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class PaisesYhabitantes
    {
        /*  Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
            ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
            nuevamente.
        */

        private string[] Paises;
        private int[] habitantes;
        private string pasado, siguiente, auxiliar;
        private int auxH;

        public void IngresarPaisesYHabitantes()
        {
            Paises = new string[5];
            habitantes = new int[5];
            for (int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine("Ingrese El Pais: ");
                Paises[i] = Console.ReadLine();
                string linea;
                Console.WriteLine("Ingresar los Habitantes del Pais: ");
                linea = Console.ReadLine();
                habitantes[i] = int.Parse(linea);
            }
        }
        public void OrdenarAlfaYimprimir()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 4 - k; j++)
                {
                    pasado = Paises[j];
                    siguiente = Paises[j + 1];
                    if (pasado.CompareTo(siguiente) > 0)
                    {
                        
                        auxiliar = pasado;
                        Paises[j] = siguiente;
                        Paises[j + 1] = auxiliar;
                        auxH = habitantes[j];
                        habitantes[j]=habitantes[j + 1];
                        habitantes[j+1] = auxH;
                    }
                }
            }
            Console.WriteLine("Los Paises Ordenados Alfabéticamente: ");
            for (int m=0; m < Paises.Length; m++)
            {
                Console.WriteLine("El Pais: " + Paises[m] + "    Sus Habitantes: " + habitantes[m]);
            }
        }

        public void OrdenarMayorAMenorHabitantes()
        {
            for (int j = 0; j < habitantes.Length - 1; j++)
            {
                for (int l = 0; l < habitantes.Length - 1 - j; l++)
                {
                    if (habitantes[l] < habitantes[l + 1])
                    {

                        auxH = habitantes[l];
                        habitantes[l] = habitantes[l + 1];
                        habitantes[l + 1] = auxH;
                        auxiliar=Paises[l];
                        Paises[l] = Paises[l+1];
                        Paises[l+1] = auxiliar;

                    }
                }
            }
            Console.WriteLine("Los Habitantes Ordenados de Mayor a Menor: ");
            for (int n = 0; n < Paises.Length; n++)
            {
                Console.WriteLine("El Pais: " + Paises[n] + "    Sus Habitantes: " + habitantes[n]);
            }


        }




        static void Main(string[] args)
        {
            PaisesYhabitantes pYh1 = new PaisesYhabitantes();
            pYh1.IngresarPaisesYHabitantes();
            pYh1.OrdenarAlfaYimprimir();
            pYh1.OrdenarMayorAMenorHabitantes();
            Console.ReadKey();
        }
    }
}
