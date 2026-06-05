using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Producto
    {
        /*  Plantear una clase Producto y otra clase Inventario.
            La clase Producto debe tener como atributos privados el nombre, precio y
            stock. Definir propiedades para acceder a estos atributos, asegurando que el
            stock no pueda ser negativo y el precio sea mayor a cero.
            La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
            método para mostrar todos los productos ordenados de menor a mayor en
            base al precio, además, mostrar el producto más caro y más barato del
            inventario.
        */
        private string nombre;
        private double precio;
        private int stock;
        public Producto()
        {
            Console.WriteLine("Poner el Nombre del Producto");
            nombre = Console.ReadLine();
            int corte = 0;
            do
            {
                Console.WriteLine("Poner el Precio del Producto: ");
                string linea;
                linea = Console.ReadLine();
                
                if (double.Parse(linea) > 0)
                {
                    precio = double.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("Poner un Precio que sea Mayor a 0");
                }
            } while (corte != 1);
            do
            {
                Console.WriteLine("Poner el Stock del Producto: ");
                string linea;
                linea = Console.ReadLine();

                if (int.Parse(linea) >=0)
                {
                    stock = int.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("El Stock no puede ser negativo");
                }
            } while (corte != 1);
        }
        public string Nombre
        {
            set
            {
                nombre=value;
            }
            get
            {
                return nombre;
            }
        }
        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }
        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }
    }
    class Inventario
    {
        private Producto[] TotalProductos;
        public Inventario()
        {
            TotalProductos = new Producto[3];
            for (int i = 0; i < TotalProductos.Length; i++)
            {
                TotalProductos[i] = new Producto();
            }
        }
        public void MenorAMayor()
        {
            Producto aux;
            for (int i = 0; i < TotalProductos.Length - 1; i++)
            {
                for (int j = 0; j < TotalProductos.Length - 1 - i; j++)
                {
                    if (TotalProductos[j].Precio > TotalProductos[j + 1].Precio)
                    {
                        aux = TotalProductos[j];
                        TotalProductos[j] = TotalProductos[j + 1];
                        TotalProductos[j + 1] = aux;
                        
                    }
                }
            }
            Console.WriteLine("El Orden de los Productos de Menor a Mayor: ");
            for (int i = 0;i < TotalProductos.Length;i++)
            {
                Console.WriteLine("El Producto es: " + TotalProductos[i].Nombre + "  El precio del Producto es: "+ TotalProductos[i].Precio + "  El Stock del Producto es: " + TotalProductos[i].Stock);
            }
        }

        public void MasCaro()
        {
            double Mayor = TotalProductos[0].Precio;
            int h = 0;
            for (int i = 0; i<TotalProductos.Length ; i++)
            {
                if (Mayor < TotalProductos[i].Precio)
                {
                    Mayor = TotalProductos[i].Precio;
                    h = i;
                }
            }
            Console.WriteLine("El Producto que tiene el Mayor precio es: "+ TotalProductos[h].Nombre +" Con un precio de: " + Mayor);
        }
        public void Menoscaro()
        {
            double Menor = TotalProductos[0].Precio;
            int h = 0;
            for (int i = 0; i < TotalProductos.Length; i++)
            {
                if (Menor > TotalProductos[i].Precio)
                {
                    Menor = TotalProductos[i].Precio;
                    h = i;
                }
            }
            Console.WriteLine("El Producto que tiene el Menor precio es: " + TotalProductos[h].Nombre + " Con un precio de: " + Menor);
        }

        static void Main(string[] args)
        {
            Inventario inventario1=new Inventario();
            inventario1.MenorAMayor();
            inventario1.MasCaro();
            inventario1.Menoscaro();
            Console.ReadKey();
        }
    }
}
