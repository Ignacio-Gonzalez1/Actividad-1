using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    /*  Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
        realizar el seguimiento académico de sus materias.
         Crear la clase Estudiante que contenga como atributos privados:
        nombreCompleto (string) y calificacion (double). Definir sus propiedades
        de solo lectura y un constructor que reciba nom y cal.
         Crear la clase GestionAcademica que administre una lista de objetos
        List.
         Métodos en GestionAcademica:
        o CargarEstudiantes(): Solicitar por teclado nombres y
        calificaciones para agregar estudiantes a la lista mediante .Add(). La
        carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
        nombre.
        o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
        junto a la cantidad total de inscriptos mediante la propiedad .Count.
        o FiltrarAprobados(): Recorrer la lista e imprimir en consola
        únicamente aquellos estudiantes cuya calificación sea mayor o igual
        a 6.0.
        o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
        utilizando los métodos de búsqueda y remoción de listas, eliminarlo
        de la colección si se encuentra presente.
    */
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;
        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public double Calificacion
        {
            get { return calificacion; }
        }
        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }
    }
    class GestionAcademica
    {
        List<Estudiante> ListadoEstudiantes = new List<Estudiante>();
        public void CargarEstudiantes()
        {
            do
            {
                Console.WriteLine("Pon los Nombres de los Estudiantes: ");
                string linea;
                linea = Console.ReadLine().ToLower();
                string nom;
                if (linea == "fin")
                {
                    break;
                }
                else
                {
                    nom = linea;
                }
                Console.WriteLine("Poner la Calificacion que obtuvo cada Estudiantes: ");
                linea = Console.ReadLine();
                double cal = double.Parse(linea);
                Estudiante agregarEstudiantes = new Estudiante(nom, cal);
                ListadoEstudiantes.Add(agregarEstudiantes);
            }
            while (true);
        }
        public void ListarEstudiantes()
        {
            for (int i = 0; i < ListadoEstudiantes.Count; i++)
            {
                Console.WriteLine("Nombre de Alumno: " + ListadoEstudiantes[i].NombreCompleto + " Su calificacion es: " + ListadoEstudiantes[i].Calificacion);
            }
            Console.WriteLine("La cantidad de Alumnos inscriptos es: " + ListadoEstudiantes.Count);
        }
        public void FiltrarAprobados()
        {
            Console.WriteLine("Los Alumnos Aprobados son: ");
            foreach (Estudiante item in ListadoEstudiantes)
            {
                if (item.Calificacion >= 6)
                {
                    Console.WriteLine("Nombre del Alumno: " + item.NombreCompleto);
                }
            }
        }
        public void DarDeBaja()
        {
            Console.WriteLine("Poner el Nombre del Alumno al que quieres dar de Baja: ");
            string linea = Console.ReadLine().ToLower();
            bool resultado = ListadoEstudiantes.Exists(p => p.NombreCompleto == linea);
            if (resultado == true)
            {

                int posicion = ListadoEstudiantes.FindIndex(p => p.NombreCompleto == linea);
                ListadoEstudiantes.RemoveAt(posicion);
                Console.WriteLine("El Alumno " + linea + " fue dado de baja exitosamente");
            }
            else { Console.WriteLine("No fue encontrado el Alumno"); }
        }
        static void Main(string[] args)
        {
            GestionAcademica gestion = new GestionAcademica();
            gestion.CargarEstudiantes();
            gestion.ListarEstudiantes();
            gestion.FiltrarAprobados();
            gestion.DarDeBaja();
            Console.ReadKey();
        }
    }
}
