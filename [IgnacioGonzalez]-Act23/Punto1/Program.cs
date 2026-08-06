using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Documento
    {
        protected string nombreArchivo;
        protected int cantidadPaginas;
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
        protected int cantidad;
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
