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
    }
    class RoverTerrestre : SondaExploradora
    {
        protected int cantidadRuedas;
        public RoverTerrestre(string m, int aM,int cR) : base (m, aM)
        {
            cantidadRuedas = cR;
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {
        }
    }
}
