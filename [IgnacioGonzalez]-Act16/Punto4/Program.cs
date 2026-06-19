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
        public Animal(string e) 
        {
            especie = e;
            Console.WriteLine("La Especie del Animal es: "+especie);
            Console.WriteLine("Especie esta en la clase Animal");
        }
        
    }
    class Mamifero : Animal
    {
        protected string tipoAlimentacion;
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
        public Mamifero(string e, string tA) : base (e) 
        {
            tipoAlimentacion = tA;
            Console.WriteLine("El tipoAlimentacion del Mamifero es: " + tipoAlimentacion);
            Console.WriteLine("tipoAlimentacion esta en la clase Mamifero");
        }
        
    }
    class Perro : Mamifero
    {
        public string nombre;
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
        public Perro(string e, string tA, string n) : base (e, tA)
        {
            nombre = n;
            Console.WriteLine("El nombre del Perro es: " + nombre);
            Console.WriteLine("Nombre esta en la clase Perro");
        }
        
    }
    class Prueba
    {
        static void Main(string[] args)
        {
            Perro perro1=new Perro("Canis lupus familiaris", "Omnívoros","Chufo");
        }
    }
}
