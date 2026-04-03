using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        class Plano
        {
            /*  Desarrollar una clase que represente un punto en el plano y tenga los
                siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
                encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
                positivas, si x<0 e y>0 segundo cuadrante, etc.)
            */
            private int x, y;


            public void CargarDatos()
            {
                string linea;
                Console.WriteLine("Poner el Punto X: ");
                linea = Console.ReadLine();
                x = int.Parse(linea);

                Console.WriteLine("Poner el Punto Y: ");
                linea = Console.ReadLine();
                y = int.Parse(linea);
            }


            public void CuadranteUbicado()
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Se encuentra en El Primer Cuadrante");
                }
                else
                    if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Se encuentra en El Segundo Cuadrante");
                    }else
                        if (x > 0 && y < 0)
                        {
                            Console.WriteLine("Se encuentra en El Tercer Cuadrante");
                        } else
                            if (x < 0 && y < 0)
                            {
                                Console.WriteLine("Se encuentra en El Cuarto Cuadrante");
                            }

            }

            static void Main(string[] args)
            {
                Plano Plano1 = new Plano();
                Plano1.CargarDatos();
                Plano1.CuadranteUbicado();
                Console.ReadKey();
            }
        }
    }
}
