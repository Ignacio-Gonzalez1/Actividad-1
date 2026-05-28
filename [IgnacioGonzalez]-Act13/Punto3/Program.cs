using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Socio
    {
        /*  Plantear una clase Club y otra clase Socio.
            La clase Socio debe tener los siguientes atributos privados: nombre y la
            antigüedad en el club (en años). En el constructor pedir la carga del nombre y
            su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
            Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
            antigüedad en el club.
        */
        private string Nombre;
        private int Antiguedad;
        public Socio(){
            Console.WriteLine("Poner El Nombre: ");
            Nombre = Console.ReadLine();
            string linea;
            Console.WriteLine("Poner la Antiguedad de "+Nombre+" en el club: ");
            linea = Console.ReadLine();
            Antiguedad=int.Parse(linea);
        }

        public string retornarNombre()
        {
            return Nombre;
        }
        public int retornarAntiguedad()
        {
            return Antiguedad;
        }
    }
    class Club
    {
        public Socio Socio1, Socio2, Socio3;

        public Club()
        {
            Socio1 = new Socio();
            Socio2 = new Socio();
            Socio3 = new Socio();
        }
            public void responsabilidad()
        {
            int MayorAntiguedad = Socio1.retornarAntiguedad();
            string MayorNombreAntiguedad = Socio1.retornarNombre();

            if (Socio2.retornarAntiguedad() > MayorAntiguedad)
            {
                MayorAntiguedad = Socio2.retornarAntiguedad();
                MayorNombreAntiguedad = Socio2.retornarNombre();
            }

            if (Socio3.retornarAntiguedad() > MayorAntiguedad)
            {
                MayorAntiguedad = Socio3.retornarAntiguedad();
                MayorNombreAntiguedad = Socio3.retornarNombre();
            }

            Console.WriteLine("El que tiene mayor antigüedad es "+MayorNombreAntiguedad+" y tiene "+MayorAntiguedad+" Años en el Club");
        }
        static void Main(string[] args)
        {
            Club Club1= new Club();
            Club1.responsabilidad();
            Console.ReadKey();
        }
    }
}
