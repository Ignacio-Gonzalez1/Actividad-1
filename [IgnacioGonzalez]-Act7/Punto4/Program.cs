using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Ordenado
    {
        /*  Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
            ordenado de menor a mayor y de mayor a menor.
        */
        private int[] vector1;
        private int mayor, menor;

        public void CargarLosElementos()
        {
            vector1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Datos del Vector: ");
                string linea;
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Los Datos del Vector es: ");
            for (int g = 0;g < 10;g++)
            {
                Console.WriteLine(vector1[g]);
            }
        }
        public void CompararDatosVectorMenorMayor()
        {
            menor = vector1[0];
            for (int f = 1; f < 10; f++)
            {
                if (menor <= vector1[f])
                {
                    menor = vector1[f];
                }
                else
                    if (menor > vector1[f])
                    {
                        Console.WriteLine("No esta ordenado de Menor a Mayor");
                        break;

                    }
            }
            if (menor == vector1[9])
            {
                Console.WriteLine("Si esta ordenado de Menor a Mayor");
            }
           
        }

        public void CompararDatosVectorMayorMenor()
        {
            mayor = vector1[0];
            for (int j = 1; j < 10; j++)
            {
                if (mayor>= vector1[j])
                {
                    mayor = vector1[j];
                }else
                    if (mayor < vector1[j])
                    {
                        Console.WriteLine("No esta ordenado de Mayor a Menor");
                        break;
                        
                    }
                
            }
            if (mayor == vector1[9])
            {
                Console.WriteLine("Si esta ordenado de Mayor a Menor");
            }
        }

        static void Main(string[] args)
        {
            Ordenado per = new Ordenado();
            per.CargarLosElementos();
            per.Imprimir();
            per.CompararDatosVectorMenorMayor();
            per.CompararDatosVectorMayorMenor();
            Console.ReadKey();
        }
    }
}
