using System;

namespace Punto1
{
    class ClaseGimnasio
    {
        private string nombreClase;
        private DateTime horaInicio, horaFin;
        private TimeSpan duracionClase;

        public string NombreClase
        {
            set { nombreClase = value; }
            get { return nombreClase; }
        }

        public DateTime HoraInicio
        {
            set { horaInicio = value; }
            get { return horaInicio; }
        }

        public DateTime HoraFin
        {
            set { horaFin = value; }
            get { return horaFin; }
        }

        public ClaseGimnasio()
        {
            Console.WriteLine("El nombre de la clase del Gimnasio es: ");
            nombreClase = Console.ReadLine();
            Console.WriteLine("Ingrese una fecha y hora de la hora de inicio de la clase(formato: dd/MM/yyyy HH:mm:ss): ");
            string linea;
            linea = Console.ReadLine();
            horaInicio = DateTime.Parse(linea);
            Console.WriteLine("Ingrese una fecha y hora de la hora de fin de la clase(formato: dd/MM/yyyy HH:mm:ss): ");
            linea = Console.ReadLine();
            horaFin = DateTime.Parse(linea);
        }

        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreClase = nombreClase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

        public TimeSpan DuracionClases()
        {
            TimeSpan duracionClase = horaFin - horaInicio;
            return duracionClase;
        }
    }

    class Program
    {
        private ClaseGimnasio[] TotalclaseGimnasio;

        public Program()
        {
            TotalclaseGimnasio = new ClaseGimnasio[3];
            for (int i = 0; i < 2; i++)
            {
                TotalclaseGimnasio[i] = new ClaseGimnasio();
            }
            TotalclaseGimnasio[2] = new ClaseGimnasio("Cardiovasculares", new DateTime(2026, 10, 15, 14, 30, 00), new DateTime(2026, 10, 15, 17, 30, 00));
        }

        public void MayorDuracion()
        {
            TimeSpan Elmayor = TotalclaseGimnasio[0].DuracionClases();
            int l = 0;
            for (int i = 1; i < TotalclaseGimnasio.GetLength(0); i++)
            {
                if (Elmayor < TotalclaseGimnasio[i].DuracionClases())
                {
                    Elmayor = TotalclaseGimnasio[i].DuracionClases();
                    l = i;
                }
            }
            Console.WriteLine("El que tiene mayor duracion de clase es: " + TotalclaseGimnasio[l].NombreClase + " las horas que toma la clase son: " + Elmayor);
        }

        public void ClaseTemprana()
        {
            
            TimeSpan horaMasTemprana = TotalclaseGimnasio[0].HoraInicio.TimeOfDay;
            int P = 0;

            
            for (int i = 1; i < TotalclaseGimnasio.Length; i++)
            {
                TimeSpan horaActual = TotalclaseGimnasio[i].HoraInicio.TimeOfDay;

                if (horaActual < horaMasTemprana)
                {
                    horaMasTemprana = horaActual;
                    P = i;
                }
            }

            Console.WriteLine("El que comienza antes por la hora es la clase: " + TotalclaseGimnasio[P].NombreClase + " Ya que comienza a las: " + horaMasTemprana);
        }


        static void Main(string[] args)
        {
            Program program1 = new Program();
            program1.MayorDuracion();
            program1.ClaseTemprana();
            Console.ReadKey();
        }
    }
}