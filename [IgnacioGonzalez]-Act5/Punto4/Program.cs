using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor.
            */
            float EdadMañana, EdadTarde, EdadNoche, cantidadMañana, cantidadTarde, cantidadNoche;
            double promediosTarde, promediosNoche, promediosMañana;
            string linea;
            cantidadMañana = 0;
            cantidadNoche = 0;
            cantidadTarde = 0;
            promediosNoche = 0;
            promediosMañana = 0;
            promediosTarde = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Escribe la Edad de un Alumno de la Mañana: ");
                linea = Console.ReadLine();
                EdadMañana=float.Parse(linea);
                cantidadMañana = cantidadMañana + EdadMañana;
            }
            promediosMañana = cantidadMañana / 20;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Escribe la Edad de un Alumno de la Tarde: ");
                linea = Console.ReadLine();
                EdadTarde = float.Parse(linea);
                cantidadTarde = cantidadTarde + EdadTarde;
            }
            promediosTarde = cantidadTarde / 30;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Escribe la Edad de un Alumno de la Noche: ");
                linea = Console.ReadLine();
                EdadNoche = float.Parse(linea);
                cantidadNoche = cantidadNoche + EdadNoche;
            }
            promediosNoche = cantidadNoche / 15;

            Console.WriteLine("El Promedio de edad de la Mañana es: " + promediosMañana);
            Console.WriteLine("El Promedio de edad de la Tarde es: " + promediosTarde);
            Console.WriteLine("El Promedio de edad de la Noche es: " + promediosNoche);
            if (promediosMañana< promediosTarde && promediosMañana< promediosNoche)
            {
                Console.WriteLine("El que tiene el promedio mas bajo son los de la Mañana");
            }else
                if (promediosTarde< promediosMañana && promediosTarde < promediosNoche)
                {
                    Console.WriteLine("El que tiene el promedio mas bajo son los de la Tarde");
                }
                else
                {
                    Console.WriteLine("El que tiene el promedio mas bajo son los de la Noche");
                }



            Console.ReadKey();
        }
    }
}
