using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Punto2
{
        /*  Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
            drones de entrega en vuelo de regreso a la base.
             Crear la clase Dron que contenga los atributos privados: codigo (string) y
            nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
            Su constructor debe recibir cod y bat.
             Crear la clase CentroControl que administre una lista de objetos
            List&lt;Dron&gt;.
             Métodos en CentroControl:

            1. Un constructor que cargue por teclado una lista inicial de 4 drones
            ingresando sus códigos y baterías.
            2. ListarFlota(): Mostrar la lista de drones en pantalla.
            3. RemoverDronesBajos(): Recorrer la lista y remover por
            completo de la flota a todos aquellos drones cuyo nivel de batería
            sea menor o igual al 15% (ya que requieren mantenimiento
            automático urgente).
            4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
            cantidad de drones operativos utilizando la propiedad .Count.
    */
    class Dron
    {
        private string codigo;
        private int nivelBateria;//0 a 100
        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public int NivelBateria
        {
            set { nivelBateria = value; }
            get { return nivelBateria; }
        }
        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;
        }
    }
    class CentroControl
    {
        List<Dron> drones = new List<Dron>();
        public CentroControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Agrega el codigo del dron: ");
                string cod = Console.ReadLine();
                Console.WriteLine("Agrega la Cantidad de bateria que va tener el dron: ");
                string linea;
                int bat = 0;
                do
                {
                    linea = Console.ReadLine();
                    if (int.Parse(linea) >= 0 && int.Parse(linea) <= 100)
                    {
                        bat = int.Parse(linea);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pone una bateria que este entre 0 y 100");
                    }
                }
                while (true);
                Dron AgregarDron = new Dron(cod, bat);
                drones.Add(AgregarDron);
            }
        }
        public void ListarFlota()
        {
            Console.WriteLine("Los Drones son:");
            foreach (Dron drone in drones)
            {
                Console.WriteLine("Dron:" + drone.Codigo + " Bateria que posee es: " + drone.NivelBateria);
            }
        }
        public void RemoverDronesBajos()
        {
            for (int i = drones.Count - 1; i >= 0; i--)
            {
                if (drones[i].NivelBateria<=15)
                {
                    drones.RemoveAt(i);
                }
            }
        }
        public void MostrarDronesRestantes()
        {
            Console.WriteLine("La flota de drones actualizada es:");
            for (int i = 0; i < drones.Count; i++)
            {
                Console.WriteLine("Dron: " + drones[i].Codigo + " La cantidad de bateria que posee es: " + drones[i].NivelBateria);
            }
            Console.WriteLine("La cantidad de drones operativos es: " + drones.Count);
        }
        static void Main(string[] args)
        {
            CentroControl centro = new CentroControl();
            centro.ListarFlota();
            centro.RemoverDronesBajos();
            centro.MostrarDronesRestantes();
            Console.ReadKey();
        }
    }
}
