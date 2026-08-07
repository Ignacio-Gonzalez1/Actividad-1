using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*  En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
        llegada.
         Crear la clase Documento que contenga como atributos privados:
        nombreArchivo (string) y cantidadPaginas (int). Definir sus
        propiedades de solo lectura y un constructor que reciba los parámetros nom
        y pag.
         Crear la clase ServidorImpresion que administre una lista dinámica de
        documentos (List&lt;Documento&gt;).
         Métodos en ServidorImpresion:
        1. AgregarDocumento(): Solicitar por teclado los datos de un
        documento y agregarlo al final de la lista utilizando .Add().
        2. ImprimirSiguiente(): Si la lista no está vacía, simular la
        impresión del primer documento de la lista (mostrar sus datos en
        consola) y removerlo de la colección mediante .RemoveAt(0). Si está
        vacía, advertir que no hay trabajos pendientes.
        3. MostrarColaPendiente(): Listar todos los documentos que
        están esperando ser impresos y la cantidad total de páginas
        acumuladas en la cola de espera utilizando .Count.  
    */
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;
        public string NombreArchivo
        {
            set { nombreArchivo = value; }
            get { return nombreArchivo; }
        }
        public int CantidadPaginas
        {
            set { cantidadPaginas = value; }
            get { return cantidadPaginas; }
        }
        public Documento(string nom,int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }


    class ServidorImpresion
    {
        private int cantidad;
        List<Documento> Impresion = new List<Documento>();
        public ServidorImpresion()
        {
            Console.WriteLine("Agrega cuantos cosas vas a imprimir: ");
            string linea;
            linea = Console.ReadLine();
            cantidad=int.Parse(linea);
        }
        public void AgregarDocumento()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Agrega El nombre del Archivo: ");
                string nA = Console.ReadLine();
                Console.WriteLine("Agrega la Cantidad de Paginas que va tener el Archivo: ");
                string linea;
                linea = Console.ReadLine();
                int cP = int.Parse(linea);
                Documento AgregarDocumento = new Documento(nA,cP);
                Impresion.Add(AgregarDocumento);
            }
        }
        public void ImprimirSiguiente()
        {
            if (Impresion.Count > 0)
            {
                Console.WriteLine("El Nombre del Archivo es: "+ Impresion[0].NombreArchivo+" La cantidad de Paginas es: " + Impresion[0].CantidadPaginas);
                Impresion.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay Trabajos Pendientes");
            }
        }
        public void MostrarColaPendiente()
        {
            int cantidadPaginasTotal = 0;
            Console.WriteLine("Archivos que estan en espera: ");
            for (int i = 0;i < Impresion.Count; i++)
            {
                Console.WriteLine(Impresion[i].NombreArchivo);
                cantidadPaginasTotal= cantidadPaginasTotal + Impresion[i].CantidadPaginas;
            }
            Console.WriteLine("La cantidad de paginas en cola de espera es: "+ cantidadPaginasTotal);
        }

        static void Main(string[] args)
        {
            ServidorImpresion server1 = new ServidorImpresion();
            server1.AgregarDocumento();
            server1.ImprimirSiguiente();
            server1.MostrarColaPendiente();
            Console.ReadKey();
        }
    }
}
