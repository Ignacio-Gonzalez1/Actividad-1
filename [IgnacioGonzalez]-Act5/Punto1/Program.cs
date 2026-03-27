using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            39.
             */
            int numero, tabla;
            string linea;
            Console.WriteLine("Ingresa un numero del 1 al 10: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);
            if (numero < 0 || numero > 10)
            {
                Console.WriteLine("Ingresa un valor, siguiendo la condicion");

            }else
            if (numero > 0 && numero <= 10)
            {
                for (int i = 1; i <= 13; i++)
                {
                    tabla = numero * i;
                    Console.WriteLine(tabla);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}