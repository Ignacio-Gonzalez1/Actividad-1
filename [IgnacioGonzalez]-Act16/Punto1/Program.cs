using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Persona
    {
        /*  Confeccionar una clase Persona que tenga como atributos el nombre y la
            edad (definir las propiedades para poder acceder a dichos atributos). Definir
            un método para imprimirlos. Plantear una segunda clase Empleado que
            herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
            método para imprimir su sueldo. Definir un objeto de la clase Persona y
            llamar a sus métodos y propiedades. También crear un objeto de la clase
            Empleado y llamar a sus métodos y propiedades.
        */
        protected string nombre;
        protected int edad;

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
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("La persona :"+ Nombre + " tiene una edad: "+Edad);
        }

    }
    class Empleado : Persona
    {
        protected double sueldo;

        public double Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public void ImprimirSueldo()
        {
            Console.WriteLine("Su sueldo es de: "+Sueldo);
        }
    }
     class Prueba
    {
        static void Main(string[] args)
        {
            Persona persona1= new Persona();
            persona1.Nombre = "Emiliano";
            persona1.Edad = 2022;
            persona1.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Santino";
            empleado1.Edad =17;
            empleado1.Sueldo = 2000.10 ;
            empleado1.Imprimir();
            empleado1.ImprimirSueldo(); 
            Console.ReadKey();
        }
    }
}
