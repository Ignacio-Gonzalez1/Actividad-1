using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Punto3
{
    /*  Actividad 3: Estadísticas de visitas a zonas arqueológicas
        Problema:
        Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
        arqueológicas durante 4 semanas.
        Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
        días. Luego:
               Calcular el total de visitas por zona y almacenarlo en un vector.
               Mostrar los datos en forma tabular.
               Agregar estos resultados a una lista llamada zonasVisitadas que contenga
                nombres de zonas y total de visitas.
               Determinar cuál fue la zona más visitada.
    */
    class Zona
    {
        private string nombre;
        private int totalVisitas;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get { return nombre; }
        }
        public int TotalVisitas
        {
            set { totalVisitas = value; }
            get { return totalVisitas; }
        }
        public Zona(string n,int tV)
        {
            nombre=n;
            totalVisitas=tV;
        }
    }
    class arqueología
    {
        private int[,] Matriz;
        private int[] AlmacenadoCompleto;
        List<Zona> zonasVisitadas = new List<Zona>();
        
        public arqueología()
        {
            Matriz = new int[3,4];
            for ( int i = 0; i < Matriz.GetLength(0); i++)
            {
                Console.WriteLine("Poner datos de visita de la zona: " + (i + 1));
                for ( int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Poner la visita del dia "+(j+1)+": ");
                    string linea;
                    linea = Console.ReadLine();
                    Matriz[i,j]= int.Parse(linea);
                }
            }            
        }
        public void calcularTotaldeVisitas()
        {
            AlmacenadoCompleto= new int[3];
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    total += Matriz[i,j];
                }
                AlmacenadoCompleto[i] = total;
            }
        }
        public void Mostrar()
        {
            for (int i = 0;i < AlmacenadoCompleto.Length; i++)
            {
                Console.Write(" |" + AlmacenadoCompleto[i] + "|");
            }
            Console.WriteLine();
        }
        public void MeterDatosEnLaLista()
        {
            for (int i = 0;i<AlmacenadoCompleto.Length ; i++)
            {
                Console.WriteLine("Pon el nombre de como se llama la zona "+(i+1)+": ");
                string n= Console.ReadLine();
                int tV = AlmacenadoCompleto[i];
                Zona NuevaArqueologia = new Zona(n,tV);
                zonasVisitadas.Add(NuevaArqueologia);
            }
        }
        public void LaZonaMasVisitada()
        {
            int Mayor = zonasVisitadas[0].TotalVisitas;
            int k = 0;
            int j = 0;
            foreach (Zona i in zonasVisitadas)
            {
                if (Mayor<i.TotalVisitas)
                {
                    Mayor=i.TotalVisitas;
                    j = k;
                }
                k++;
            }
            Console.WriteLine("La zona mas visitada es: " + zonasVisitadas[j].Nombre+" con un total de visitas de "+Mayor+" de personas.");
        }








        static void Main(string[] args)
        {
            arqueología arqueología1 = new arqueología();
            arqueología1.calcularTotaldeVisitas();
            arqueología1.Mostrar();
            arqueología1.MeterDatosEnLaLista();
            arqueología1.LaZonaMasVisitada();
            Console.ReadKey();
        }
    }
}
