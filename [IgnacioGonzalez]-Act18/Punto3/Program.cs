using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class SondaExploradora
    {
        /*  Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
            AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
            realice su asignación.
            Luego, definir dos clases derivadas de la clase base:
                ●   SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
                    soportada en atmósferas).
                ●   RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
            Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
            tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
            clase SondaExploradora mediante el uso explícito de la palabra clave base.
            En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
            parámetros unificados por consola.
        */
        protected string modelo;
        protected int autonomiaMinutos;

        public SondaExploradora(string m, int aM)
        {
            modelo = m;
            autonomiaMinutos = aM;
        }
        public string Modelo
        {
            set 
            { 
                modelo = value;
            }
            get
            {
                return modelo;
            }
        }
        public int AutonomiaMinutos
        {
            set
            {
                autonomiaMinutos = value;
            }
            get
            {
                return autonomiaMinutos;
            }
        }
    }
    class SondaSubmarina : SondaExploradora
    {
        protected int presionMaximaAtm;

        public SondaSubmarina(string m, int aM, int pMA) : base(m, aM)
        {
            presionMaximaAtm = pMA;
        }
        public int PresionMaximaAtm
        {
            set
            {
                presionMaximaAtm = value;
            }
            get
            {
                return presionMaximaAtm;
            }
        }
    }
    class RoverTerrestre : SondaExploradora
    {
        protected int cantidadRuedas;
        public RoverTerrestre(string m, int aM,int cR) : base (m, aM)
        {
            cantidadRuedas = cR;
        }
        public int CantidadRuedas
        {
            set
            {
                cantidadRuedas = value;
            }
            get
            {
                return cantidadRuedas;
            }
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {
            SondaSubmarina sonda1 = new SondaSubmarina("Hydroid REMUS 6000",1320,600);
            RoverTerrestre RoverTerrestre1 = new RoverTerrestre("VIPER (Volatiles Investigating Polar Exploration Rover)",540,4);
            Console.WriteLine("Las Sondas Exploradoras son: ");
            Console.WriteLine("El Modelo de la Sonda Submarina: "+sonda1.Modelo+" Su autonomia en minutos es: "+sonda1.AutonomiaMinutos+ " La presion Maxima de Atm que aguanta es: " +sonda1.PresionMaximaAtm);
            Console.WriteLine("El Modelo de la Rover Terrestre: " + RoverTerrestre1.Modelo + " Su autonomia en minutos es: " + RoverTerrestre1.AutonomiaMinutos + " La cantidad de Ruedas que tiene es: " + RoverTerrestre1.CantidadRuedas);
            Console.ReadKey();
        }
    }
}
