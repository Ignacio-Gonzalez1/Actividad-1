using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    /*  Una farmacia controla el nivel de stock de sus medicamentos para evitar el
        desabastecimiento de insumos esenciales.
         Crear la clase Medicamento que contenga los atributos privados: nombre
        (string) y stock (int). Definir sus propiedades correspondientes. Su
        constructor debe recibir nom y stk.
         Crear la clase ControlFarmacia que administre una lista de objetos List.
         Métodos en ControlFarmacia:
        o Un constructor que cargue por teclado una lista inicial de 4
        medicamentos ingresando sus nombres y stock.
        o ListarStock(): Mostrar la lista de medicamentos en pantalla.

        o RemoverAgotados(): Recorrer la lista y remover por completo de
        la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
        o MostrarMedicamentosDisponibles(): Imprimir la lista
        actualizada y la cantidad de productos disponibles en el inventario
        utilizando la propiedad .Count.
    */
    class Medicamento
    {
        private string nombre;
        private int stock;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Stock
        {
            set { stock = value; }
            get { return stock; }
        }
        public Medicamento(string nom,int stk)
        {
            nombre = nom;
            stock = stk;
        }
    }
    class ControlFarmacia
    {
        List<Medicamento> ListadoMedicamentos= new List<Medicamento>();
        public ControlFarmacia()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Poner el nombre del Medicamento: ");
                string nom = Console.ReadLine();
                Console.WriteLine("Poner El Stock del Medicamento: ");
                string linea = Console.ReadLine();
                int stk = int.Parse(linea);
                Medicamento AgregarMedicamento= new Medicamento(nom,stk);
                ListadoMedicamentos.Add(AgregarMedicamento);
            }
        }

        public void ListarStock()
        {
            Console.WriteLine("La lista de Medicamentos: ");
            foreach (Medicamento item in ListadoMedicamentos)
            {
                Console.WriteLine("Nombre del Medicamento: "+item.Nombre);
            }
        }
        public void RemoverAgotados()
        {
            ListadoMedicamentos.RemoveAll(item => item.Stock == 0);
        }
        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("La Lista Actualizada: ");
            foreach (Medicamento item in ListadoMedicamentos)
            {
                Console.WriteLine("Nombre del Medicamento: " + item.Nombre);
            }
            Console.WriteLine("La Cantidad de Medicamentos que quedan disponible son: "+ ListadoMedicamentos.Count);
        }



        static void Main(string[] args)
        {
            ControlFarmacia control = new ControlFarmacia();
            control.ListarStock();
            control.RemoverAgotados();
            control.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}
