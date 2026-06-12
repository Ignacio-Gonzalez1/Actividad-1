using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Pelicula
    {
        /*  2. Catálogo de Películas (Encapsulación, Validación y Composición)
            Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
            La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
            (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
            asegurando mediante validaciones lógicas que:
                 La duración en minutos sea estrictamente mayor a cero (0).
                 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
                  un valor por defecto de 1).
            La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
            la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
            películas ordenadas de mayor a menor en base a su duración. Además, el método debe
            informar el título de la película con mejor calificación y cuál es la película más corta del
            catálogo.
        */
        private string titulo;
        private int duracionMinutos;
        private int calificacion;
        public Pelicula()
        {
            Console.WriteLine("Poner el Titulo de la pelicula: ");
            titulo = Console.ReadLine();
            string linea;
            do
            {

                Console.WriteLine("Poner el duracion (en Minutos) de la pelicula: ");
                linea = Console.ReadLine();
                if (int.Parse(linea)>0)
                {
                    duracionMinutos = int.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("La duracion debe ser mayor a 0");
                }

            }while (true);
            Console.WriteLine("Poner la Calificacion de la pelicula: ");
            linea= Console.ReadLine();
            if (int.Parse(linea) > 5)
            {
                calificacion = 1;
            }
            else
            {
                calificacion= int.Parse(linea);
            }
        }
        public string Titulo
        {
            set 
            {
                titulo = value; 
            }
            get
            {
                return titulo;
            }

        }

        public int DuracionMinutos
        {
            set
            {
                duracionMinutos = value;
            }
            get
            {
                return duracionMinutos;
            }
        }
        public int Calificacion
        {
            set
            {
                calificacion = value;
            }
            get
            {
                return calificacion;
            }
        }


    }
    class Catalogo
    {
        private Pelicula[] TotalDePelicula;
        public Catalogo()
        {
            TotalDePelicula = new Pelicula[3];
            for (int i = 0; i < TotalDePelicula.Length; i++)
            {
                TotalDePelicula[i] = new Pelicula();
            }
        }
        public void MostrarEnPantallaMayorAmenor()
        {
            Pelicula aux;
            for (int i = 0;i < TotalDePelicula.Length - 1; i++)
            {
                for(int j = 0;j < TotalDePelicula.Length - 1 - i; j++)
                if (TotalDePelicula[j].DuracionMinutos < TotalDePelicula[j + 1].DuracionMinutos)
                {
                        aux = TotalDePelicula[j];
                        TotalDePelicula[j]=TotalDePelicula[j+1];
                        TotalDePelicula[j+1]=aux;
                }
            }
            Console.WriteLine("Las peliculas ordenadas de Mayor tiempo de duracion al menor: ");
            for (int i = 0; i < TotalDePelicula.Length; i++)
            {
                Console.WriteLine("La Pelicula es : " + TotalDePelicula[i].Titulo +" La duracion de la pelicula es: "+TotalDePelicula[i].DuracionMinutos+" Minutos "+" Su calificacion es: "+ TotalDePelicula[i].Calificacion);
            }
        }
        public void PeliculaMayorCalificacion()
        {
            int mayor = TotalDePelicula[0].Calificacion;
            int l = 0;
            for (int i = 0;i < TotalDePelicula.Length;i++)
            {
                if (mayor < TotalDePelicula[i].Calificacion)
                {
                    mayor = TotalDePelicula[i].Calificacion;
                    l = i;
                }
            }
            Console.WriteLine("La Pelicula con mayor calificacion es: " + TotalDePelicula[l].Titulo +" con una calificacion de: "+ mayor);
        }
        public void peliculacorta()
        {
            int corto = TotalDePelicula[0].DuracionMinutos;
            int l = 0;
            for (int i = 0;i<TotalDePelicula.Length; i++)
            {
                if (TotalDePelicula[i].DuracionMinutos < corto)
                {
                    corto = TotalDePelicula[i].DuracionMinutos;
                    l = i;
                }
            }
            Console.WriteLine("La pelicula mas corta es "+ TotalDePelicula[l].Titulo+ " con una duracion de :" + corto+" Minutos");
        }
        static void Main(string[] args)
        {
            Catalogo catalogo1 = new Catalogo();
            catalogo1.MostrarEnPantallaMayorAmenor();
            catalogo1.PeliculaMayorCalificacion();
            catalogo1.peliculacorta();
            Console.ReadKey();
        }
    }
}
