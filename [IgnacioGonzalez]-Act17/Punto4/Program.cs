using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Material
    {
        /*  Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
            herencia: Material, Herramienta y Martillo.
                 La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
                Plástico).
                 La clase Herramienta (que hereda de Material) debe añadir el atributo
                FuncionPrincipal.
                 La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
            Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
            correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
            acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
            (ejemplo: "Constructor de la clase Material ejecutado").
            En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
            parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
            en cadena de los constructores (desde la raíz hasta la clase derivada).
        */
        protected string TipoMaterial;
        public Material(string tM)
        {
            TipoMaterial = tM;
            Console.WriteLine("Constructor de la clase Material ejecutado");
        }
    }
    class Herramienta : Material
    {
        protected string FuncionPrincipal;
        public Herramienta(string tM, string fP) : base (tM)
        {
            FuncionPrincipal = fP;
            Console.WriteLine("Constructor de la clase Herramienta ejecutado");
        }
    }
    class Martillo : Herramienta
    {
        protected float PesoGramos;
        public Martillo(string tM, string fP, float pG) : base(tM, fP)
        {
            PesoGramos = pG;
            Console.WriteLine("Constructor de la clase Martillo ejecutado");
            Console.WriteLine("El tipo de material de la herramienta es: "+tM+" La funcion Principal es: "+fP+" El peso en gramos es: "+pG);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Martillo martillo1 = new Martillo("Acero", "Martillar", 433.5f);
            Console.ReadKey();
        }
    }
}
