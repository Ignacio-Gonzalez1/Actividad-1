using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    class Libro
    {
        private string titulo;
        private int anioPublicacion;
        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public int AnioPublicacion
        {
            set {  anioPublicacion = value; }
            get { return anioPublicacion; }
        }
        public Libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }
    }
    class BibliotecaCentral
    {
        List<Libro> ListadoLibro=new List<Libro>();
        public void CargarCatalogo()
        {
            do
            {
                Console.WriteLine("Poner titulo del Libro: ");
                string linea= Console.ReadLine().ToLower();
                string tit;
                if (linea == "fin")
                {
                    break;
                }
                else
                {
                    tit = linea;
                }
                Console.WriteLine("Poner el Año de publicacion: ");
                linea= Console.ReadLine();
                int anio = int.Parse(linea);
                Libro AgregarLibro = new Libro(tit, anio);
                ListadoLibro.Add(AgregarLibro);

            }
            while (true);
        }
        public void ListarCatalogo()
        {

        }
        public void FiltrarPorAnio()
        {

        }
        public void RemoverLibro()
        {

        }
        static void Main(string[] args)
        {
            BibliotecaCentral biblioteca=new BibliotecaCentral();
            biblioteca.CargarCatalogo();
            biblioteca.ListarCatalogo();
            biblioteca.FiltrarPorAnio();
            biblioteca.RemoverLibro();
            Console.ReadKey();
        }
    }
}
