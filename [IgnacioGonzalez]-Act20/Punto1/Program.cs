using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
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
            Console.WriteLine("Esta en el constructor del Vuelo");
        }
    }
    class VueloInternacional : Vuelo
    {
        protected string paisDestino;
        public string PaisDestino
        {
            set { paisDestino = value; }
            get { return paisDestino; }
        }
        public VueloInternacional(int nV, string d, int dH, string pD) : base(nV, d, dH)
        {
            paisDestino = pD;
            Console.WriteLine("Esta en el constructor del VueloInternacional");
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
        List<VueloInternacional> listadeVuelo = new List<VueloInternacional>();
        public prueba()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el Numero de Vuelo: ");
                string linea;
                linea = Console.ReadLine();
                int nV = int.Parse(linea);
                Console.WriteLine("Poner el Destino del vuelo: ");
                string d = Console.ReadLine();
                Console.WriteLine("Poner la duracion en Horas: ");
                linea = Console.ReadLine();
                int dH = int.Parse(linea);
                Console.WriteLine("Poner el Pais de Destino: ");
                string pD = Console.ReadLine();
                VueloInternacional nuevoVuelo = new VueloInternacional(nV, d, dH, pD);
                listadeVuelo.Add(nuevoVuelo);
            }
            Console.WriteLine("Esta en el constructor del prueba");
        }
        public void mostrarVuelos()
        {
            foreach(VueloInternacional i in listadeVuelo)
            {
                Console.WriteLine("El vuelo es: "+i.NumeroVuelo+" y el pais de destino es: "+i.PaisDestino);
            }
        }
        public void MayorDuracionDeHoras()
        {
            int elMayor = listadeVuelo[0].DuracionHoras;
            int k = 0;
            int h = 0;
            foreach (VueloInternacional i in listadeVuelo)
            {
                if(elMayor < i.DuracionHoras)
                {
                    elMayor = i.DuracionHoras;
                    h = k;
                }
                k++;
            }
            Console.WriteLine("El que mayor tiempo de duracion tiene es: " + listadeVuelo[h].NumeroVuelo +" con duracion de horas totales: "+elMayor);
        }

        static void Main(string[] args)
        {
            prueba prueba1 = new prueba();
            prueba1.mostrarVuelos();
            prueba1.MayorDuracionDeHoras();
            Console.ReadKey();
        }
    }
}
