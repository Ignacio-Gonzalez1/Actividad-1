using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        private string titulo;
        private string autor;
        private int paginas;
        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public string Autor
        {
            set { autor = value;}
            get { return autor; }
        }
        public int Paginas
        {
            set { paginas = value; }
            get { return paginas; }
        }
        public Libro()
        {
            Console.WriteLine("Poner el titulo del libro: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Poner el Autor del libro: ");
            autor = Console.ReadLine();
            Console.WriteLine("Poner cuantas paginas tiene el libro: ");
            do
            {
                string linea;
                linea = Console.ReadLine();
                if (int.Parse(linea)>10)
                {
                    paginas = int.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("Debe tener mas de 10 paginas");
                }
            }while (true);
        }
    }
}
