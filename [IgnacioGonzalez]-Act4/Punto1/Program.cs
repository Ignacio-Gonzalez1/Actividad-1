using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            $500, realizar un programa que lea los sueldos que cobra cada empleado e
            informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            de $300.Además el programa deberá informar el importe que gasta la empresa
            en sueldos al personal.
            */
            int cantidadEmpleados_100_300, cantidadEmpleados_300_500, sueldo, sueldosEmpleados, corte;
            string linea;
            corte=0;
            sueldo=0;
            cantidadEmpleados_100_300 = 0;
            cantidadEmpleados_300_500 = 0;
            sueldosEmpleados = 0;

            Console.WriteLine("Ingresa la cantidad de Empleados que vas a tomar: ");
            linea = Console.ReadLine();
            corte = int.Parse(linea);

            while (corte != 0)
            {

                Console.WriteLine("Ingresa salarios entre 100 hasta 500: ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                if (sueldo < 100 || sueldo > 500)
                {
                    Console.WriteLine("Cumple las condiciones de Sueldo");
                }
                    if (sueldo >= 100 && sueldo <= 500)
                    {
                        if (sueldo >= 100 && sueldo <= 300)
                        {
                            cantidadEmpleados_100_300++;
                        } else{
                                cantidadEmpleados_300_500++;
                            }
                        sueldosEmpleados = sueldosEmpleados + sueldo;
                        sueldo = 0;
                        --corte;
                    //Console.WriteLine(corte);
                    }



            }
            Console.WriteLine("Empleados que tienen sueldos entre $100 y $300: " + cantidadEmpleados_100_300);
            Console.WriteLine("Empleados que tienen sueldos mas alto de $300 son: " + cantidadEmpleados_300_500 );
            Console.WriteLine("la cantidad que esta gastando la empresa en suedos: " + sueldosEmpleados);

            Console.ReadKey();
        }
            
    }





    

    
}

