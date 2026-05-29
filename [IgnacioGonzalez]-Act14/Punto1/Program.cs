using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Vehiculo
    {
        /*  1. El Sistema de Peaje.
            Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
            La clase Vehiculo debe tener los siguientes atributos privados:
                Patente (de tipo string).
                Tipo (puede ser "Auto", "Camion" o "Moto").
                Tarifa (un valor decimal que representa el costo de su pase).
            El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
            La clase CabinaPeaje debe tener como atributos privados:
                El número o identificador de la cabina.
                Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
            Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
                Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
                Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
                Un método que muestre la patente del vehículo que pagó la tarifa más cara.

        */
        private string Patente, Tipo;
        private int Tarifa;
        public Vehiculo()
        {
            Console.WriteLine("Cargar la Petente del auto: ");
            Patente = Console.ReadLine();
            Console.WriteLine("Cargar el tipo de Vehiculo: ");
            int corte = 0;
            string linea;
            do
            {
                linea= Console.ReadLine();
                Tipo = linea.ToLower();
                if (Tipo == "auto" || Tipo=="camion"||Tipo=="moto")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Solo se permite los vehiculos como moto, auto o camion, Cambie lo escrito");
                }
            } while (corte != 1);
            Console.WriteLine("Poner la Tarifa del Vehiculo: ");
            linea = Console.ReadLine();
            Tarifa=int.Parse(linea);
        }
        public string retornarPatente()
        {
            return Patente;
        }
        public string retornarTipo()
        {
            return Tipo;
        }
        public int retornarTarifa()
        {
            return Tarifa;
        }
    }
    class CabinaPeaje
    {
        private Vehiculo Vehiculo1, Vehiculo2, Vehiculo3;
        private int Identificador;
        public CabinaPeaje()
        {
            Vehiculo1 = new Vehiculo();
            Vehiculo2 = new Vehiculo();
            Vehiculo3 = new Vehiculo();
            Identificador = 1;
        }
        public void ImprimirPatenteYTipoAuto()
        {
            Console.WriteLine("La Patentes y tipos de autos de la cabina: "+Identificador);
            Console.WriteLine("El tipo del Vehiculo1 es " + Vehiculo1.retornarTipo() + " La patente de ese Vehiculo es: " + Vehiculo1.retornarPatente());
            Console.WriteLine("El tipo del Vehiculo2 es " + Vehiculo2.retornarTipo() + " La patente de ese Vehiculo es: " + Vehiculo2.retornarPatente());
            Console.WriteLine("El tipo del Vehiculo3 es " + Vehiculo3.retornarTipo() + " La patente de ese Vehiculo es: " + Vehiculo3.retornarPatente());
        }
        public void RecaudacionTotal()
        {
            Console.WriteLine("La Cabina es: "+Identificador);
            int total = 0;
            total = Vehiculo1.retornarTarifa() + Vehiculo2.retornarTarifa() + Vehiculo3.retornarTarifa();
            Console.WriteLine("La Recaudacion total de esos 3 Vehiculos es: "+total);
        }
        public void TarifaAlta()
        {
            Console.WriteLine("La Cabina es: " + Identificador);
            int tarifaMasAlta = Vehiculo1.retornarTarifa();
            string PatenteConMayorTarifa=Vehiculo1.retornarPatente();
            if(tarifaMasAlta< Vehiculo2.retornarTarifa())
            {
                tarifaMasAlta = Vehiculo2.retornarTarifa();
                PatenteConMayorTarifa = Vehiculo2.retornarPatente();
            }
            if (tarifaMasAlta < Vehiculo3.retornarTarifa())
            {
                tarifaMasAlta = Vehiculo3.retornarTarifa();
                PatenteConMayorTarifa = Vehiculo3.retornarPatente();
            }
            Console.WriteLine("La patente de auto con mayor tarifa es: "+PatenteConMayorTarifa+" teniendo una tarifa de "+tarifaMasAlta);
        }
        static void Main(string[] args)
        {
            CabinaPeaje Cabina1 = new CabinaPeaje();
            Cabina1.ImprimirPatenteYTipoAuto();
            Cabina1.RecaudacionTotal();
            Cabina1.TarifaAlta();
            Console.ReadKey();
        }
    }
}
