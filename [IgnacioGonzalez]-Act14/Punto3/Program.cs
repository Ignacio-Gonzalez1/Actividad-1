using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Atleta
    {
        /*  3. Competencia de Atletismo
            Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
            Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
            Definir los siguientes métodos en la clase Carrera:
                1.Un constructor que cargue los datos de los 3 atletas de la carrera.
                2.Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
                3.Un método que calcule e imprima el tiempo promedio de la carrera.
                4.Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
                5.Un método que muestre a los atletas que superaron el promedio.

        */
        private string nombre;
        private double TiempoSegundos;


        public Atleta()
        {
            Console.WriteLine("Cargar el Nombre del Atleta: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Poner el Tiempo que tardo en la carrera: ");
            string linea;
            linea = Console.ReadLine();
            TiempoSegundos = double.Parse(linea);
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public double retornarTiempoSegundos()
        {
            return TiempoSegundos;
        }
    }
    class Carrera
    {
        private Atleta[] AtletasTotales;
        private double promedio;

        public Carrera()
        {
            AtletasTotales = new Atleta[3];
            for (int i = 0; i < AtletasTotales.Length; i++)
            {
                AtletasTotales[i] = new Atleta();
            }
        }

        public void ListadoCompleto()
        {
            for (int i = 0; i < AtletasTotales.Length; i++)
            {
                Console.WriteLine("El Atleta: " + (i + 1));
                Console.WriteLine("El Nombre del Atleta: " + AtletasTotales[i].retornarNombre());
                Console.WriteLine("El Tiempo que le tomo al Atleta para terminar la Carrera: " + AtletasTotales[i].retornarTiempoSegundos());
            }
        }
        public void TiempoPromedio()
        {
            promedio = 0;
            for (int i = 0; i < AtletasTotales.Length; i++)
            {
                promedio = promedio + AtletasTotales[i].retornarTiempoSegundos();
            }
            promedio = (double)promedio / 3;
            Console.WriteLine("El tiempo promedio de la carrera de los atletas es: " + promedio);
        }
        public void ElGanadorCarrera()
        {
            double menorTiempo=AtletasTotales[0].retornarTiempoSegundos();
            int j = 0;
            for(int i = 1;i < AtletasTotales.Length; i++)
            {
                if (menorTiempo > AtletasTotales[i].retornarTiempoSegundos())
                {
                    menorTiempo = AtletasTotales[i].retornarTiempoSegundos();
                    j = i;

                }
            }
            Console.WriteLine("El ganador de la Carrera es: "+ AtletasTotales[j].retornarNombre()+" con un tiempo de: " + menorTiempo);
        }
        public void SuperaronElPromedio()
        {
            Console.WriteLine("Los Atletas que superaron el promedio serian: ");
            for (int i = 0; i < AtletasTotales.Length; i++)
            {
                if (promedio > AtletasTotales[i].retornarTiempoSegundos())
                {
                    Console.WriteLine(AtletasTotales[i].retornarNombre());
                }
            }
        }
        static void Main(string[] args)
        {
            Carrera carrera1 = new Carrera();
            carrera1.ListadoCompleto();
            carrera1.TiempoPromedio();
            carrera1.ElGanadorCarrera();
            carrera1.SuperaronElPromedio();
            Console.ReadKey();
        }
    }
}
