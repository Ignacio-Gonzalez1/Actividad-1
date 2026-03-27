using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.
            int precio, cantidad, costo;
            string linea;

                Console.Write("Ingrese el precio del producto: ");
                linea = Console.ReadLine();
                precio = int.Parse(linea);


                Console.Write("Ingrese la cantidad del producto: ");
                linea = Console.ReadLine();
                cantidad = int.Parse(linea);


                costo= precio * cantidad;


            Console.WriteLine("Precio del producto individual es: ");
            Console.WriteLine(precio);
            Console.WriteLine("Cantidad del Producto es: ");
            Console.WriteLine(cantidad);
            Console.WriteLine("Cuesta en total: ");
            Console.WriteLine(costo);


            Console.ReadKey();
        }
    }
}
