using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Articulo
    {
        /*  4. Inventario de Sucursales 
                Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
                Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
                Implementar en la clase Sucursal los siguientes métodos:
                    1.Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
                    2.Un método que busque y muestre el nombre del artículo más caro del local.
                    3.Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

        */
        private string NombreArticulo;
        private int StockActual;
        private double Precio;
        public Articulo()
        {
            Console.WriteLine("Cargar el Nombre del Articulo: ");
            NombreArticulo = Console.ReadLine();
            Console.WriteLine("Poner el Precio del Articulo: ");
            string linea;
            linea = Console.ReadLine();
            Precio=int.Parse(linea);
            Console.WriteLine("Poner el Stock Actual del Articulo: ");
            linea = Console.ReadLine();
            StockActual = int.Parse(linea);
        }

        public string retornarNombreArticulo()
        {
            return NombreArticulo;
        }
        public double retornarPrecio()
        {
            return Precio;
        }
        public int retornarStockActual()
        {
            return StockActual;
        }
    }
    class Sucursal
    {
        private Articulo[] ArticulosTotales;
        private string NombreDeLaSurcusal;
        public Sucursal()
        {
            Console.WriteLine("Cargar el Nombre de la Surcusal: ");
            NombreDeLaSurcusal = Console.ReadLine();
            ArticulosTotales = new Articulo[3];
            for (int i = 0; i < ArticulosTotales.Length; i++)
            {
                ArticulosTotales[i] = new Articulo();
            }
        }
        public void Listado()
        {
            Console.WriteLine("Surcusal: " + NombreDeLaSurcusal);
            for (int i = 0;i < ArticulosTotales.Length;i++)
            {
                double total = 0;
                total= (double)ArticulosTotales[i].retornarPrecio() * ArticulosTotales[i].retornarStockActual();
                Console.WriteLine("Nombre del Articulo: "+ ArticulosTotales[i].retornarNombreArticulo()+ " su valor total en inventario es: "+total);
            }
        }
        public void MasCaroDeLaSurcusal()
        {
            Console.WriteLine("Surcusal: " + NombreDeLaSurcusal);
            double masCaro = ArticulosTotales[0].retornarPrecio();
            int j = 0;
            for (int i = 1;i < ArticulosTotales.Length; i++)
            {
                if (masCaro< ArticulosTotales[i].retornarPrecio())
                {
                    masCaro = ArticulosTotales[i].retornarPrecio();
                    j= i;
                }
            }
            Console.WriteLine("El Articulo mas caro de la surcusal es: " + ArticulosTotales[j].retornarNombreArticulo()+" con un precio de: " + masCaro);
        }
        public void ReponerUrgente()
        {
            Console.WriteLine("Los Articulos que se tienen que reponer urgentemente en la surcusal "+NombreDeLaSurcusal+" son: ");
            for (int i = 0; i < ArticulosTotales.Length;i++)
            {
                if (ArticulosTotales[i].retornarStockActual() <= 5)
                {
                    Console.WriteLine("Nombre del articulo: " +ArticulosTotales[i].retornarNombreArticulo()+" su Stock Actual es de: " +ArticulosTotales[i].retornarStockActual()); 
                }
            }
        }


        static void Main(string[] args)
        {
            Sucursal Sucursal1 = new Sucursal();
            Sucursal1.Listado();
            Sucursal1.MasCaroDeLaSurcusal();
            Sucursal1.ReponerUrgente();
            Console.ReadKey();
        }
    }
}
