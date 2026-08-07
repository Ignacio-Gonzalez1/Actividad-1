using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    /*  Un taller mecánico automatizado administra la recepción y egreso de automóviles
        que se encuentran en el sector de reparaciones.
         Crear la clase Vehiculo que contenga como atributos privados: patente
        (string) y costoReparacion (double). Definir sus propiedades
        correspondientes y un constructor que reciba pat y costo.
         Crear la clase GestionTaller que administre una lista de objetos List.
         Métodos en GestionTaller:
        o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
        reparación de un vehículo para agregarlo a la lista mediante .Add().
        o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
        recorriendo la lista, informar si el vehículo está en el taller y mostrar
        su costo asociado.
        o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
        vehículo en la lista y, si existe, removerlo de la colección mediante
        .Remove() confirmando la entrega del automóvil.

        o CalcularRecaudacionPendiente(): Listar los vehículos
        actualmente en reparación, la cantidad total de unidades alojadas en
        el taller mediante la propiedad .Count y la suma total acumulada por
        cobrar.
    */
    class Vehiculo
    {
        private string patente;
        private double costoReparacion;
        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public double CostoReparacion
        {
            set { costoReparacion = value; }
            get { return costoReparacion; }
        }
        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }
    }
    class GestionTaller
    {
        List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
        public void IngresarVehiculo()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Pon La patente del auto: ");
                string pat = Console.ReadLine().ToLower();
                Console.WriteLine("Pon el Costo de reparacion del auto: ");
                string linea = Console.ReadLine();
                double costo = double.Parse(linea);
                Vehiculo IngresarVehiculo = new Vehiculo(pat, costo);
                ListaVehiculos.Add(IngresarVehiculo);
            }
        }
        public void BuscarVehiculo()
        {
            Console.WriteLine("Poner la patente del auto para ver si esta en el taller: ");
            string linea = Console.ReadLine().ToLower();
            foreach (Vehiculo item in ListaVehiculos)
            {
                if (item.Patente == linea)
                {
                    Console.WriteLine("Ese Auto esta en el Taller y su costo de reparacion es: " + item.CostoReparacion);
                    break;
                }
            }
        }
        public void EntregarVehiculo()
        {
            Console.WriteLine("Poner la Patente del auto que esta por entregarse: ");
            string linea = Console.ReadLine().ToLower();
            Vehiculo aux=null;
            foreach (Vehiculo item in ListaVehiculos)
            {
                if (item.Patente == linea)
                {
                    aux = item;
                    break;
                }
            }
            if (aux != null)
            {
                ListaVehiculos.Remove(aux);
                Console.WriteLine("Se confirma la entrega del automovil");
            }
        }
        public void CalcularRecaudacionPendiente()
        {
            Console.WriteLine("Los vehiculos que estan actualmente en reparacion son: ");
            double total = 0;
            foreach (Vehiculo item in ListaVehiculos)
            {
                Console.WriteLine("Patente: " + item.Patente + " costo de reparacion: " + item.CostoReparacion);
                total = total + item.CostoReparacion;
            }
            Console.WriteLine("La cantidad total de Automoviles en el taller son: " + ListaVehiculos.Count + " lo que les queda a cobrar de reparaciones es: " + total);

        }
        static void Main(string[] args)
        {
            GestionTaller taller = new GestionTaller();
            taller.IngresarVehiculo();
            taller.BuscarVehiculo();
            taller.EntregarVehiculo();
            taller.CalcularRecaudacionPendiente();
            Console.ReadKey();
        }
    }
}
