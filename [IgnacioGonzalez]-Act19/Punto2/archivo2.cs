using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("El titulo del libro es: "+Titulo +" El autor del libro es: "+Autor);
            if (Paginas < 100)
            {
                Console.Write(" El libro es corto ya que posee: " + Paginas);
            }
            else
            {
                Console.Write(" El libro es Largo ya que posee: " + Paginas);
            }
        }
    }
}
