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
            //Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            DateTime FechaDada;

            Console.WriteLine("Pon una fecha: (ejemplo: dd/MM/yyyy)");
            FechaDada = DateTime.Parse(Console.ReadLine());
            Console.Write(FechaDada);

            if (FechaDada.Day == 25 && FechaDada.Month == 12)
            {
                Console.WriteLine("  Esa fecha es Navidad");
            }
            else
            {
                Console.WriteLine("  Esa fecha no es Navidad");
            }

            Console.ReadKey();

        }
    }
}
