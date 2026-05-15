using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class GestionCine
    {
        /*  Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
            asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
                ● Definir una matriz irregular de 4 filas para representar los asientos.
                ● Métodos:
                    1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
                    intervención del operador).
                    2. Crear un método de &quot;Venta de Entradas&quot; que permita cargar la edad del
                    espectador en un asiento específico (fila y columna).
                    3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
                    en cada asiento.
                    4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
                    5. Informar cuál es el promedio de edad de los espectadores de todo el
                    complejo.
        */
        private int[][] cine;
        private int[] Menores;
        private double promedio;
        public void Acientos()
        {
            cine = new int[4][];
            cine[0] = new int[10];
            cine[1] = new int[15];
            cine[2] = new int[8];
            cine[3] = new int[12];

        }
        public void Venta_de_Entradas()
        {
            for (int i = 0; i < cine.Length; i++)
            {
                for(int j = 0; j < cine[i].Length; j++)
                {
                    Console.WriteLine("Poner la edad del Espectador de la sala: "+(i+1)+"  del aciento: "+j);
                    string linea;
                    linea = Console.ReadLine();
                    cine[i][j]=int.Parse(linea);
                }
            }
        }

        public void ImprimirTodo()
        {
            for(int i = 0;i < cine.Length; i++)
            {
                Console.WriteLine("La sala:"+ (i+1));
                for(int j=0; j < cine[i].Length; j++)
                {
                    Console.WriteLine("  Aciento: "+j+" Edad:"+ cine[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void MenoresEnSalas()
        {
            Menores = new int[4];

            for (int i = 0; i < cine.Length; i++)
            {
                int f = 0;
                for (int j = 0; j < cine[i].Length; j++)
                {
                    if (18 > cine[i][j])
                    {
                        f++;
                    }
                }
                Menores[i]= f;
            }
            for (int i = 0;i<Menores.Length ; i++)
            {
                Console.WriteLine("Cuantos Menores hay en la sala:" + (i + 1) + " es: " + Menores[i]);
            }
        }
        public void PromedioEdadSalas()
        {
            int total = 0;
            for(int i = 0;i<cine.Length ; i++)
            {
                for(int j = 0;j < cine[i].Length ; j++)
                {
                    total= total+cine[i][j];
                }
            }
            promedio = (double)total / 45;
            Console.WriteLine("La edad Promedio del complejo es: "+ promedio);
        }



        static void Main(string[] args)
        {
            GestionCine Per1=new GestionCine();
            Per1.Acientos();
            Per1.Venta_de_Entradas();
            Per1.ImprimirTodo();
            Per1.MenoresEnSalas();
            Per1.PromedioEdadSalas();
            Console.ReadKey();

        }
    }
}
