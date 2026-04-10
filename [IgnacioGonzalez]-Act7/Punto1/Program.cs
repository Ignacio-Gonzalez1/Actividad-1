using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Punto1
{
    internal class Vector8Elementos
    {
        /*  Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
            El valor acumulado de todos los elementos del vector.
            El valor acumulado de los elementos del vector que sean mayores a 36.
            Cantidad de valores mayores a 50.
        */
        private int[] Elemetos;
        private int sumaTotal, ValorAcumuladoMayor36, cantidadValoresMayor50;
        

        public void Ingresar8Elementos()
        {
            Elemetos = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Ingresa un Valor: ");
                String linea;
                linea = Console.ReadLine();
                Elemetos[i] = int.Parse(linea);
            }
        }
        public void ValorAcumulado()
        {
            sumaTotal = 0;
            ValorAcumuladoMayor36 = 0;
            cantidadValoresMayor50 = 0;
            for (int f = 0;f < 8;f++)
            {
                sumaTotal= sumaTotal + Elemetos[f];
                if (Elemetos[f] > 36)
                {
                    ValorAcumuladoMayor36= ValorAcumuladoMayor36 + Elemetos[f];
                    if(Elemetos[f] > 50)
                    {
                        cantidadValoresMayor50 = cantidadValoresMayor50 + 1;
                    }
                }
            }
        }
        public void ImprimirTodo()
        {
            Console.WriteLine("El Valor Acumulado de Todos los Elementos metidos es: " + sumaTotal);
            Console.WriteLine("El Valor Acumulado de Elementos Mayores a 36 es: " + ValorAcumuladoMayor36);
            Console.WriteLine("La Cantidad de Elementos Mayores a 50 es: " + cantidadValoresMayor50);
        }


        static void Main(string[] args)
        {
            Vector8Elementos Ele= new Vector8Elementos();
            Ele.Ingresar8Elementos();
            Ele.ValorAcumulado();
            Ele.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
