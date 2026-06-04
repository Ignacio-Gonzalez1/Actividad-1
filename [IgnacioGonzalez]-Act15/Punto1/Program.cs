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
        private double[] PromedioPulsaciones;
        public SalaMonitoreo()
        {
            PacienteTotal= new Paciente[3];
            for (int i=0; i< PacienteTotal.Length; i++)
            {
                PacienteTotal[i]= new Paciente();
            }
        }

        public void ImprimirGrilla() 
        { 
            for (int i = 0; i < PacienteTotal.Length; i++) 
            {   
                Console.WriteLine("Paciente " + (i + 1)); 
                Console.WriteLine("       mañana   mediodía   tarde  noche "); 
                for (int j = 0; j < PacienteTotal[i].retomarRitmoCardiaco().GetLength(0); j++) 
                { 
                    Console.Write("Dia: " + (j + 1)); 
                    for (int f = 0; f < PacienteTotal[i].retomarRitmoCardiaco().GetLength(1); f++) 
                    { 
                        Console.Write(" |" + PacienteTotal[i].retomarRitmoCardiaco()[j, f] + "|"); 
                    } 
                    Console.WriteLine(); } Console.WriteLine(); 
            } 
        }

        public void SacarPromedioPulsaciones() 
        { 
            PromedioPulsaciones = new double[3]; 
            for (int i = 0; i < PacienteTotal.Length; i++) 
            { 
                int total = 0; for (int j = 0; j < PacienteTotal[i].retomarRitmoCardiaco().GetLength(0); j++) 
                { 
                    for (int f = 0; f < PacienteTotal[i].retomarRitmoCardiaco().GetLength(1); f++) 
                    { 
                        total = total + PacienteTotal[i].retomarRitmoCardiaco()[j, f]; 
                    } 
                } 
                PromedioPulsaciones[i] = (double)total / 12; 
            } 
            for (int i = 0; i < PacienteTotal.Length; i++) 
            { 
                Console.WriteLine("La Pulsacion promedio del Paciente " + PacienteTotal[i].retomarNombre() + " es: " + PromedioPulsaciones[i]); 
            } 
        }
        public void TuvoTaquicardia() 
        { 
            for (int i = 0; i < PacienteTotal.Length; i++) 
            { 
                int l = 0; 
                Console.WriteLine("El Paciente " + PacienteTotal[i].retomarNombre()); 
                for (int j = 0; j < PacienteTotal[i].retomarRitmoCardiaco().GetLength(0); j++) 
                { 
                    for (int f = 0; f < PacienteTotal[i].retomarRitmoCardiaco().GetLength(1); f++) 
                    { 
                        if (PacienteTotal[i].retomarRitmoCardiaco()[j, f] > 120) 
                        { 
                            Console.WriteLine(PacienteTotal[i].retomarRitmoCardiaco()[j, f]); l++; 
                        } 
                    } 
                } 
                if (l == 0) 
                { 
                    Console.WriteLine("No sufrio Taquicardia Severa"); 
                } 
            } 
        }



        static void Main(string[] args)
        {
            SalaMonitoreo sala1 = new SalaMonitoreo(); 
            sala1.ImprimirGrilla(); 
            sala1.SacarPromedioPulsaciones(); 
            sala1.TuvoTaquicardia(); 
            Console.ReadKey();
        }
    }
}
