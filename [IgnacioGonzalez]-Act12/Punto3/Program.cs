using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;

namespace Punto3
{
    internal class Gastronomia
    {
        /*  Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
            una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
                ● Definir un vector para los nombres de los alumnos.
                ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
                presentado.
                ● Métodos:
                        1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
                        de cada alumno.
                        2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
                        3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
                        4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado";
                        (promedio >= 70) o "Reprobado".
                        5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
                        valor máximo de la matriz).
        */
        private string[] NombreAlumnos;
        private int[][] PuntajeObtenido;
        private double[] promedio;



        public void cargarDatos()
        {
            PuntajeObtenido = new int[3][];
            PuntajeObtenido[0] = new int[2];
            PuntajeObtenido[1] = new int[4];
            PuntajeObtenido[2] = new int[3];
            NombreAlumnos = new string[3];
            for (int i = 0; i<NombreAlumnos.Length; i++)
            {
                Console.WriteLine("Cargar el nombre del alumno que hizo " + PuntajeObtenido[i].Length +" platos: ");
                NombreAlumnos[i]= Console.ReadLine();
            }
        }
        public void CargarPuntuaciones()
        {
            int corte = 0;
            for (int i = 0; i < PuntajeObtenido.Length; i++)
            {
                for (int j = 0; j< PuntajeObtenido[i].Length; j++)
                {
                    int datos = 0;
                    Console.WriteLine("El Puntaje del plato " + (j + 1) + " del alumno: " + NombreAlumnos[i] + " es: ");
                    string linea;
                    do
                    {
                        linea = Console.ReadLine();
                        datos =int.Parse(linea);
                        if (datos>100 || datos < 0)
                        {
                            Console.WriteLine("El Puntaje debe estar entre 100 y 0");
                        }else
                            if(datos<=100 && datos >= 0)
                            {
                                PuntajeObtenido[i][j] = datos;
                                break;
                            }
                    } while (corte != 1);
                }
            }
            
        }
        public void MostrarPuntajes()
        {
            for(int i = 0; i< PuntajeObtenido.Length; i++)
            {
                Console.WriteLine("Los Puntajes de los Plato de " + NombreAlumnos[i]+" es: ");
                for( int j = 0; j<PuntajeObtenido [i].Length; j++)
                {
                    Console.WriteLine("El plato: " + (j + 1) + "  Puntaje: " + PuntajeObtenido[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void PromedioAlumno()
        {
            promedio = new double[3];
            
            for (int i = 0; i < PuntajeObtenido.Length; i++)
            {
                int total = 0;
                for (int j = 0; j< PuntajeObtenido[i].Length; j++)
                {
                    total = total + PuntajeObtenido[i][j];
                }
                promedio[i] = (double)total / PuntajeObtenido[i].Length;
            }
            for (int i = 0;i< promedio.Length; i++)
            {
                Console.WriteLine("El Alumno " + NombreAlumnos[i]+" esta: ");
                if (promedio[i] >= 70)
                {
                    Console.Write("Aprobado");
                }else
                    {
                        Console.Write("Reprobado");
                    }
                Console.WriteLine();
            }
        }

        public void PuntajeIndividual()
        {
            //el metodo esta mal redactado, ya que da a entender como si fuera el alumno que saco el puntaje mas alto(es decir 100 o el que tenga mas alto) en un plato, cuando se referia el profe
            //al que saco el promedio mas alto, esto lo pude hacer despues de ir a preguntar porque no entendia.
            double alto = promedio[0];
            int k = 0;
            for (int i = 0; i<promedio.Length; i++)
            {
                if (alto < promedio[i])
                {
                    alto = promedio[i];
                    k = i;
                }
            }
            Console.WriteLine("El Alumno que saco la nota individual mas alta es: " + NombreAlumnos[k] + " su Nota fue: " + alto);
        }


        static void Main(string[] args)
        {
            Gastronomia per1 = new Gastronomia();
            per1.cargarDatos();
            per1.CargarPuntuaciones();
            per1.MostrarPuntajes();
            per1.PromedioAlumno();
            per1.PuntajeIndividual();
            Console.ReadKey();
        }
    }
}
