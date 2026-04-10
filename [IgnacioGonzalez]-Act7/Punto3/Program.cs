using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Partidas
    {
        /*  Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
            un videojuego. El programa debe:
             Mostrar la puntuación más alta y la más baja.
             Calcular el promedio de puntuación.
             Contar cuántas veces superó los 500 puntos.
        */
        private int[] PartidasJugadas;
        private int Mejor, Menor, Suma, PartidasMayor500P;
        private double Promedio;
        public void IngresarPartidas()
        {
            PartidasJugadas = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingresar Puntuaciones de Partidas");
                String linea;
                linea = Console.ReadLine();
                PartidasJugadas[i]=int.Parse(linea);
            }
        }
        public void PuntuacionAltaYBaja()
        {
            Mejor= PartidasJugadas[0];
            Menor= PartidasJugadas[0];
            for(int i = 1;i < 6;i++)
            {
                if (PartidasJugadas[i] > Mejor)
                {
                    Mejor = PartidasJugadas[i];
                }
                if (PartidasJugadas[i] < Menor)
                {
                    Menor = PartidasJugadas[i];
                }
            }
        }
        public void PromedioPuntuaciones()
        {
            Suma = 0;
            Promedio = 0;
            for(int f = 0;f < 6; f++)
            {
                Suma= Suma + PartidasJugadas[f];
            }
            Promedio = (double)Suma / 6;
        }
        public void CantidadVecesQueSupero500P()
        {
            PartidasMayor500P = 0;
            for (int j = 0; j < 6; j++)
            {
                if (PartidasJugadas[j] > 500)
                {
                    PartidasMayor500P = PartidasMayor500P + 1;
                }
            }
        }
        public void ImprimirTodo()
        {
            Console.WriteLine("La Puntuacion Mas Alta es: " + Mejor);
            Console.WriteLine("La Puntuacion Mas Baja es: " + Menor);
            Console.WriteLine("El Promedio de las Puntuaciones es: " + Promedio);
            Console.WriteLine("La Cantidad de Puntuacioes Mejores a 500 es: " + PartidasMayor500P);
        }

        static void Main(string[] args)
        {
            Partidas puntuaciones1 = new Partidas();
            puntuaciones1.IngresarPartidas();
            puntuaciones1.PuntuacionAltaYBaja();
            puntuaciones1.PromedioPuntuaciones();
            puntuaciones1.CantidadVecesQueSupero500P();
            puntuaciones1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
