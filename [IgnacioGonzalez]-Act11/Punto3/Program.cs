using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto3
{
    internal class Administracion
    {
        /*  Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
            empresa.
            Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
            irregular para cargar los días que han faltado cada empleado (cargar el número de día que
            faltó)
            Cada fila de la matriz representa los días de cada empleado.
                a. Mostrar los empleados con la cantidad de inasistencias.
                b. Cuál empleado faltó menos días.
        */
        private string[] NomnbreEmpleados;
        private int[][] diasfaltados;
        private int cantidadDiasFaltados;

        public void cargarDatos()
        {
            NomnbreEmpleados = new string[3];
            diasfaltados = new int[3][];
            for (int i = 0; i < NomnbreEmpleados.Length; i++)
            {
                Console.WriteLine("Poner el nombre de los empleados: ");
                NomnbreEmpleados[i]= Console.ReadLine();
            }
            for(int i = 0;i < diasfaltados.Length; i++)
            {
                Console.WriteLine("Poner la cantidad de dias que falto  " + NomnbreEmpleados[i] + "  en la empresa: ");
                string linea;
                linea = Console.ReadLine();
                cantidadDiasFaltados= int.Parse(linea);
                diasfaltados[i]= new int[cantidadDiasFaltados];
            }
            for (int i = 0; i < diasfaltados.Length; i++)
            {
                Console.WriteLine("poner los dias faltados del empleado "+ NomnbreEmpleados[i]+ "  en la empresa: ");
                for (int j = 0; j < diasfaltados[i].Length; j++)
                {
                    Console.WriteLine("Poner datos: ");
                    string linea;
                    linea = Console.ReadLine();
                    diasfaltados[i][j] = int.Parse(linea);
                }
            }
        }
        public void ImprimirInasistencias()
        {
            for (int i = 0; i < diasfaltados.Length; i++)
            {
                Console.Write("Los dias que falto el empleado: " + NomnbreEmpleados[i] + "  es: ");
                for (int j = 0; j < diasfaltados[i].Length; j++)
                {
                    Console.Write(" " + diasfaltados[i][j] + " ");
                }
                Console.Write("  la cantidad de dias que falto en total serian: " + diasfaltados[i].Length);
                Console.WriteLine();
            }
        }
        public void MenosInasistencias()
        {
            int menos = diasfaltados[0].Length;
            int j = 0;
            for (int i = 0;i < diasfaltados.Length; i++)
            {
                if(menos> diasfaltados[i].Length)
                {
                    menos= diasfaltados[i].Length;
                    j= i;
                }
            }
            Console.WriteLine("El Empleado que menos falto fue: " + NomnbreEmpleados[j] + "  la cantidad de dias que falto fue: " + menos);
        }

        static void Main(string[] args)
        {
            Administracion per1 = new Administracion();
            per1.cargarDatos();
            per1.ImprimirInasistencias();
            per1.MenosInasistencias();
            Console.ReadKey();
        }
    }
}
