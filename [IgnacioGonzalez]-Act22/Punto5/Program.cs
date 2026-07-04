using Punto5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*  Actividad 5: Gestión de Carreras Deportivas
        Consigna:
        Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
        una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
        Se pide:
        1. Crear una clase Carrera con:
        o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
        definidos.
        o Dos constructores (uno por defecto y otro con parámetros).
        o Método para calcular la duración de la carrera usando TimeSpan.
        2. Crear una clase Corredor con:
        o Atributos: nombre, número de dorsal y tiempo total.
        o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
        horas y minutos).

        3. Mostrar en consola (usando Console.SetCursorPosition()):
        o La carrera con mayor duración.
        o El corredor más rápido.
        4. Utilizar this en los constructores o métodos donde corresponda.
        5. Deben ser 4 carreras.
    */
    class Corredor
    {
        private string nombre;
        private int numeroDorsal,hora,minutos;
        private TimeSpan tiempoTotal;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int NumeroDorsal
        {
            set {  numeroDorsal = value; }
            get { return numeroDorsal; }
        }
        public TimeSpan TiempoTotal
        {
            set { tiempoTotal = value; }
            get { return tiempoTotal; }
        }
        public int Hora
        {
            set { hora = value; }
            get { return hora; }
        }
        public int Minutos
        {
            set { minutos = value; }
            get { return minutos; }
        }
        public Corredor(string n, int nD,int h,int m)
        {
            nombre = n;
            numeroDorsal= nD;
            hora = h;
            minutos = m;
        }
        public void RegistrarTiempoTotal(int h1, int m1)
        {
            tiempoTotal = new TimeSpan(h1, m1, 0);
        }
        public void RegistrarTiempoTotal(int m1)
        {
            tiempoTotal = TimeSpan.FromMinutes(m1);
        }

    }
    class Carrera
    {
        private int codigo;
        private DateTime horaInicio, horaFin;
        public List<Corredor> TotalCorredor = new List<Corredor>();
        public int Codigo
        {
            set { codigo = value; }
            get{ return codigo; }
        }
        public DateTime HoraInicio
        {
            set { horaInicio = value; }
            get { return horaInicio; }
        }
        public DateTime HoraFin
        {
            set {  horaFin = value; }
            get { return  horaFin; }
        }
        public Carrera()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del corredor: ");
                string n = Console.ReadLine();
                string linea;
                Console.WriteLine("Poner El NumeroDorsal: ");
                linea = Console.ReadLine();
                int nD = int.Parse(linea);
                Console.WriteLine("Poner la Hora que tardo el corredor: ");
                linea = Console.ReadLine();
                int h = int.Parse(linea);
                Console.WriteLine("Poner los Minutos que tardo el corredor: ");
                linea = Console.ReadLine();
                int m = int.Parse(linea);
                Corredor nuevoCorredor = new Corredor(n, nD, h,m);
                TotalCorredor.Add(nuevoCorredor);
            }
            Console.WriteLine("Poner el Codigo de la Carrera: ");
            string linea1;
            linea1 = Console.ReadLine();
            codigo=int.Parse(linea1);
            Console.WriteLine("Ingrese una fecha y hora de la hora de inicio de la carrera(formato: dd/MM/yyyy HH:mm:ss): ");
            linea1 = Console.ReadLine();
            horaInicio = DateTime.Parse(linea1);
            Console.WriteLine("Ingrese una fecha y hora de la hora de fin de la carrera(formato: dd/MM/yyyy HH:mm:ss): ");
            linea1 = Console.ReadLine();
            horaFin = DateTime.Parse(linea1);
        }
        public Carrera(int codigo,DateTime horaInicio,DateTime horaFin)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del corredor: ");
                string n = Console.ReadLine();
                string linea;
                Console.WriteLine("Poner El NumeroDorsal: ");
                linea = Console.ReadLine();
                int nD = int.Parse(linea);
                Console.WriteLine("Poner la Hora que tardo el corredor: ");
                linea = Console.ReadLine();
                int h = int.Parse(linea);
                Console.WriteLine("Poner los Minutos que tardo el corredor: ");
                linea = Console.ReadLine();
                int m = int.Parse(linea);
                Corredor nuevoCorredor = new Corredor(n, nD, h, m);
                TotalCorredor.Add(nuevoCorredor);
            }
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

        public TimeSpan DuracionCarrera()
        {
            TimeSpan duracionCarrera= HoraFin-horaInicio;
            return duracionCarrera;
        }
    }
}
class Prueba
{
    private Carrera[] CarreraTotales;
    public Prueba()
    {
        CarreraTotales = new Carrera[4];
        for (int i = 0; i < 3; i++)
        {
            CarreraTotales[i] = new Carrera();
        }
        CarreraTotales[3] = new Carrera(4, new DateTime(2026, 10, 15, 14, 30, 00), new DateTime(2026, 10, 15, 17, 30, 00));
    }

