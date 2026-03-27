using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
               (No se ingresan valores por teclado)
             */
            int Numero, maxima;
            Numero = 0;
            maxima = 0;
            while (maxima <= 25)
            {
                Numero= Numero + 11;
                Console.WriteLine(Numero);
                maxima++;
            }



            Console.ReadKey();
        }
    }
}
