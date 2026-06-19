using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Prueba
    {
        /*  Armar una clase parcial JuegoArcade.
            En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
            NivelDificultad (de 1 a 5). Valores cargados desde consola
            En el segundo archivo, implementar un método que indique si un puntaje ingresado
            supera el récord o no.
            Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.
        */
        private JuegoArcade[] totalPartidas;
        public Prueba()
        {
            totalPartidas = new JuegoArcade[4];
            for (int i = 0; i < totalPartidas.Length; i++)
            {
                totalPartidas[i] = new JuegoArcade();
            }
        }
        public void ELjugadorSuperoElrecord()
        {
            Console.WriteLine("Los jugadores que rompieron el Record: ");
            for (int i = 0;i < totalPartidas.Length;i++)
            {
                if (totalPartidas[i].RetornarSuperaAlRecord() == "Supero el record de puntos")
                {
                    Console.WriteLine("El jugador de la partida "+(i+1)+" logro superar el record del juego " + totalPartidas[i].NombreJuego+" Con una dificultad: " + totalPartidas[i].NivelDificultad);
                }
            }
        }

        static void Main(string[] args)
        {
            Prueba prueba1 = new Prueba();
            prueba1.ELjugadorSuperoElrecord();
            Console.ReadKey();
        }
    }
}
