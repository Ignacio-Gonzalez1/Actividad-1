using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Temperatura
    {
        /*  1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
            dato las temperaturas medias mensuales de dichos paises.
            Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
            mensuales.
            Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
            memoria.
                a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
                b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
                mismas.
                c. Calcular la temperatura media trimestral de cada país.
                d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
                e. Imprimir el nombre del país con la temperatura media trimestral mayor.
        */
        private int[,] TemperaturasMen;
        private double[] TemperaturaTrimestral;
        private string[] Paises;
        public void CargarDatos()
        {
            TemperaturasMen = new int[4,3];
            Paises = new string[4];
            for (int i = 0; i < TemperaturasMen.GetLength(0); i++)
            {
                Console.WriteLine("Nombre del Pais: ");
                Paises[i]=Console.ReadLine();
                for (int j = 0; j < TemperaturasMen.GetLength(1); j++)
                {
                    Console.WriteLine("Poner la Temperatura Media Mensual del Pais");
                    string linea;
                    linea = Console.ReadLine();
                    TemperaturasMen[i,j]=int.Parse(linea);
                    
                }
            }
        }
        public void ImprimirNombresYTempMen()
        {
            Console.WriteLine("Los Paises y las temperaturas medias mensuales de los 3 Meses: ");
            for (int i = 0; i < TemperaturasMen.GetLength(0); i++)
            {
                Console.Write("Nombre del Pais: " + Paises[i] + "  Sus Temperaturas son: ");
                for (int j = 0; j < TemperaturasMen.GetLength(1); j++)
                {
                    Console.Write(" " + TemperaturasMen[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void CalcularTemperaturaMediaTrimestral()
        {
            
            TemperaturaTrimestral = new double[4];
            for (int i = 0; i < TemperaturasMen.GetLength(0); i++)
            {
                int Todo = 0;
                double promedio = 0;
                for (int j = 0; j < TemperaturasMen.GetLength(1); j++)
                {
                    Todo = TemperaturasMen[i, j] + Todo;
                }
                promedio = (double)Todo / 3;
                TemperaturaTrimestral[i] = promedio; 
            }
        }
        public void NombresYTempMediaTrimestral()
        {
            Console.WriteLine("Los Paises y las temperaturas medias trimestrales: ");
            for (int i = 0; i < TemperaturasMen.GetLength(0); i++)
            {
                Console.Write("Nombre del Pais: " + Paises[i] + "  Sus Temperaturas Media Trimestrales son: " + TemperaturaTrimestral[i]);
                Console.WriteLine();
            }
        }
        public void NombreDelTepMediaTriMayor()
        {
            double mayor = TemperaturaTrimestral[0];
            int guardar = 0;
            Console.WriteLine("El que tiene la temperatura media trimestral mayor es: ");
            for (int i = 1; i < TemperaturasMen.GetLength(0); i++)
            {
                if (mayor < TemperaturaTrimestral[i])
                {
                    mayor= TemperaturaTrimestral[i];
                    guardar = i;
                }
            }
            Console.WriteLine(Paises[guardar] + "  Su temperatura media trimestral es: " + TemperaturaTrimestral[guardar]);
        }
        static void Main(string[] args)
        {
            Temperatura pais1=new Temperatura();
            pais1.CargarDatos();
            pais1.ImprimirNombresYTempMen();
            pais1.CalcularTemperaturaMediaTrimestral();
            pais1.NombresYTempMediaTrimestral();
            pais1.NombreDelTepMediaTriMayor();
            Console.ReadKey();
        }
    }
}
