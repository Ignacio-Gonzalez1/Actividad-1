using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        private string nombreJuego;
        private int puntajeMaximo;
        private int nivelDificultad;
        public string NombreJuego
        {
            set { nombreJuego = value; }
            get { return nombreJuego; }
        }
        public int PuntajeMaximo
        {
            set { puntajeMaximo = value; }
            get { return puntajeMaximo; }
        }
        public int NivelDificultad
        {
            set { nivelDificultad = value;}
            get { return nivelDificultad; }
        }
        public JuegoArcade()
        {
            Console.WriteLine("El nombre del juego: ");
            nombreJuego = Console.ReadLine();
            Console.WriteLine("Poner El puntaje que saco: ");
            string linea;
            linea = Console.ReadLine();
            puntajeMaximo= int.Parse(linea);
            Console.WriteLine("El nivel de dificultad que estaba el juego: ");
            do
            {
                linea = Console.ReadLine();
                if (int.Parse(linea)>=1 && int.Parse(linea) <= 5)
                {
                    nivelDificultad = int.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("El nivel de dificultad debe estar entre 1 y 5");
                }
            }while (true);
        }
    }
}
