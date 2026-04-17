using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Evaluacion
    {   
        /*  Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
            sus nombres y puntajes promedio obtenidos (de 1 a 10).
            Cargar sus datos en vectores paralelos, mostrar docente con calificación más
            alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
            calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
            desaprobaron (tomando como base que se aprueba con una nota mayor o igual
            a 6)
        */
        private string[] nombresDocentes;
        private int[] Puntajes;
        private int aprobados, desaprobaron;
        public void CargarDatos()
        {
            nombresDocentes = new string[6];
            Puntajes = new int[6];
            int aux = 0;
            for (int i = 0; i < 6; i++)
            {
                int corte = 0;
                Console.WriteLine("Nombre del Docente: ");
                nombresDocentes[i]=Console.ReadLine();
                string linea;
                do
                {
                    Console.WriteLine("Puntaje Obtenida: ");
                    linea = Console.ReadLine();
                    aux = int.Parse(linea);

                    if (aux >= 1 && aux <= 10)
                    {
                        Puntajes[i]=aux;
                        corte++;
                    }
                    else
                    {
                        Console.WriteLine("El Puntaje esta del 1 al 10");
                    }
                } while (corte != 1);
            }
        }

        public void PuntuacionAltaYbaja()
        {
            for(int p=0; p < Puntajes.Length; p++)
            {
                for (int e=0; e<Puntajes.Length-1 - p; e++)
                {
                    if (Puntajes[e] < Puntajes[e + 1])
                    {
                        int auxPuntuajes;
                        auxPuntuajes = Puntajes[e];
                        Puntajes[e]=Puntajes[e + 1];
                        Puntajes[e+1]=auxPuntuajes;
                        string auxDocentes;
                        auxDocentes = nombresDocentes[e];
                        nombresDocentes[e]= nombresDocentes[e+1];
                        nombresDocentes[e + 1]=auxDocentes;
                    }
                }
            }
        }

        public void AprobadosDesaprobados()
        {
            aprobados = 0;
            desaprobaron = 0;
            for(int k=0;  k<Puntajes.Length; k++)
            {
                if (Puntajes[k] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobaron++;
                }
            }
            
        }
        public void ImprimirTodo()
        {
            Console.WriteLine("El Docente con El Mejor Calificacion es: " + nombresDocentes[0] + "  Puntuacion sacada: " + Puntajes[0]);
            Console.WriteLine("El Docente con El Peor Calificacion es: " + nombresDocentes[5] + "  Puntuacion sacada: " + Puntajes[5]);
            Console.WriteLine("El Order de Mayor a Menor por la calificacion sacada de los docentes: ");
            for(int f = 0; f < Puntajes.Length; f++)
            {
                Console.WriteLine("El Docente: " + nombresDocentes[f] + "  La Calificacion: " + Puntajes[f]);
            }
            Console.WriteLine("Cantidad de Aprobados: " + aprobados);
            Console.WriteLine("Cantidad de Desaprobados: " + desaprobaron);

        }

        static void Main(string[] args)
        {
            Evaluacion per1= new Evaluacion();
            per1.CargarDatos();
            per1.PuntuacionAltaYbaja();
            per1.AprobadosDesaprobados();
            per1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
