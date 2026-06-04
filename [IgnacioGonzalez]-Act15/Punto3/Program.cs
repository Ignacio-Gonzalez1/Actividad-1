using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class ReservaNatural
    {
        /*  Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
            especies protegidas en cuadrículas de territorio.
            ●   Confeccionar la clase ReservaNatural que tenga como atributos privados el
                NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
                mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
                cantidad de animales avistados en cada sector). El constructor de la clase debe
                cargar por teclado el nombre y rellenar el mapa de avistamientos.
            ●   Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
                objetos de la clase ReservaNatural.
            La clase CentroEcologico debe implementar los siguientes métodos:
                1.  Un constructor que solicite la carga secuencial de las 3 reservas.
                2.  Un método que enliste cada reserva junto a la cantidad total de avistamientos que
                    registró en toda su superficie (la suma de toda su matriz rectangular).
                3.  Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
                    columna]) que registró la mayor concentración de avistamientos de toda la red de
                    reservas, indicando a qué reserva pertenece.
        */
        private string NombreReserva;
        private int[,] avistamientos;
        public ReservaNatural()
        {
            avistamientos = new int[3,3];
            Console.WriteLine("El nombre de la reserva: ");
            NombreReserva = Console.ReadLine();
        }

        public string retornarNombreReserva()
        {
            return NombreReserva;
        }
        public int[,] retornarAvistamientos()
        {
            return avistamientos;
        }
    }
        class CentroEcologico
    {
        private ReservaNatural[] totalReserva;
        private int[] totalAvistamientoDeCadaReserva;

        public CentroEcologico()
        {
            totalReserva= new ReservaNatural[3];
            for (int i = 0; i < totalReserva.Length; i++)
            {
                totalReserva[i] = new ReservaNatural();
            }
            for (int h=0;h<totalReserva.Length; h++)
            {
                Console.WriteLine("Poner la carga de avistamientos de la reserva: " + totalReserva[h].retornarNombreReserva());
                for (int i = 0; i < totalReserva[h].retornarAvistamientos().GetLength(0); i++)
                {
                    Console.WriteLine("Sector: "+(i+1));
                    for (int j = 0; j < totalReserva[h].retornarAvistamientos().GetLength(1); j++)
                    {
                        Console.WriteLine("Los avistamiento de animales en esa parte es: ");
                        string linea;
                        linea = Console.ReadLine();
                        totalReserva[h].retornarAvistamientos()[i, j] = int.Parse(linea);
                    }
                }
            }
        }
        public void cantidadTotalAvistamiento()
        {
            totalAvistamientoDeCadaReserva = new int[3];
            for(int i = 0;  i < totalReserva.Length; i++)
            {
                int sumatotal = 0;
                for (int j = 0;j<totalReserva[i].retornarAvistamientos().GetLength(0) ;  j++)
                {
                    for( int k = 0;k< totalReserva[i].retornarAvistamientos().GetLength(1); k++)
                    {
                        sumatotal = sumatotal + totalReserva[i].retornarAvistamientos()[j, k];
                    }

                }
                totalAvistamientoDeCadaReserva[i]= sumatotal;
            }
            Console.WriteLine("Los Avistamiento de animales en total de cada reserva es: ");
            for (int i = 0;i< totalAvistamientoDeCadaReserva.Length; i++)
            {
                Console.WriteLine("La cantidad de animales de la reserva " + totalReserva[i].retornarNombreReserva() + " es: " + totalAvistamientoDeCadaReserva[i]);
            }
        }
        public void IndicarMasAnimalesSector()
        {
            int Mayor = totalReserva[0].retornarAvistamientos()[0, 0];
            int h = 0;
            for (int i = 0; i < totalReserva.Length; i++)
            {
                for (int j = 0; j < totalReserva[i].retornarAvistamientos().GetLength(0); j++)
                {
                    for (int k = 0; k < totalReserva[i].retornarAvistamientos().GetLength(1); k++)
                    {
                        if (Mayor< totalReserva[i].retornarAvistamientos()[j,k])
                        {
                            Mayor = totalReserva[i].retornarAvistamientos()[j, k];
                            h = i;

                        }
                    }

                }
            }
            Console.WriteLine("la mayor cantidad de animales visto en un sector es: "+Mayor+" y fue en la reserva: " + totalReserva[h].retornarNombreReserva());
        }
        static void Main(string[] args)
        {
            CentroEcologico ecologico = new CentroEcologico();
            ecologico.cantidadTotalAvistamiento();
            ecologico.IndicarMasAnimalesSector();
            Console.ReadKey();
        }
    }
}
