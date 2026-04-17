using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class AlumnosNotas
    {
        /*  Se desea desarrollar un programa que permita registrar los nombres y las
            calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
            nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
            estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
            máxima o mínima.
        */
        private int[] NotasAlumnos;
        private string[] NombresAlumnos, nombreAlumnosNotasAlta, nombreAlumnosNotasBaja;
        private int alto, bajo, MismaNotaAlta, MismaNotaBaja;


        public void CargarNombresYnotas()
        {
            NombresAlumnos = new string[6];
            NotasAlumnos= new int[6];
            for (int i = 0; i < NombresAlumnos.Length; i++)
            {
                Console.WriteLine("Escriba El Nombre del Alumno: ");
                NombresAlumnos[i]=Console.ReadLine();

                Console.WriteLine("Escriba la Nota del Alumno: ");
                string linea;
                linea = Console.ReadLine();
                NotasAlumnos[i]=int.Parse(linea);
            }
        }

        public void NotaAlta()
        {
            alto = NotasAlumnos[0];
            int auxiliar;
            auxiliar = 0;
            MismaNotaAlta = 0;
            nombreAlumnosNotasAlta = new string[6];

            for (int p = 1; p < NombresAlumnos.Length; p++)
            {
                if (alto < NotasAlumnos[p])
                {
                    alto = NotasAlumnos[p];
                    auxiliar = p;
                }
            }
            Console.WriteLine("Los Nombres de Estudiantes con la Nota mas alta es: ");
            Console.WriteLine("Estudiantes: ");
            int j = 0;
            for (int l = 0; l < NombresAlumnos.Length; l++)
            {
                if (NotasAlumnos[l] == alto)
                {
                    MismaNotaAlta = MismaNotaAlta + 1;
                    nombreAlumnosNotasAlta[j] = NombresAlumnos[l];
                    j++;
                }
            }
            for (int f = 0; f < nombreAlumnosNotasAlta.Length; f++)
            {
                Console.WriteLine(nombreAlumnosNotasAlta[f]);
            }
            Console.WriteLine("Nota Sacada: " + alto);
            
        }
        public void NotaBaja()
        {
            bajo = NotasAlumnos[0];
            int aux;
            aux = 0;
            MismaNotaBaja = 0;
            nombreAlumnosNotasBaja = new string[6];

            for (int m = 1; m < NombresAlumnos.Length; m++)
            {
                if (bajo > NotasAlumnos[m])
                {
                    bajo = NotasAlumnos[m];
                    aux = m;
                }
            }
            Console.WriteLine("Nombres de Estudiantes con la Nota mas Baja es: ");
            Console.WriteLine("Estudiantes: ");
            int g = 0;
            for (int y = 0; y < NombresAlumnos.Length; y++)
            {
                if (NotasAlumnos[y] == bajo)
                {
                    MismaNotaBaja = MismaNotaBaja + 1;
                    nombreAlumnosNotasBaja[g] = NombresAlumnos[y];
                    g++;

                }
            }
            for (int f = 0; f < nombreAlumnosNotasBaja.Length; f++)
            {
                Console.WriteLine(nombreAlumnosNotasBaja[f]);
            }
            Console.WriteLine("Nota Sacada: " + bajo);
            
        }
        public void MismaNotas()
        {
            Console.WriteLine("La cantidad de alumnos con la misma nota Alta es: " + MismaNotaAlta);
            Console.WriteLine("La cantidad de alumnos con la misma nota Baja es: " + MismaNotaBaja);

        }


        static void Main(string[] args)
        {
            AlumnosNotas Per1 = new AlumnosNotas();
            Per1.CargarNombresYnotas();
            Per1.NotaAlta();
            Per1.NotaBaja();
            Per1.MismaNotas();
            Console.ReadKey();
        }
    }
}
