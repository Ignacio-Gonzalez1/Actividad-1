using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*  Crear una clase parcial Libro.
        En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
        cantidad de páginas sea mayor a 10. Valores cargados desde consola
        En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
        si el libro es corto (menos de 100 páginas) o largo.
        Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.
    */
    class Prueba
    {
        private Libro libro1, libro2;
        public Prueba()
        {
            libro1 = new Libro();
            libro2 = new Libro();
        }

        public void ElMasExtenso()
        {
            if (libro1.Paginas>libro2.Paginas)
            {
                Console.WriteLine("El libro mas extenso es el Libro: " + libro1.Titulo);
            }
            else if (libro1.Paginas < libro2.Paginas)
            {
                Console.WriteLine("El libro mas extenso es el Libro: " + libro2.Titulo);
            }
            else
            {
                Console.WriteLine("Ambos son igual de extenso");
            }
        }
        static void Main(string[] args)
        {
            Prueba prueba = new Prueba();
            prueba.ElMasExtenso();
            Console.ReadKey();
        }
    }
}