    public void MayorDuracionCarrera()
    {
        TimeSpan elMayor = CarreraTotales[0].DuracionCarrera();
        int l = 0;
        for (int i = 1; i < CarreraTotales.Length; i++)
        {
            if (elMayor < CarreraTotales[i].DuracionCarrera())
            {
                elMayor = CarreraTotales[i].DuracionCarrera();
                l = i;
            }
        }
        Console.SetCursorPosition(40, 20);
        Console.WriteLine("El de Mayor duracion de carrera de es: " + CarreraTotales[l].Codigo + " Con una duracion total de " + elMayor);
    }
    public void ElCorredorMasRapido()
    {
        int p = 0;
        int l = 0;
        if (CarreraTotales[0].TotalCorredor[0].Hora <= 0)
        {
            CarreraTotales[0].TotalCorredor[0].RegistrarTiempoTotal(CarreraTotales[0].TotalCorredor[0].Minutos);
        }
        else
            if (CarreraTotales[0].TotalCorredor[0].Hora > 0)
            {
                CarreraTotales[0].TotalCorredor[0].RegistrarTiempoTotal(CarreraTotales[0].TotalCorredor[0].Hora, CarreraTotales[0].TotalCorredor[0].Minutos);
            }
        TimeSpan elMasRapido = CarreraTotales[0].TotalCorredor[0].TiempoTotal;
        for(int i=0;i< CarreraTotales.Length; i++)
        {
            for (int j = 0; j < CarreraTotales[i].TotalCorredor.Count; j++)
            {
                if (CarreraTotales[i].TotalCorredor[j].Hora <= 0)
                {
                    CarreraTotales[i].TotalCorredor[j].RegistrarTiempoTotal(CarreraTotales[i].TotalCorredor[j].Minutos);
                }else
                    if (CarreraTotales[i].TotalCorredor[j].Hora > 0)
                    {
                        CarreraTotales[i].TotalCorredor[j].RegistrarTiempoTotal(CarreraTotales[i].TotalCorredor[j].Hora, CarreraTotales[i].TotalCorredor[j].Minutos);
                    }
                if (elMasRapido> CarreraTotales[i].TotalCorredor[j].TiempoTotal)
                {
                    elMasRapido = CarreraTotales[i].TotalCorredor[j].TiempoTotal;
                    p = i;
                    l= j;
                }
            }
        }


    Console.SetCursorPosition(40, 5);
        Console.WriteLine("El corredor mas rapido es: " + CarreraTotales[p].TotalCorredor[l].Nombre + " Tardo en terminar la carrera: " + elMasRapido);
    }

    static void Main(string[] args)
    {
        Prueba prueba1 = new Prueba();
        Console.Clear();
        prueba1.MayorDuracionCarrera();
        prueba1.ElCorredorMasRapido();
        Console.ReadKey();
    }
}



//cuando termines agreaga en corredores 4 en vez de 2
