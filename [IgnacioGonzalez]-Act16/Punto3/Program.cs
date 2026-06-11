using Punto3;
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
        public int cantidadPuertas;
        public Vehículo base1;
        public Auto()
        {
            base1 = new Vehículo();
            string linea;
            Console.WriteLine("Poner la marca que tiene el Auto: ");
            base1.Marca = Console.ReadLine();
            Console.WriteLine("La VelocidadMaxima es del Auto: ");
            linea = Console.ReadLine();
            base1.VelocidadMaxima = double.Parse(linea);
            Console.WriteLine("La cantidad de Puertas que tiene el Auto: ");
            linea = Console.ReadLine();
            cantidadPuertas = int.Parse(linea);
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
        public int cilindrada;
        public Vehículo base2;

        public Moto()
        {
            base2= new Vehículo();
            string linea;
            Console.WriteLine("Poner la marca que tiene el Moto: ");
            base2.Marca = Console.ReadLine();
            Console.WriteLine("La VelocidadMaxima es del Moto: ");
            linea = Console.ReadLine();
            base2.VelocidadMaxima = double.Parse(linea);
            Console.WriteLine("Poner la cantidad de Cilindradra: ");
            linea = Console.ReadLine();
            cilindrada = int.Parse(linea);
        }
        public int Cilindrada
        {
            set
            {
                cilindrada = value;
            }
            get
            {
                return cilindrada;
            }
        }
    }
}
    
    class Prueba
    {
        static void Main(string[] args)
        {
        Moto moto1 = new Moto();
        Auto auto1 = new Auto();
        Console.WriteLine("Datos del Auto: ");
        Console.WriteLine("La Marca del Auto es " + auto1.base1.Marca + "  La Velocidad maxima del Auto es: " + auto1.base1.VelocidadMaxima + "  la cantidad de puertas del Auto es " + auto1.CantidadPuertas);
        Console.WriteLine("Datos de la Moto: ");
        Console.WriteLine("La Marca de la Moto es "+moto1.base2.Marca+"  La Velocidad maxima de la Moto es: "+moto1.base2.VelocidadMaxima+"  El cilindraje de la Moto es "+moto1.Cilindrada);
        Console.ReadKey();
        }
    }
