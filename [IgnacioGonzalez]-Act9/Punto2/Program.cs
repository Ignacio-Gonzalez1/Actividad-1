using System;
using System.Runtime.InteropServices;

namespace Punto2
{
    internal class Empresa
    {
        /*  Una empresa registra los nombres de sus 5 vendedores y el total de ventas
            realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
            vectores paralelos, ordenar los datos de mayor a menor según las ventas,
            imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
            el que menos vendió de los 5 empleados.
        */
        private string[] vendedores;
        private int[] TotalVentas;
        public void CargarNombresYventas()
        {
            vendedores = new string[5];
            TotalVentas = new int[5];
            for (int i = 0; i < vendedores.Length; i++)
            {
                Console.WriteLine("Escriba El Nombre del Vendedor: ");
                vendedores[i]=Console.ReadLine();

                Console.WriteLine("Escriba El total de Ventas del Vendedor en el Mes: ");
                string linea;
                linea = Console.ReadLine();
                TotalVentas[i]=int.Parse(linea);
            }
        }
        public void MayorAmenor()
        {
            for (int i = 0;i < TotalVentas.Length;i++)
            {
                for (int j = 0;j < TotalVentas.Length - 1 - i;j++)
                {
                    if (TotalVentas[j] < TotalVentas[j + 1])
                    {
                        int auxNota;
                        string auxVendedor;
                        auxNota = TotalVentas[j];
                        TotalVentas[j] = TotalVentas[j+1];
                        TotalVentas[j+1]=auxNota;
                        auxVendedor=vendedores[j];
                        vendedores[j] = vendedores[j + 1];
                        vendedores[j + 1] = auxVendedor;

                    }
                }
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("La Lista ordenada de quien vendio mas por el mes: ");
            for (int k=0; k < vendedores.Length; k++)
            {
                Console.WriteLine("El Vendedor: " + vendedores[k] + "    Monto de Venta: " + TotalVentas[k]);
            }
            Console.WriteLine("El que menos vendio fue: ");
            Console.WriteLine(vendedores[4]);
        }


        static void Main(string[] args)
        {
            Empresa per1 = new Empresa();
            per1.CargarNombresYventas();
            per1.MayorAmenor();
            per1.Imprimir();
            Console.ReadKey();
        }
    }
}
