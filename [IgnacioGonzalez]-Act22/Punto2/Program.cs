using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*  Actividad 2: Posicionamiento de elementos en consola
        Problema:
        Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
         Implementar propiedades y un constructor que cargue valores.
         Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
        nombre en pantalla y Console.CursorVisible para ocultar el cursor.
         Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
        consola.
    */
    class ElementoPantalla
    {
        private string nombre;
        private int posX, posY;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int PosX
        {
            set { posX = value; }
            get { return posX; }
        }
        public int PosY
        {
            set { posY = value; }
            get { return posY; }
        }
        public ElementoPantalla()
        {
            Console.WriteLine("Poner el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Poner la posicion X: ");
            string linea;
            linea = Console.ReadLine();
            posX = int.Parse(linea);
            Console.WriteLine("Poner la posicion Y: ");
            linea = Console.ReadLine();
            posY = int.Parse(linea);
        }
    }
    class Program
    {
        private ElementoPantalla[] ElementoPantallaTotal;
        public Program()
        {
            ElementoPantallaTotal = new ElementoPantalla[4];
            for (int i = 0; i < ElementoPantallaTotal.Length; i++)
            {
                ElementoPantallaTotal[i] = new ElementoPantalla();
            }
        }
        public void Metodo()
        {
            Console.Clear();
            for (int i = 0; i < ElementoPantallaTotal.Length; i++)
            {
                Console.SetCursorPosition(ElementoPantallaTotal[i].PosX, ElementoPantallaTotal[i].PosY);
                Console.CursorVisible = false;
                Console.WriteLine(ElementoPantallaTotal[i].Nombre);

            }
        }


        static void Main(string[] args)
        {
            Program program1 = new Program();
            program1.Metodo();
            Console.ReadKey();
        }
    }
}