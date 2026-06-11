using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Animal
    {
        protected string especie;
        public Animal()
        {
            especie = "Canis lupus familiaris";
            Console.WriteLine("La Especie del Animal es: "+especie);
            Console.WriteLine("Especie esta en la clase Animal");
        }
        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
    }
    class Mamifero : Animal
    {
        protected string tipoAlimentacion;
        public Mamifero()   
        {
            tipoAlimentacion = "Omnívoros";
            Console.WriteLine("El tipoAlimentacion del Mamifero es: " + tipoAlimentacion);
            Console.WriteLine("tipoAlimentacion esta en la clase Mamifero");
        }
        public string TipoAlimentacion
        {
            set
            {
                tipoAlimentacion = value;
            }
            get
            {
                return tipoAlimentacion;
            }
        }
    }
    class Perro : Mamifero
    {
        public string nombre;
        public Perro()
        {
            nombre = "Chufo";
            Console.WriteLine("El nombre del Perro es: " + nombre);
            Console.WriteLine("Nombre esta en la clase Perro");
        }
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
    }
    class Prueba
    {
        static void Main(string[] args)
        {
            Perro perro1=new Perro();
        }
    }
}
