using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class ProgramaVector

    {
        private int[] Vector1;
        private int menor, i;
        private string linea;

        public void CantidadN()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que van a ir en el Vector: ");
            linea = Console.ReadLine();
            i= int.Parse(linea);
        }

        public void Cargardatos()
        {
            Vector1 = new int[i];
            menor = Vector1[0];
            for (int j = 0; j <Vector1.Length; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("Ingresar los Elementos: ");
                    linea = Console.ReadLine();
                    Vector1[j]=int.Parse(linea);
                    menor = int.Parse(linea);
                } else
                if (j >= 1)
                {
                    Console.WriteLine("Ingresar los Elementos: ");
                    linea = Console.ReadLine();
                    if (int.Parse(linea) == menor)
                    {
                        Console.WriteLine("Ya se repite el menor");
                          Vector1[j] = int.Parse(linea);
                        }
                        else
                        if(int.Parse(linea) != menor)
                        {
                            Vector1[j] = int.Parse(linea);
                            if(Vector1[j] < menor)
                            {
                                menor = Vector1[j];
                            }
                            
                        }
                }
            }

        }
        public void ImprimirMenor()
        {
            Console.WriteLine("El Menor es: " + menor);
        }

        static void Main(string[] args)
        {
            ProgramaVector per= new ProgramaVector();
            per.CantidadN();
            per.Cargardatos();
            per.ImprimirMenor();
            Console.ReadKey();
        }
    }
}
