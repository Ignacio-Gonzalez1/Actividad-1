using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto7
{
    /*  Un restaurante automatizado procesa la comanda de una mesa para controlar la
        preparación y el cobro de los platos pedidos.
         Crear la clase Plato que contenga como atributos privados: nombrePlato
        (string) y precio (double). Definir sus propiedades correspondientes y un
        constructor que reciba nom y pre.
         Crear la clase GestionComandas que administre una lista de objetos List.
         Métodos en GestionComandas:
        o AgregarPlato():Solicitar por teclado los datos de un plato y
        agregarlo a la lista utilizando .Add().
        o MostrarComanda(): Listar todos los platos agregados hasta el
        momento junto a la cantidad total de ítems pedidos utilizando la
        propiedad .Count.
        o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
        total a cobrar sumando los precios de la lista.
        o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
        se encuentra en la lista, removerlo mediante .Remove() para
        actualizar la comanda.
    */
    class Plato
    {
        private string nombrePlato;
        private double precio;
        public string NombrePlato
        {
            set { nombrePlato = value; }
            get { return nombrePlato; }
        }
        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        public Plato(string nom, double pre)
        {
            nombrePlato= nom;
            precio = pre;
        }
    }
    class GestionComandas
    {
        List<Plato> ListaPlatos= new List<Plato>();

        public void AgregarPlato()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Poner el Nombre del Plato: ");
                string nom = Console.ReadLine().ToLower();
                Console.WriteLine("Poner el Precio del Plato: ");
                string linea= Console.ReadLine();
                double pre = double.Parse(linea);
                Plato agregarPlato = new Plato(nom, pre);
                ListaPlatos.Add(agregarPlato);
            }
        }
        public void MostrarComanda()
        {
            Console.WriteLine("La Lista total de Platos: ");
            for (int i = 0; i < ListaPlatos.Count; i++)
            {
                Console.WriteLine("El nombre del Plato es: "+ListaPlatos[i].NombrePlato + " El precio de ese plato es: " + ListaPlatos[i].Precio);
            }
            Console.WriteLine("La cantidad total de platos es: "+ListaPlatos.Count);
        }
        public void CalcularTotalMesa()
        {
            double totalprecios= 0;
            Console.WriteLine("El Precio total a cobrar sumando todos los precios es: ");
            foreach (Plato item in ListaPlatos)
            {
                totalprecios += item.Precio;
            }
            Console.Write(totalprecios+"$");
            Console.WriteLine();
        }
        public void CancelarPlato()
        {
            Console.WriteLine("Poner Un nonbre de un plato para eliminarlo: ");
            string linea = Console.ReadLine().ToLower();
            Plato aux = null;
            foreach (Plato item in ListaPlatos)
            {
                if (item.NombrePlato == linea)
                {
                    aux = item;
                    break;
                }
            }
            if (aux != null)
            {
                ListaPlatos.Remove(aux);
                Console.WriteLine("Se confirma la Eliminacion del Plato: " + aux.NombrePlato);
                double totalprecios = 0;
                Console.WriteLine("El Precio total a cobrar ahora es: ");
                foreach (Plato item in ListaPlatos)
                {
                    totalprecios += item.Precio;
                }
                Console.Write(totalprecios + "$");
                Console.WriteLine();
            }
            if (aux == null)
            {
                Console.WriteLine("Ese Plato no se encuentra.");
            }
        }

        static void Main(string[] args)
        {
            GestionComandas gestion= new GestionComandas();
            gestion.AgregarPlato();
            gestion.MostrarComanda();
            gestion.CalcularTotalMesa();
            gestion.CancelarPlato();
            Console.ReadKey();
        }
    }
}
