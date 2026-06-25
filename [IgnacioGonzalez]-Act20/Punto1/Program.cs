using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Vuelo
    {
        protected int numeroVuelo;
        protected string destino;
        protected int duracionHoras;
        public int NumeroVuelo
        {
            set { numeroVuelo = value; }
            get { return numeroVuelo; }
        }
        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }
        public int DuracionHoras
        {
            set { duracionHoras = value; }
            get { return duracionHoras; }
        }
        public Vuelo(int nV, string d, int dH)
        {
            numeroVuelo = nV;
            destino = d;
            duracionHoras = dH;
        }
    }
    class VueloInternacional : Vuelo
    {
        protected string paisDestino;
        List<VueloInternacional> listadeVuelo = new List<VueloInternacional>();

        public string PaisDestino
        {
            set { paisDestino = value; }
            get { return paisDestino; }
        }
        public VueloInternacional(int nV, string d, int dH, string pD) : base(nV, d, dH)
        {
            paisDestino = pD;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el Numero de Vuelo: ");
                string linea;
                linea = Console.ReadLine();
                nV = int.Parse(linea);
                Console.WriteLine("Poner el Destino del vuelo: ");
                d = Console.ReadLine();
                Console.WriteLine("Poner la duracion en Horas: ");
                linea = Console.ReadLine();
                dH = int.Parse(linea);
                Console.WriteLine("Poner el Pais de Destino: ");
                pD = Console.ReadLine();
                VueloInternacional nuevoVuelo = new VueloInternacional(nV, d, dH, pD);
                listadeVuelo.Add(nuevoVuelo);
            }
        }
    }
    class prueba
    {
        /*  Actividad 1: Sistema de control de vuelos
            Problema:
            Una aerolínea administra los vuelos programados mediante un sistema orientado a
            objetos.
            Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
            destino y duración en horas. Luego definir una clase derivada VueloInternacional que
            herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
            Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
            desde consola y luego:
                 Mostrar los vuelos registrados y el país de destino.
                 Informar cuál es el vuelo con mayor duración.
                 Mostrar el orden de ejecución de los constructores.
        */
        static void Main(string[] args)
        {
        }
    }
}
