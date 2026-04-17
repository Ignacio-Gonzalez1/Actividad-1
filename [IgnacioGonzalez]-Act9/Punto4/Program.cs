using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
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
        private int[] Puntaje;
        private int arpobados, desaprobaron, Mayor, Bajo,numeroMayor, numeroBajo;
        public void CargarDatos()
        {
            nombresDocentes = new string[6];
            Puntaje = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Nombre del Docente: ");
                nombresDocentes=Console.ReadLine();

            }

        }
        static void Main(string[] args)
        {
        }
    }
}
