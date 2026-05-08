using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Empresa
    {
        /*  Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
            cantidad diferente de paquetes por día dependiendo de su demanda.
                ● Definir un vector de tipo string para los nombres de las 3 sucursales.
                ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
                represente el peso (en kg) de cada paquete enviado.
                ● Métodos:
                        1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
                        paquetes se enviaron hoy para definir el tamaño de su fila.
                        2. Cargar el peso de cada paquete.
                        3. Imprimir el peso de todos los paquetes organizados por sucursal.
                        4. Calcular e informar el peso total despachado por cada sucursal.
                        5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
                        pertenece.
        */
        private string[] NombresSurcusales;
        private int[][] Surcusal;
        private int[] PesosTotales;
        public void NombresYCantidadDeKg()
        {
            NombresSurcusales = new string[3];
            Surcusal = new int[3][];
            int cantidad = 0;
            for (int i = 0; i< NombresSurcusales.Length; i++)
            {
                Console.WriteLine("El nombre de la Surcusal");
                NombresSurcusales[i]= Console.ReadLine();
            }
           for (int i = 0;i< NombresSurcusales.Length; i++)
            {
                Console.WriteLine("Poner la cantidad de paquetes que se enviaron de la Surcusal: " + NombresSurcusales[i]);
                string linea;
                linea = Console.ReadLine();
                cantidad=int.Parse(linea);
                Surcusal[i] = new int[cantidad];
            }
        }
        public void CargarDatos()
        {
            for (int i = 0; i < Surcusal.Length; i++)
            {
                Console.WriteLine("Poner Paquetes de la surcusal: " + NombresSurcusales[i]);
                for (int j = 0; j < Surcusal[i].Length; j++)
                {
                    Console.WriteLine("Poner el Peso de la caja: ");
                    string linea;
                    linea = Console.ReadLine();
                    Surcusal[i][j]= int.Parse(linea);
                }
                Console.WriteLine();
            }
        }
        public void ImprimirTodo()
        {
            for (int i = 0; i < Surcusal.Length; i++)
            {
                Console.WriteLine("La Surcusal: " + NombresSurcusales[i]);
                for (int j = 0; j < Surcusal[i].Length; j++)
                {
                    Console.Write(" "+Surcusal[i][j]+"Kg"+" ");
                }
                Console.WriteLine();
            }
        }
        public void CalcularYInformarPesoTotal()
        {
            PesosTotales = new int[3];
            for (int i = 0;i < Surcusal.Length; i++)
            {
                int pesoTotal = 0;
                for (int j = 0; j< Surcusal[i].Length; j++)
                {
                    pesoTotal = Surcusal[i][j] + pesoTotal;
                }
                PesosTotales[i]= pesoTotal;
            }
            Console.WriteLine("Los pesos Totales de cada Surcusal es: ");
            for (int i = 0; i<Surcusal.Length ; i++)
            {
                Console.WriteLine("El peso total de las cajas de la surcusal " + NombresSurcusales[i] + "  es: " + PesosTotales[i] + "Kg");
            }
        }
        public void PesoMayor()
        {
            int paqueteMayor = Surcusal[0][0];
            int nombreMayor=0;
            for(int i = 0;i < Surcusal.Length; i++)
            {
                for (int j = 0; j < Surcusal[i].Length; j++)
                {
                    if(paqueteMayor< Surcusal[i][j])
                    {
                        paqueteMayor = Surcusal[i][j];
                        nombreMayor=i;
                    }
                }
            }
            Console.WriteLine("El Paquete mas pesado es: "+paqueteMayor+ "Kg y es de la surcusal: "+ NombresSurcusales[nombreMayor]);
        }

        static void Main(string[] args)
        {
            Empresa surcusal1 = new Empresa();
            surcusal1.NombresYCantidadDeKg();
            surcusal1.CargarDatos();
            surcusal1.ImprimirTodo();
            surcusal1.CalcularYInformarPesoTotal();
            surcusal1.PesoMayor();
            Console.ReadKey();
        }
    }
}
