using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Punto3
{
    /*  Actividad 3: Registro de entrenamientos
        Problema:
        Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
         Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
        1. Uno que reciba horas y minutos y los convierta a minutos.
        2. Otro que reciba directamente los minutos.
         Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
        más corto.
    */
    class Entrenamiento
    {
        private string deportista;
        private int hora, minutos;
        public int Hora
        {
            set { hora = value; }
            get { return hora; }
        }
        public int Minutos
        {
            set { minutos = value; }
            get { return minutos; }
        }
        public string Deportista
        {
            set { deportista = value; }
            get { return deportista; }
        }
        public Entrenamiento(string d, int h, int m)
        {
            deportista = d;
            hora = h;
            minutos = m;
        }

        public double RegistrarDuracion(int h1, int m1)
        {
            hora = h1;
            minutos = m1;
            double duracion = minutos + hora * 60;
            return duracion;
        }
        public double RegistrarDuracion(int m1)
        {
            double duracion = m1;
            return duracion;
        }
    }
    class Prueba
    {
        List<Entrenamiento> ListaDEentrenamientos = new List<Entrenamiento>();
        private double[] duraciones;
        public Prueba()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de deportista: ");
                string d = Console.ReadLine();
                string linea;
                Console.WriteLine("Poner la hora: ");
                linea = Console.ReadLine();
                int h = int.Parse(linea);
                Console.WriteLine("Poner los minutos: ");
                linea = Console.ReadLine();
                int m = int.Parse(linea);
                Entrenamiento nuevaEntrenamiento = new Entrenamiento(d, h, m);
                ListaDEentrenamientos.Add(nuevaEntrenamiento);
            }
        }

        public void entrenamientoMaslargo()
        {
            duraciones = new double[5];
            for (int i = 0; i < 5; i++)
            {
                if (ListaDEentrenamientos[i].Hora <= 0)
                {
                    duraciones[i] = ListaDEentrenamientos[i].RegistrarDuracion(ListaDEentrenamientos[i].Minutos);
                }
                else
                    if (ListaDEentrenamientos[i].Hora > 0)
                    {
                        duraciones[i] = ListaDEentrenamientos[i].RegistrarDuracion(ListaDEentrenamientos[i].Hora, ListaDEentrenamientos[i].Minutos);
                    }
            }
            double elMayor = duraciones[0];
            int ñ = 0;
            for (int i = 1; i < duraciones.Length; i++)
            {
                if (elMayor < duraciones[i])
                {
                    elMayor = duraciones[i];
                    ñ = i;
                }
            }
            Console.WriteLine("El entrenamiento mas largo es: " + ListaDEentrenamientos[ñ].Deportista + " con una duracion de: " + elMayor + " minutos");
        }
        public void entrenamientoMasCorto()
        {
            duraciones = new double[5];
            for (int i = 0; i < 5; i++)
            {
                if (ListaDEentrenamientos[i].Hora <= 0)
                {
                    duraciones[i] = ListaDEentrenamientos[i].RegistrarDuracion(ListaDEentrenamientos[i].Minutos);
                }
                else
                    if (ListaDEentrenamientos[i].Hora > 0)
                    {
                        duraciones[i] = ListaDEentrenamientos[i].RegistrarDuracion(ListaDEentrenamientos[i].Hora, ListaDEentrenamientos[i].Minutos);
                    }
            }
            double Elmenor = duraciones[0];
            int ñ = 0;
            for (int i = 1; i < duraciones.Length; i++)
            {
                if (Elmenor > duraciones[i])
                {
                    Elmenor = duraciones[i];
                    ñ = i;
                }
            }
            Console.WriteLine("El entrenamiento mas corto es: " + ListaDEentrenamientos[ñ].Deportista + " con una duracion de: " + Elmenor + " minutos");
        }

        static void Main(string[] args)
        {
            Prueba prueba1 = new Prueba();
            prueba1.entrenamientoMaslargo();
            prueba1.entrenamientoMasCorto();
            Console.ReadKey();
        }
    }
}