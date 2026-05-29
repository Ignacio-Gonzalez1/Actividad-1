using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto2
{
    class Pasajero
    {
        /*  Control de Vuelos
            Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
            Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
            Agregar los siguientes métodos en la clase Vuelo:
                Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
                Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
                Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.

        */
        private string Nombre;
        private int Dni, EquipajeKilos;
        public Pasajero()
        {
            Console.WriteLine("Cargar el Nombre del pasajero: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Poner el Dni: ");
            string linea;
            linea= Console.ReadLine();
            Dni=int.Parse(linea);
            Console.WriteLine("Poner los Kg que pesa tu equipaje (ya esta en Kg): ");
            linea= Console.ReadLine();
            EquipajeKilos=int.Parse(linea);
        }
        public string retornarNombre()
        {
            return Nombre;
        }
        public int retornarDNI()
        {
            return Dni;
        }
        public int retornarEquipajeKilos()
        {
            return EquipajeKilos;
        }
    }
    class Vuelo
    {
        private Pasajero[] PasajerosTotal;

        public Vuelo()
        {
            PasajerosTotal = new Pasajero[4];
            for (int i = 0; i < PasajerosTotal.Length; i++)
            {
                PasajerosTotal[i]=new Pasajero();
            }
        }
        public void ListadoCompleto()
        {
            for (int i = 0;i < PasajerosTotal.Length;i++)
            {
                Console.WriteLine("El Pasajero: "+(i+1));
                Console.WriteLine("El Nombre del Pasajero: " + PasajerosTotal[i].retornarNombre());
                Console.WriteLine("El Dni del Pasajero: " + PasajerosTotal[i].retornarDNI());
                Console.WriteLine("Los kilos del Equipaje del Pasajero: " + PasajerosTotal[i].retornarEquipajeKilos()+"kg");

            }
        }
        public void PesoTotalEquipajes()
        {
            int pesototal=0;
            for (int i = 0;i < PasajerosTotal.Length ; i++)
            {
                pesototal = pesototal + PasajerosTotal[i].retornarEquipajeKilos();
            }
            Console.WriteLine("El peso total de Equipajes que transporta el Avion es: "+pesototal);
        }
        public void ExcedeElpeso()
        {
            Console.WriteLine("Los pasajeros que excedieron el peso son: ");
            for(int i = 0; i < PasajerosTotal.Length; i++)
            {
                if (PasajerosTotal[i].retornarEquipajeKilos()>23)
                {
                    Console.WriteLine("El nombre del pasajero: " + PasajerosTotal[i].retornarNombre() + " DNI: " + PasajerosTotal[i].retornarDNI());
                }
            }
        }






        static void Main(string[] args)
        {
            Vuelo vuelo1 = new Vuelo();
            vuelo1.ListadoCompleto();
            vuelo1.PesoTotalEquipajes();
            vuelo1.ExcedeElpeso();
            Console.ReadKey();
        }
    }
}
