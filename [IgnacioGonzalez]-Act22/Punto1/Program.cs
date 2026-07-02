using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            get { return horaFin; }
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
            horaInicio= DateTime.Parse(linea);
            Console.WriteLine("Ingrese una fecha y hora de la hora de fin de la clase(formato: dd/MM/yyyy HH:mm:ss): ");
            linea = Console.ReadLine();
            horaInicio = DateTime.Parse(linea);
        }
        public ClaseGimnasio(string nombreClase, DateTime horaInicio, DateTime horaFin)
        {
            this.nombreClase = nombreClase;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }
        public TimeSpan DuracionClase()
        {
            TimeSpan Duracion = horaFin - horaInicio;
            return ;
        }
    }
    class Program
    {
        private ClaseGimnasio[] TotalclaseGimnasio;

        public Program()
        {
            TotalclaseGimnasio = new ClaseGimnasio[3];
            for (int i = 0;i<TotalclaseGimnasio.Length;i++)
            {
                TotalclaseGimnasio[i] = new ClaseGimnasio();
            }
        }
        public void MayorDuracion()
        {

        }





        static void Main(string[] args)
        {

        }
    }
}
