using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*  Un centro de conservación marina registra de forma dinámica las especies de
        mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
         Crear la clase MonitoreoCostero que contenga como atributo privado
        una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
         Métodos en MonitoreoCostero:
        1. CargarAvistamientos(): Solicitar por teclado nombres de
        especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
        &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
        cuando el usuario ingresa la palabra &quot;FIN&quot;.
        2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
        organizada alfabéticamente de la A a la Z utilizando el método
        .Sort().
        3. MostrarReporteInvertido(): Imprimir la lista organizada de la
        Z a la A combinando .Sort() con el método .Reverse().
        4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
        animal y, utilizando los métodos de búsqueda de listas, informar si la
        especie fue divisada en la costa durante el día.
    */
    class MonitoreoCostero
    {
        List<string> especiesDetectadas=new List<string>();
        private string especies;
        public void CargarAvistamientos()
        {
            do
            {
                Console.WriteLine("Pon los Nombres de Las especies avistadas: ");
                string linea;
                linea= Console.ReadLine().ToLower();
                if (linea == "fin")
                {
                    break;
                }
                else
                {
                    especies = linea;
                    especiesDetectadas.Add(especies);
                }
            }
            while (true);
        }
        public void MostrarReporteOrdenado()
        {
            Console.WriteLine("Reporte ordenado en alfabéticamente de la A a la Z");
            especiesDetectadas.Sort();
            foreach(string s in especiesDetectadas)
            {
                Console.WriteLine(s);
            }
        }
        public void MostrarReporteInvertido()
        {
            Console.WriteLine("Reporte invertido alfabéticamente de la Z a la A");
            especiesDetectadas.Reverse();
            foreach (string s in especiesDetectadas)
            {
                Console.WriteLine(s);
            }
        }
        public void BuscarEspecie()
        {
            Console.WriteLine("Ingresa un nombre de un animal que quieras saber si estuvo en el dia: ");
            string linea;
            linea= Console.ReadLine().ToLower();
            bool estaLaEspecie = especiesDetectadas.Contains(linea);
            if (estaLaEspecie==true)
            {
                Console.WriteLine("Si estuvo ese animal en el dia");
            }
            else
            {
                Console.WriteLine("Ese animal no fue visto en la costa");
            }
        }


        static void Main(string[] args)
        {
            MonitoreoCostero monitoreo= new MonitoreoCostero();
            monitoreo.CargarAvistamientos();
            monitoreo.MostrarReporteOrdenado();
            monitoreo.MostrarReporteInvertido();
            monitoreo.BuscarEspecie();
            Console.ReadKey();
        }
    }
}
