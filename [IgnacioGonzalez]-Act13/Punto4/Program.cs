using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Alumno
    {
        /*  Plantear una clase Alumno que tenga los atributos privados: nombre y un
            vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
            alumno y sus 4 calificaciones.
            Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
            Alumno.
            Agregar los siguientes métodos:
                a) Un método que imprima el nombre de cada alumno y su promedio.
                b) Un método que muestre el nombre del alumno con el promedio más
                alto.
                c) Un método que indique qué alumnos tienen al menos una nota
                desaprobada (nota menor a 6)
        */
        private string nombre;
        private int[] notas;
        private double promedio;
        public Alumno()
        {
            notas = new int[4];
            Console.WriteLine("Cargar El Nombre del Alumno: ");
            nombre = Console.ReadLine();
            
            for(int i = 0; i < notas.Length; i++)
            {
                int corte = 0;
                Console.WriteLine("Cargar la nota de " + nombre + " la calificacion " + (i + 1));
                do
                {
                    string linea;
                    linea = Console.ReadLine();

                    if (int.Parse(linea) >= 0 && int.Parse(linea)<=10)
                    {
                        notas[i] = int.Parse(linea);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Poner una nota entre 0 y 10");
                    }
                } while (corte!=1);
            }            
        }
        public string retornarNombre()
        {
            return nombre;
        }
        public int[] retornarNotas()
        {
            return notas;
        }
        public double retornarPromedio()
        {
            promedio = 0;
            for(int i = 0; i<notas.Length; i++)
            {
                promedio = promedio + notas[i];
            }
            promedio = (double)promedio / 4;
            return promedio;
        }
    }
    class Curso
    {
        private Alumno alumno1, alumno2, alumno3;
        private double[] Nota1, Nota2, Nota3;

        public Curso()
        {
            alumno1 = new Alumno();
            alumno2 = new Alumno();
            alumno3 = new Alumno();
        }

        public void PromedioDeLosAlumnos()
        {
            Console.WriteLine("El Promedio del alumno " + alumno1.retornarNombre() + " es: " + alumno1.retornarPromedio());
            Console.WriteLine("El Promedio del alumno " + alumno2.retornarNombre() + " es: " + alumno2.retornarPromedio());
            Console.WriteLine("El Promedio del alumno " + alumno3.retornarNombre() + " es: " + alumno3.retornarPromedio());
        }
        public void PromedioMasAlto()
        {
            double PromedioMasAlto = alumno1.retornarPromedio();
            string NombreDePromedioAlto= alumno1.retornarNombre();
            if (PromedioMasAlto<alumno2.retornarPromedio())
            {
                PromedioMasAlto = alumno2.retornarPromedio();
                NombreDePromedioAlto = alumno2.retornarNombre();
            }
            if (PromedioMasAlto < alumno3.retornarPromedio())
            {
                PromedioMasAlto = alumno3.retornarPromedio();
                NombreDePromedioAlto = alumno3.retornarNombre();
            }
            Console.WriteLine("El que tiene el mayor promedio es " + NombreDePromedioAlto + " y tiene un promedio: " +PromedioMasAlto);
        }
        public void TenerUnoNotaDesaprobada()
        {
            Nota1 = new double[4];
            Nota2 = new double[4];
            Nota3 = new double[4];
            int desaprobado1 = 0;
            int desaprobado2 = 0;
            int desaprobado3 = 0;

            for (int i = 0; i < Nota1.Length; i++)
            {
                Nota1[i] = alumno1.retornarNotas()[i];
                Nota2[i] = alumno2.retornarNotas()[i];
                Nota3[i] = alumno3.retornarNotas()[i];
            }
            for (int i = 0;i < Nota1.Length; i++)
            {
                if (Nota1[i] < 6)
                {
                    desaprobado1 ++;
                }
                if (Nota2[i] < 6)
                {
                    desaprobado2++;
                }
                if (Nota3[i] < 6)
                {
                    desaprobado3++;
                }
            }
            if(desaprobado1 > 0)
            {
                Console.WriteLine("El Alumno " +alumno1.retornarNombre()+" tiene una nota desaprobada");
            }
            if (desaprobado2 > 0)
            {
                Console.WriteLine("El Alumno " + alumno2.retornarNombre() + " tiene una nota desaprobada");
            }
            if (desaprobado3 > 0)
            {
                Console.WriteLine("El Alumno " + alumno3.retornarNombre() + " tiene una nota desaprobada");
            }
        }


        static void Main(string[] args)
        {
            Curso Curso1=new Curso();
            Curso1.PromedioDeLosAlumnos();
            Curso1.PromedioMasAlto();
            Curso1.TenerUnoNotaDesaprobada();
            Console.ReadKey();
        }
    }
}
