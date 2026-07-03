using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*  Actividad 4: Gestión de vuelos
        Problema:
        Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
         Usar la palabra clave this en el constructor para diferenciar los parámetros de
        los atributos.
         Crear un método para calcular la duración del vuelo (TimeSpan).
         Cargar un vector con 4 vuelos y mostrar:
        1. El código y duración del vuelo más largo.
        2. El código del vuelo que salga más temprano.
    */
    class Vuelo
    {
        private int codigo;
        private DateTime horaSalida, horaLlegada;
        public int Codigo
        {
            set {codigo  = value; }
            get { return codigo; }
        }
        public DateTime HoraSalida
        {
            set { horaSalida = value; }
            get { return horaSalida; }
        }
        public DateTime HoraLlegada
        {
            set { horaLlegada = value; }
            get { return horaLlegada; }
        }
        public Vuelo(int codigo,DateTime horaSalida,DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaLlegada = horaLlegada;
            this.horaSalida = horaSalida;
        }
        public TimeSpan DuracionVuelos()
        {
            TimeSpan duracionVuelo = horaLlegada - horaSalida;

            return duracionVuelo;
        }
    }
    class Program
    {
        private Vuelo[] TotalVuelos;
        public Program()
        {
            TotalVuelos = new Vuelo[4];
            TotalVuelos[0] = new Vuelo(1,new DateTime(2002,2,19,10,4,0), new DateTime(2002, 2, 19, 12, 4, 0));
            TotalVuelos[1] = new Vuelo(2, new DateTime(2022, 2, 19, 10, 4, 0), new DateTime(2022, 2, 19, 12, 4, 40));
            TotalVuelos[2] = new Vuelo(3, new DateTime(2023, 3, 19, 10, 4, 0), new DateTime(2023, 3, 19, 20, 4, 40));
            TotalVuelos[3] = new Vuelo(4, new DateTime(2024, 4, 19, 10, 4, 0), new DateTime(2024, 4, 20, 3, 4, 40));
        }

        public void MasLargo()
        {
            TimeSpan elMasLargo = TotalVuelos[0].DuracionVuelos();
            int ñ = 0;
            for (int i = 0; i < TotalVuelos.Length; i++)
            {
                if (elMasLargo< TotalVuelos[i].DuracionVuelos())
                {
                    ñ = i;
                    elMasLargo = TotalVuelos[i].DuracionVuelos();
                }
            }
            Console.WriteLine("El vuelo mas largo es: "+ TotalVuelos[ñ].Codigo+" su Duracion de vuelo es: "+elMasLargo);
        }

        static void Main(string[] args)
        {

        }
    }
}
