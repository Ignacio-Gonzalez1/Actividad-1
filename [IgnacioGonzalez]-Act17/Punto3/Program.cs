using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Computadora
    {
        /*  3. Fábrica de Computadoras (Herencia y Constructores con base)
        Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:
             Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
             Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
    */
        protected string marca;
        protected int memoriaRAM;

        public Computadora(string m, int mR)
        {
            marca = m;
            memoriaRAM = mR;
        }

    }
    class Notebook : Computadora
    {
        private float TamañoPantalla;
        public Notebook(string m, int mR, float tP) : base (m, mR)
        {
            TamañoPantalla = tP;
            Console.WriteLine("La computadora es: "+ m+ " La memoria Ram: "+mR+ " El Tamaño de Pantalla es: " + tP);
        }

    }
    class Escritorio : Computadora
    {
        private int PotenciaFuente;
        public Escritorio(string m, int mR, int pF) : base(m, mR)
        {
            PotenciaFuente = pF;
            Console.WriteLine("La computadora es: " + m + " La memoria Ram: " + mR + " La potencia de la fuente de la computadora es: " + pF+"W");

        }
    }


    class Prueba
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Lenovo",16, 13.3f);
            Escritorio escritorio1=new Escritorio("Red Dragon",32,600);
            Console.ReadKey();
        }
    }
}
