using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        class Cuadrado
        {
            /*  
             *  Desarrollar una clase que represente un Cuadrado y tenga los siguientes
                métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
            */
            private int lado, perimetro, superficie;

            public void CargarLado()
            {
                string linea;
                Console.WriteLine("Poner el Lado: ");
                linea = Console.ReadLine();
                lado = int.Parse(linea);
            }
            public void calcularYmostrarPerimetroYsuperficie()
            {
                perimetro = lado * 4;
                superficie= lado * lado;
                Console.WriteLine("El perimetro es: " + perimetro);
                Console.WriteLine("El superficie es: " + superficie);

            }


            static void Main(string[] args)
            {
                Cuadrado Lado1 = new Cuadrado();
                Lado1.CargarLado();
                Lado1.calcularYmostrarPerimetroYsuperficie();
                Console.ReadKey();
            }
        }
    }
}
