using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    /*  Un estacionamiento medido administra el ingreso y la salida de los vehículos que
        utilizan su playa por orden de llegada.
         Crear la clase Ticket que contenga como atributos privados: patente
        (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
        constructor que reciba pat y hs.
         Crear la clase GestionEstacionamiento que administre una lista
        dinámica de tickets (List).
         Métodos en GestionEstacionamiento:
        o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
        agregarlo al final de la lista utilizando .Add().
        o ProcesarSalida(): Si la lista no está vacía, simular la salida del
        primer vehículo de la lista (mostrar sus datos en consola) y
        removerlo de la colección mediante .RemoveAt(0). Si está vacía,
        advertir que no hay vehículos esperando salida.
        o MostrarVehiculosEstacionados(): Listar todos los vehículos
        alojados en la playa y la cantidad total de unidades presentes
        utilizando la propiedad .Count.
    */
    class Ticket
    {
        private string patente;
        private int horasEstadia;
        public string Patente
        {
            get { return patente; }
        }
        public int HorasEstadia
        {
            get { return horasEstadia; }
        }
        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }
    class GestionEstacionamiento
    {
        List<Ticket> ListadoTickect= new List<Ticket>();
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
        }

        public GestionEstacionamiento()
        {
            Console.WriteLine("Poner la cantidad de Ticket: ");
            string linea = Console.ReadLine();
            cantidad=int.Parse(linea);
        }
        public void RegistrarIngreso()
        {
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Poner la Patente: ");
                string pat=Console.ReadLine();
                Console.WriteLine("Poner la Horas de estadia: ");
                string linea=Console.ReadLine();
                int hs = int.Parse(linea);
                Ticket agregarTicket = new Ticket(pat, hs);
                ListadoTickect.Add(agregarTicket);
            }
        }
        public void ProcesarSalida()
        {
            if (cantidad!=0)
            {
                Console.WriteLine("El Vehiculo con patente " + ListadoTickect[0].Patente+" a salido del estacionamiento habiendo estado un total de "+ ListadoTickect[0].HorasEstadia+" Hs");
                ListadoTickect.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay vehiculos esperando para salir");
            }
        }
        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("Los Vehiculos estacionados son: ");
            for (int i = 0; i < ListadoTickect.Count; i++)
            {
                Console.WriteLine("Patente del auto: " + ListadoTickect[i].Patente+" las horas de estadia es: "+ ListadoTickect[i].HorasEstadia);
            }
            Console.WriteLine("La cantidad de Vehiculos Presentes son: "+ListadoTickect.Count);
        }
        static void Main(string[] args)
        {
            GestionEstacionamiento gestion = new GestionEstacionamiento();
            gestion.RegistrarIngreso();
            gestion.ProcesarSalida();
            gestion.MostrarVehiculosEstacionados();
            Console.ReadKey();
        }
    }
}
