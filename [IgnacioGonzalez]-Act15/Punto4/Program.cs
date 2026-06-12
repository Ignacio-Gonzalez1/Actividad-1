using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class RobotEnsamblador
    {
        /*  4. Línea de Ensamblaje Robótico
            En una planta de fabricación automatizada, cada robot industrial realiza tareas de
            ensamblaje complejas divididas en operaciones secundarias de duración variable.
                ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
                    1. ModeloRobot.
                    2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
                        fila representa una de las 4 fases principales del proceso (Estructura,
                        Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
                        completar las distintas subtareas de esa fase (por ejemplo, en la fase de
                        Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
                        1).
                    3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
                    cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar
                    (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
                    una de ellas.
                ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
                  RobotEnsamblador. Implementar en PlantaIndustrial:
                    1.  Un constructor que cargue la información de los 3 robots instalados en la
                        planta.
                    2.  Un método que muestre un reporte detallado con los tiempos de operación
                        de cada robot fase por fase.
                    3.  Un método que calcule el promedio general de tiempo por tarea de cada
                        robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
                        tiempo por operación más bajo de la planta).
        */
        private string ModeloRobot;
        private float[][] tiemposOperacion;
        public RobotEnsamblador()
        {
            tiemposOperacion = new float[4][];
            Console.WriteLine("Poner el Modelo del Robot: ");
            ModeloRobot= Console.ReadLine();
            for (int i = 0; tiemposOperacion.Length > i; i++)
            {
                int p =0;
                Console.WriteLine("Poner cuantos tiempo tardo en completar la tarea en la fase " + (i + 1)+": ");
                string linea;
                linea = Console.ReadLine();
                p = int.Parse(linea);
                tiemposOperacion[i]= new float[p];
            }
            for (int i = 0; i < tiemposOperacion.Length; i++)
            {
                Console.WriteLine("La fase: " + (i + 1));
                for (int j = 0; j< tiemposOperacion[i].Length; j++)
                {
                    Console.WriteLine("Poner el tiempo de duracion (en segundos): ");
                    string linea;
                    linea = Console.ReadLine();
                    tiemposOperacion [i][j] = float.Parse(linea);
                }
                Console.WriteLine();
            }
        }
        public string retornarModeloRobot()
        {
            return ModeloRobot;
        }
        public float[][] retornarTiemposOperacion()
        {
            return tiemposOperacion;
        }
    }
    class PlantaIndustrial
    {
        private RobotEnsamblador[] totalRobotEnsamblador;
        private float[] promedio;

        public PlantaIndustrial()
        {
            totalRobotEnsamblador = new RobotEnsamblador[3];
            for (int i = 0; i < totalRobotEnsamblador.Length; i++)
            {
                totalRobotEnsamblador[i] = new RobotEnsamblador();
            }
        }
        public void MostrarTiempos()
        { 
            for (int i = 0;i < totalRobotEnsamblador.Length; i++)
            {
                Console.WriteLine("Los tiempos del Robot: " + totalRobotEnsamblador[i].retornarModeloRobot());
                for (int j = 0; j < totalRobotEnsamblador[i].retornarTiemposOperacion().Length; j++)
                {
                    Console.WriteLine("La fase: "+(j+1));
                    for(int k = 0; k< totalRobotEnsamblador[i].retornarTiemposOperacion()[j].Length; k++)
                    {
                        Console.Write(" "+ totalRobotEnsamblador[i].retornarTiemposOperacion()[j][k]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void sacarELPromedio()
        {
            promedio = new float [3];
            for(int i = 0; i<totalRobotEnsamblador.Length; i++)
            {
                int total = 0;
                for (int j = 0; j < totalRobotEnsamblador[i].retornarTiemposOperacion().Length; j++)
                {
                    for (int k = 0; k < totalRobotEnsamblador[i].retornarTiemposOperacion()[j].Length; k++)
                    {

                    }
                }
                promedio[i]=total /(j * k)
            }
        }



        static void Main(string[] args)
        {
            PlantaIndustrial planta1 = new PlantaIndustrial();
            planta1.MostrarTiempos();
        }
    }
}
