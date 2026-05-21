using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Operaciones
    {
        /*  Implementar la clase operaciones. Se deben cargar dos valores enteros en el
            constructor, calcular su suma, resta, multiplicación y división, cada una en un
            método, imprimir dichos resultados.
        */
        private int m, n, suma, resta, multiplicacion;
        private double division;
        public Operaciones()
        {
            Console.WriteLine("Introdusca el Primer Numero: ");
            string linea;
            linea = Console.ReadLine();
            m=int.Parse(linea);
            Console.WriteLine("Introdusca el Segundo Numero: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

        }
        public void sumar()
        {
            suma = m + n;
        }
        public void restar()
        {
            resta = m - n;
        }
        public void multiplicar()
        {
            multiplicacion = m * n;
        }
        public void Dividir()
        {
            division = (double)m / n;
        }
        public void ImprimirTodo()
        {
            Console.WriteLine("Los numeros son: " + m +" "+ n);
            Console.WriteLine("El resultado de la suma es: " +suma);
            Console.WriteLine("El resultado de la resta es: " +resta);
            Console.WriteLine("El resultado de la multiplicacion es: " +multiplicacion);
            Console.WriteLine("El resultado de la division es: " + division);
        }
        static void Main(string[] args)
        {
            Operaciones per1 = new Operaciones();
            per1.sumar();
            per1.restar();
            per1.multiplicar();
            per1.Dividir();
            per1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
