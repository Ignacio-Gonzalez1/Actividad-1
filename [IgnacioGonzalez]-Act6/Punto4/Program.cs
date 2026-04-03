using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        class Operaciones
        {
            /*  Implementar la clase operaciones. Se deben cargar dos valores enteros,
                calcular su suma, resta, multiplicación y división, cada una en un método,
                imprimir dichos resultados.
             */
            private int Num1, Num2, Suma, Resta, Multiplicacion;
            private double division;

            public void CargarDatos()
            {
                string linea;
                Console.WriteLine("Poner el Primer Numero entero: ");
                linea = Console.ReadLine();
                Num1 = int.Parse(linea);
                Console.WriteLine("Poner el Segundo Numero entero: ");
                linea = Console.ReadLine();
                Num2 = int.Parse(linea);
            }
            public void Sumar()
            {
                Suma = Num1 + Num2;
            }

            public void Restar()
            {
                Resta = Num1 - Num2;
            }
            public void Multiplicar()
            {
                Multiplicacion = Num1 * Num2;
            }
            public void Dividir()
            {
                division = (double)Num1 / Num2;
            }
            public void MostrarDatos()
            {
                Console.WriteLine("La Suma es: " + Suma);
                Console.WriteLine("La Resta es: " + Resta);
                Console.WriteLine("La Multiplicacion es: " + Multiplicacion);
                Console.WriteLine("La Division es: " + division);
            }

            static void Main(string[] args)
            {
                Operaciones operaciones1 = new Operaciones();
                operaciones1.CargarDatos();
                operaciones1.Sumar();
                operaciones1.Restar();
                operaciones1.Multiplicar();
                operaciones1.Dividir();
                operaciones1.MostrarDatos();
                Console.ReadKey();
            }
        }
    }
}
