using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class PersonaGimnasio
    {
        /*  1.  Personal de un Gimnasio (Herencia Simple y Propiedades)
                Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
                Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
                método para imprimir estos datos básicos.
                Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
                un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
                para imprimir todos los datos del profesor (incluyendo los heredados).
                En el programa principal (Main):
                   - Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
                     llamar a su método de impresión.
                   - Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
                     que puede acceder tanto a sus métodos propios como a los de la clase base.
        */
        protected string nombre;
        protected int dni;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get 
            { 
                return nombre;
            }
        }
        public int Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("El nombre de Persona del Gimnasio es: "+ Nombre);
            Console.WriteLine("El dni de Persona del Gimnasio es: " + Dni);
        }


    }
    class Profesor : PersonaGimnasio
    {
        private string especialidad;
        public string Especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }
       
        public void ImprimirDatosProfe()
        {
            Console.WriteLine("El nombre de Profesor del Gimnasio es: " + Nombre);
            Console.WriteLine("El dni de Profesor del Gimnasio es: " + Dni);
            Console.WriteLine("La Especialidad del Profesor es: "+ Especialidad);
        }



    }
    class Prueba
    {
        static void Main(string[] args)
        {
            PersonaGimnasio persona1 = new PersonaGimnasio();
            persona1.Nombre = "Marcelo";
            persona1.Dni = 5;
            persona1.Imprimir();
            Profesor profesor1 = new Profesor();
            profesor1.Nombre = "Pablo";
            profesor1.Dni = 10;
            profesor1.Especialidad = "Musculación e Hipertrofia";
            profesor1.ImprimirDatosProfe();
            Console.ReadKey();
        }
    }
}
