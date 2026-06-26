using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*  Actividad 2: Administración de entregas logísticas
        Problema:
        Una empresa de envíos desea registrar sus entregas mediante colaboración de
        clases.
        Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
        Despachador que contenga una lista de paquetes y un método para registrar nuevos
        paquetes.
        Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
             Todos los paquetes registrados.
             Cuántos superan los 10 kg de peso.
             Cuántos tienen destino nacional (por ejemplo, “Argentina”).
    */
    class Paquete
    {
        private int codigo;
        private float peso;
        private string destino;
        public int Codigo
        {
            set
            {
                codigo = value;
            }
            get { return codigo; }
        }
        public float Peso
        {
            set
            {
                peso = value;
            }
            get { return peso; }
        }
        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }
        public Paquete(int c, float p, string d)
        {
            codigo = c;
            peso = p;
            destino = d;
        }
    }
    class Despachador
    {
        List<Paquete> ListadoPaquetes = new List<Paquete>();

        public void RegistrarPaquetes(int r)
        {
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Poner el Codigo del Paquete");
                string linea;
                linea = Console.ReadLine();
                int c = int.Parse(linea);
                Console.WriteLine("Poner el Peso del Paquete");
                linea = Console.ReadLine();
                float p=float.Parse(linea);
                Console.WriteLine("Poner el destino del Paquete (Es lo paises)");
                string d= Console.ReadLine().ToLower();
                Paquete nuevoPaquete = new Paquete(c,p,d);
                ListadoPaquetes.Add(nuevoPaquete);
            }
        }
        public void ListadoTotal()
        {
            Console.WriteLine("El listado de paquete: ");
            foreach(Paquete i in ListadoPaquetes)
            {
                Console.WriteLine("El Codigo del Paquete es: "+i.Codigo+" Su peso es: "+i.Peso+" y su destino es: "+i.Destino);
            }
        }
        public void SuperanElPeso10kg()
        {
            Console.WriteLine("Los Paquetes que superan el peso de 10 kg es: ");
            int j = 0;
            foreach (Paquete i in ListadoPaquetes)
            {
                if (i.Peso >10)
                {
                    Console.WriteLine("El codigo es: " + i.Codigo + " su peso es: " + i.Peso+"kg");
                    j++;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("No Hay paquetes que superen el peso de 10kg");
            }
        }
        public void DestinoIgualArgentina()
        {
            int j = 0;
            foreach(Paquete i in ListadoPaquetes)
            {
                if (i.Destino=="argentina")
                {
                    j++;
                }
            }
            Console.WriteLine("La cantidad de paquetes que tienen destino nacional son: "+j);
        }



        static void Main(string[] args)
        {
            Despachador despachador1 = new Despachador();
            despachador1.RegistrarPaquetes(5);
            despachador1.ListadoTotal();
            despachador1.SuperanElPeso10kg();
            despachador1.DestinoIgualArgentina();
            Console.ReadKey();
        }
    }
}
