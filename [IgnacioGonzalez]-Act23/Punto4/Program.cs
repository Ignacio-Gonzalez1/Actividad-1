using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*  Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
        vinculados a una red hogareña.
         Crear la clase DispositivoInteligente que contenga como atributos
        privados: nombreDispositivo (string) y consumoWatts (double). Definir
        sus propiedades y un constructor que reciba nom y watts.
         Crear la clase colaboradora PanelDomotico que administre un objeto
        List&lt;DispositivoInteligente&gt;.
         Métodos en PanelDomotico:
        1. Un constructor que permita al usuario cargar dinámicamente
        dispositivos por teclado. El sistema preguntará después de cada
        carga si se desea agregar otro dispositivo.
        2. MostrarDispositivos(): Listar todos los dispositivos
        configurados junto a sus consumos.
        3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
        Watts totales que consume la casa sumando los valores de la lista.
        4. DesconectarDispositivo(): Solicitar al usuario el nombre de
        un dispositivo y, si existe en la lista, removerlo de forma dinámica
        para simular su apagado remoto.
    */
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;
        public string NombreDispositivo
        {
            set { nombreDispositivo = value; }
            get { return nombreDispositivo; }
        }
        public double ConsumoWatts
        {
            set { consumoWatts = value; }
            get { return consumoWatts; }
        }
        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }
    class PanelDomotico
    {
        List<DispositivoInteligente> ListaDispositivos = new List<DispositivoInteligente>();
        public PanelDomotico()
        {
            do
            {
                Console.WriteLine("Pon el nombre del dispotivo: ");
                string nom = Console.ReadLine().ToLower();
                Console.WriteLine("Pon los watts que consume el dispotivo: ");
                string linea;
                linea = Console.ReadLine();
                double watts = double.Parse(linea);
                DispositivoInteligente AgregarDispotivo = new DispositivoInteligente(nom, watts);
                ListaDispositivos.Add(AgregarDispotivo);
                Console.WriteLine("¿Quieres seguir agregando dispositivos? (Si o No)");
                linea = Console.ReadLine().ToLower();
                if (linea == "no")
                {
                    break;
                }
            }
            while (true);
        }
        public void MostrarDispositivos()
        {
            Console.WriteLine("El Listado de Dispositivos: ");
            foreach (DispositivoInteligente dispositivo in ListaDispositivos)
            {
                Console.WriteLine("El nombre del dispositivo es: " + dispositivo.NombreDispositivo + " El consumo de Watts que tiene es: " + dispositivo.ConsumoWatts);
            }
        }
        public void CalcularConsumoTotal()
        {
            double total = 0;
            foreach (DispositivoInteligente dispositivo in ListaDispositivos)
            {
                total = total + dispositivo.ConsumoWatts;
            }
            Console.WriteLine("Sumando los dispositivos de la lista, la casa gasta en total: " + total + "Watts");
        }

        public void DesconectarDispositivo()
        {
            Console.WriteLine("Ingresa un nombre de un Dispositivo que quieras desconectar: ");
            string linea;
            linea = Console.ReadLine().ToLower();
            bool resultado = ListaDispositivos.Exists(p => p.NombreDispositivo == linea);
            if (resultado == true)
            {
                int posicion = ListaDispositivos.FindIndex(p => p.NombreDispositivo == linea);
                ListaDispositivos.RemoveAt(posicion);
                Console.WriteLine("El listado nuevo: ");
                double total = 0;
                foreach (DispositivoInteligente dispositivo in ListaDispositivos)
                {
                    Console.WriteLine("El nombre del dispositivo es: " + dispositivo.NombreDispositivo + " El consumo de Watts que tiene es: " + dispositivo.ConsumoWatts);
                    total = total + dispositivo.ConsumoWatts;
                }
                Console.WriteLine("Consumo Total Actual es: " + total + "Watts");
            }
            else
            {
                Console.WriteLine("Ese dispositivo no fue encontrado en la Lista");
            }
        }
        static void Main(string[] args)
        {
            PanelDomotico panel = new PanelDomotico();
            panel.MostrarDispositivos();
            panel.CalcularConsumoTotal();
            panel.DesconectarDispositivo();
            Console.ReadKey();
        }
    }
}
