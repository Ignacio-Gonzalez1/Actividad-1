using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Carrera
    {
        /*  Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
            carrera de 100 metros. El programa debe cargar los datos en dos vectores
            paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
            atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
            promedio.
        */
        private double[] tiempo;
        private string[] Atletas, masAltoQueElPromedio;
        private double promedio, tiempoTotal, mejorTiempo, peorTiempo;
        private int numeroMejor, numeroPeor;
        public void CargarNombresYventas()
        {
            Atletas = new string[5];
            tiempo = new double[5];
            for (int i = 0; i < Atletas.Length; i++)
            {
                Console.WriteLine("Escriba El Nombre del Atleta: ");
                Atletas[i] = Console.ReadLine();

                Console.WriteLine("Escriba El tiempo del Atleta en los 100m: ");
                string linea;
                linea = Console.ReadLine();
                tiempo[i] = double.Parse(linea);
            }
        }
        public void CalcularPromedio()
        {
            promedio= 0;
            tiempoTotal = 0;
            for (int l = 0; l < Atletas.Length; l++)
            {
                tiempoTotal = tiempo[l] + tiempoTotal;
            }
            promedio = (double)tiempoTotal / 5;
            Console.WriteLine("El Promedio de los tiempos es: " + promedio);
        }
        public void MejorYPeor()
        {
            mejorTiempo= tiempo[0];
            peorTiempo= tiempo[0];
            numeroMejor = 0;
            numeroPeor = 0;

            for(int k=1; k < tiempo.Length; k++)
            {
                if (mejorTiempo > tiempo[k])
                {
                    mejorTiempo = tiempo[k];
                    numeroMejor = k;
                }
                if (peorTiempo<tiempo[k])
                {
                    peorTiempo = tiempo[k];
                    numeroPeor = k;
                }
            }
            Console.WriteLine("El Atleta con Mejor Tiempo es: " + Atletas[numeroMejor] + "   Su Tiempo es: " + mejorTiempo);
            Console.WriteLine("El Atleta con Peor Tiempo es: " + Atletas[numeroPeor] + "   Su Tiempo es: " + peorTiempo);
        }
        public void SuperaronPromedio()
        {
            int e = 0;
            masAltoQueElPromedio=new string[5];
            for (int b = 0; b < Atletas.Length; b++)
            {
                if (promedio > tiempo[b])
                {
                    masAltoQueElPromedio[e] = Atletas[b];
                    e++;
                }
            }
        }

        static void Main(string[] args)
        {
            Carrera per1 = new Carrera();
            per1.CargarNombresYventas();
            per1.MejorYPeor();
            per1.CalcularPromedio();
            per1.SuperaronPromedio();
            Console.ReadKey();

        }
    }
}
