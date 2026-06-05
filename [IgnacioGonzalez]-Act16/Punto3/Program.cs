using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Vehículo
    {
        /*  Crear una clase base Vehículo que contenga atributos marca y
            velocidadMaxima.
            Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
            una debe tener un constructor que reciba los valores de los atributos base
            mediante la palabra clave base, y un atributo propio (cantidadPuertas en
            Auto, cilindrada en Moto).
            Crear un objeto de cada clase y mostrar todos sus datos por consola.
        */
        protected string marca;
        protected double velocidadMaxima;
        public Vehículo()
        {
            Console.WriteLine("Poner la Marca del Vehiculo. ");
            marca = Console.ReadLine();
            Console.WriteLine("Poner la Velocidad Maxima de auto");
            string linea;
            linea = Console.ReadLine();
            velocidadMaxima= double.Parse(linea);
        }
        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public double VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }
    }
    class Auto : Vehículo
    {
        protected int cantidadPuertas;
        public Auto()
        {
            Console.WriteLine("La cantidad de Puertas que tiene el auto: ");
            string linea;
            linea = Console.ReadLine();
            cantidadPuertas=int.Parse(linea);
        }
        public int CantidadPuertas
        {
            set
            {
                cantidadPuertas = value;
            }
            get
            {
                return cantidadPuertas;
            }
        }
    }
    class Moto : Vehículo
    {
        protected int cilindrada;
        public Moto()
        {
            Console.WriteLine("Poner la cantidad de Cilindradra: ");
            string linea;
            linea = Console.ReadLine();
            cilindrada=int.Parse(linea);
        }

    }
    class Prueba
    {
        static void Main(string[] args)
        {
        }
    }
}
