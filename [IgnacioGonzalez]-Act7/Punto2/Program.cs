using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Programa
    {
        /*  Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
            elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
            tercer vector del mismo tamaño. Sumar componente a componente.
        */
        private int[] Vector1, Vector2, Vector3;


        public void CagarLosDosVectores()
        {
            Vector1 = new int[4];
            Vector2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Cargar los datos en Vector 1: ");
                string linea;
                linea = Console.ReadLine();
                Vector1[i]=int.Parse(linea);

                Console.WriteLine("Cargar los datos en Vector 2: ");
                linea = Console.ReadLine();
                Vector2[i] = int.Parse(linea);
            }
        }
        public void SumarLosVectores()
        {
            Vector3 = new int[4];
            for (int f=0; f < 4; f++)
            {
                Vector3[f] = Vector1[f] + Vector2[f]; 
            }
        }
        public void MostrarElResultadoSuma()
        {
            Console.WriteLine("Los Datos de la Suma de ambos Vectores es: ");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(Vector3[j]);
            }
        }

        static void Main(string[] args)
        {
            Programa VectorOne=new Programa();
            VectorOne.CagarLosDosVectores();
            VectorOne.SumarLosVectores();
            VectorOne.MostrarElResultadoSuma();
            Console.ReadKey();
        }
    }
}
