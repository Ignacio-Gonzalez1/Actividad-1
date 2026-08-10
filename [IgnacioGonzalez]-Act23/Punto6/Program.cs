﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    /*
        Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
        para organizar la consulta de ejemplares por parte de los lectores.
         Crear la clase Libro que contenga como atributos privados: titulo
        (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
        un constructor que reciba tit y anio.
         Crear la clase BibliotecaCentral que administre una lista de objetos
        List.
         Métodos en BibliotecaCentral:
        1. CargarCatalogo(): Solicitar por teclado títulos y años de
        publicación para agregar libros a la lista mediante .Add(). La carga
        finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
        2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
        junto a la cantidad total de obras registradas mediante la propiedad
        .Count.
        3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
        imprimir en consola únicamente aquellos libros cuyo año de
        publicación sea menor a dicho valor.
        4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
        los métodos de búsqueda y remoción de listas, eliminarlo de la
        colección si se encuentra presente.
    
    */
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
                Console.WriteLine("Poner el Anio de publicacion (ejem: 2019): ");
                linea= Console.ReadLine();
                int anio = int.Parse(linea);
                Libro AgregarLibro = new Libro(tit, anio);
                ListadoLibro.Add(AgregarLibro);

            }
            while (true);
        }
        public void ListarCatalogo()
        {
            Console.WriteLine("Los libros del Catalogo son:");
             foreach (Libro item in ListadoLibro)
            {
                Console.WriteLine("El Nombre del Libro: "+item.Titulo +" El Anio de Publicacion del Libro: "+item.AnioPublicacion);
            }
            Console.WriteLine("La cantidad total de Libros en el catalogo es: "+ListadoLibro.Count());
        }
        public void FiltrarPorAnio()
        {
            Console.WriteLine("Poner Un Anio y Te daremos los libros que salieron antes de ese anio: ");
            string linea = Console.ReadLine();
            int SacarAnio=int.Parse(linea);
            foreach (Libro item in ListadoLibro)
            {
                if (item.AnioPublicacion < SacarAnio)
                {
                    Console.WriteLine("Libro: " + item.Titulo +" Anio de Publicacion: "+item.AnioPublicacion);
                }
            }
        }
        public void RemoverLibro()
        {
            Console.WriteLine("Poner Un titulo de un Libro para eliminarlo: ");
            string linea = Console.ReadLine().ToLower();
            Libro aux=null;
            foreach (Libro item in ListadoLibro)
            {
                if (item.Titulo == linea)
                {
                    aux = item;
                    break;
                }
            }
            if (aux != null)
            {
                ListadoLibro.Remove(aux);
                Console.WriteLine("Se confirma la Eliminacion del Libro: "+aux.Titulo);
            }
            if(aux==null)
            {
                Console.WriteLine("Ese Libro no fue encontrado.");
            }
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
