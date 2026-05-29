using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Paciente
    {
        /*  1. Monitoreo Clínico de Pacientes
            En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
            cardíaco de los pacientes.
            ● Plantear una clase llamada Paciente que tenga como atributos privados:
                1. Nombre (de tipo string).
                2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
                   registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
                   clave de cada día: mañana, mediodía, tarde y noche).
                3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
                   teclado de las 12 lecturas cardíacas.

            ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
            objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
            carga de los 3 pacientes. Implementar los siguientes métodos dentro de
            SalaMonitoreo:
                1. Un método que imprima la grilla de lecturas cardíacas completa de cada
                   paciente organizada por día y momento.
                2. Un método que calcule e imprima el promedio de pulsaciones de cada
                   paciente a lo largo de todo su monitoreo.
                3. Un método que verifique si algún paciente registró un evento de taquicardia
                   severa (cualquier lectura individual que sea estrictamente mayor a 120
                   pulsaciones), mostrando por consola su nombre y la lectura detectada.
        */
        private string nombre;
        private int[,] ritmoCardiaco;
        public Paciente()
        {
            ritmoCardiaco = new int[3,4];
            Console.WriteLine("Poner El Nombre del Paciente: ");
            nombre = Console.ReadLine();
            for (int i = 0; i< ritmoCardiaco.GetLength(0); i++)
            {
                Console.WriteLine("Los Registros De Pulsaciones del Dia "+(i+1));
                for (int j = 0; j< ritmoCardiaco.GetLength(1); j++)
                {
                    Console.WriteLine("Poner los Registros de Pulsaciones: ");
                    string linea;
                    linea = Console.ReadLine();
                    ritmoCardiaco[i,j]= int.Parse(linea);
                }
            }
        }
        public string retomarNombre()
        {
            return nombre;
        }
        public int[,] retomarRitmoCardiaco()
        {
            return ritmoCardiaco;
        }
    }
    class SalaMonitoreo
    {
        private Paciente[] PacienteTotal;
        public SalaMonitoreo()
        {
            PacienteTotal= new Paciente[3];
            for (int i=0; i< PacienteTotal.Length; i++)
            {
                PacienteTotal[i]= new Paciente();
            }
        }



        static void Main(string[] args)
        {
        }
    }
}
