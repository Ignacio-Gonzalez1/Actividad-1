using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class CriaturaMarina
    {
        /*  Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
            La clase CriaturaMarina debe tener como atributos privados: Especie (string),
            ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
            propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
                ●   La profundidad óptima sea estrictamente mayor a cero (0).
                ●   El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
                    asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
            La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
            de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
            criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
            a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
            nivel de salinidad para sobrevivir.
        */
        private string especie;
        private int profundidadOptima;
        private int nivelSalinidad;
        public string Especie
        {
            set
            {
                especie = value;
            }
            get
            {
                return especie;
            }
        }
        public int ProfundidadOptima
        {
            set
            {
                profundidadOptima = value;
            }
            get
            {
                return profundidadOptima;
            }
        }
        public int NivelSalinidad
        {
            set
            {
                nivelSalinidad = value;
            }
            get
            {
                return nivelSalinidad;
            }
        }
        public CriaturaMarina()
        {
            Console.WriteLine("Poner la especie del animal: ");
            especie = Console.ReadLine();
            string linea;
            Console.WriteLine("Poner la Profundidad Optima de la especie (en metros): ");
            do 
            {
                linea = Console.ReadLine();
                if (int.Parse(linea)>0)
                {
                    profundidadOptima = int.Parse(linea);
                    break;
                }
                else
                {
                    Console.WriteLine("Poner una Profundidad que sea Mayor a 0");
                }
            }while (true);
            Console.WriteLine("Poner el nivel de salinidad que necesita la especie para sobrevivir: ");
            linea = Console.ReadLine();
            if (int.Parse(linea)>=1 && int.Parse(linea) <=100)
            {
                nivelSalinidad = int.Parse(linea);
            }
            else
            {
                nivelSalinidad= 35;
            }
        }
    }
    class HabitatAcuatico
    {
        private CriaturaMarina[] totalCriaturasMarinas;
        public HabitatAcuatico()
        {
            totalCriaturasMarinas= new CriaturaMarina[3];
            for (int i = 0; i < totalCriaturasMarinas.Length; i++)
            {
                totalCriaturasMarinas[i] = new CriaturaMarina();
            }
        }
        public void imprimirLasCriaturasDeMenorAMayor()
        {
            Console.WriteLine("Las Criaturas Marinas de menor a Mayor: ");
            CriaturaMarina aux;
            for (int i = 0; i<totalCriaturasMarinas.Length; i++)
            {
                for (int j = 0; j < totalCriaturasMarinas.Length -1 - i; j++)
                {
                    if (totalCriaturasMarinas[i].ProfundidadOptima> totalCriaturasMarinas[i + 1].ProfundidadOptima)
                    {
                        aux = totalCriaturasMarinas[i];
                        totalCriaturasMarinas[i] = totalCriaturasMarinas[i + 1];
                        totalCriaturasMarinas[i+1] = aux;
                    }
                }
            }
            for(int i = 0; i<totalCriaturasMarinas.Length; i++)
            {
                Console.WriteLine("La Criatura Marina es: " + totalCriaturasMarinas[i].Especie+" La profundidad optima de la especie es: " + totalCriaturasMarinas[i].ProfundidadOptima+"m"+" la Salinidad que necesita para sobrevivir es: " + totalCriaturasMarinas[i].NivelSalinidad);
            }
        }
        public void RequiereMayorNivelSalinidad()
        {
            int mayor = totalCriaturasMarinas[0].NivelSalinidad;
            int k = 0;
            for (int i = 1;i<totalCriaturasMarinas.Length; i++)
            {
                if (mayor < totalCriaturasMarinas[i].NivelSalinidad)
                {
                    mayor = totalCriaturasMarinas[i].NivelSalinidad;
                    k = i;
                }
            }
            Console.WriteLine("La especie que necesita Mayor nivel de salinidad es: " + totalCriaturasMarinas[k].Especie+" la salinidad que necesita para sobrevivir es "+mayor);
        }
        static void Main(string[] args)
        {
            HabitatAcuatico habitat1 = new HabitatAcuatico();
            habitat1.imprimirLasCriaturasDeMenorAMayor();
            habitat1.RequiereMayorNivelSalinidad();
            Console.ReadKey();
        }
    }
}
