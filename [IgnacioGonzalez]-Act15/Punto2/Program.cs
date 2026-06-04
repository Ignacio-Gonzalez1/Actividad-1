using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class NaveEspacial
    {
        /*  Logística de Puerto Espacial
            Una estación de acoplamiento registra el peso de los contenedores transportados en las
            bodegas de carga de las naves espaciales que llegan al puerto.
            ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
            NombreNave y su constructor para cargarlo.
            ● Crear la clase colaboradora PuertoControl que contenga:
                ○ Un vector de 3 objetos de la clase NaveEspacial.
                ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
                cada fila representa a una nave, el tamaño de la fila es la cantidad de
                bodegas que posee esa nave, y los valores almacenados son los pesos (en
                toneladas) de los contenedores que transporta cada bodega.

            En PuertoControl, definir los siguientes métodos:

                1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
                cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
                irregular) y cargue el peso del contenedor asignado a cada bodega.
                2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
                espacial.
                3. Un método que identifique e informe qué nave transporta el contenedor individual
                más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
                irregular).
                4. Un método que indique el nombre de la nave que transporta menor peso acumulado
                total (la suma de todos sus contenedores).
        */
        private string NombreNave;
        private int CantidadDeBodegas;
        public NaveEspacial()
        {
            Console.WriteLine("Nombre de la Nave: ");
            NombreNave = Console.ReadLine();

        }
        public string retornarNombreNave()
        {
            return NombreNave;
        }
    }
    class PuertoControl
    {
        private NaveEspacial[] TotalNaves;
        private double[][] pesoContenedores;
        private double[] pesoTotalDeLasNaves;

        public PuertoControl()
        {
            TotalNaves = new NaveEspacial[3];
            for (int i = 0; i < TotalNaves.Length; i++)
            {
                TotalNaves[i] = new NaveEspacial();
            }
            pesoContenedores = new double[3][];
            for (int i = 0;i < TotalNaves.Length; i++)
            {
                Console.WriteLine("Poner la cantidad de bodegas activas que posee la Nave: " + TotalNaves[i].retornarNombreNave());
                string linea;
                linea = Console.ReadLine();
                int l = 0;
                l=int.Parse(linea);

                pesoContenedores[i]=new double[l];
            }
            for (int i = 0;i<pesoContenedores.Length; i++)
            {
                Console.WriteLine("Nave Espacial: "+ TotalNaves[i].retornarNombreNave());
                for (int j = 0;j<pesoContenedores[i].Length ; j++)
                {
                    double l = 0;
                    Console.WriteLine("Poner la cantidad de peso (esta en toneladas) que tiene en esa bodega: ");
                    string linea;
                    linea=Console.ReadLine();
                    l= int.Parse(linea);
                    pesoContenedores[i][j] = l;
                }
            }
        }

        public void ElpesoCadaNave()
        {
                for(int j = 0; j<pesoContenedores.Length; j++)
                {
                    Console.WriteLine("Los pesos de la Nave: " + TotalNaves[j].retornarNombreNave());
                    for (int k = 0;k < pesoContenedores[j].Length; k++)
                    {
                        Console.Write(pesoContenedores[j][k]+"t"+"  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
        }
        public void ElMayorPeso()
        {
            double pesoMayor = pesoContenedores[0][0];
            int h=0;
            
                for (int j = 0; j < pesoContenedores.Length; j++)
                {
                    for (int k = 0; k < pesoContenedores[j].Length; k++)
                    {
                        if(pesoMayor< pesoContenedores[j][k])
                        {
                            pesoMayor = pesoContenedores[j][k];
                            h = j;
                        }
                    }
                }
            Console.WriteLine("El peso individual mayor de la nave es de la nave " + TotalNaves[h].retornarNombreNave()+ " y el peso es: " + pesoMayor+"t");
        }

        public void ElmenorPesoTotal()
        {
            pesoTotalDeLasNaves = new double[3];
                for (int j = 0; j < pesoContenedores.Length; j++)
                {
                    double pesototal = 0;
                    for (int k = 0; k < pesoContenedores[j].Length; k++)
                    {
                        pesototal = pesototal + pesoContenedores[j][k];
                    }
                    pesoTotalDeLasNaves[j] = pesototal;

                }
            
            double menor = pesoTotalDeLasNaves[0];
            int ñ = 0;
            for (int j = 0;j<pesoTotalDeLasNaves.Length; j++)
            {
                if (pesoTotalDeLasNaves[j] < menor)
                {
                    menor = pesoTotalDeLasNaves[j];
                    ñ = j;

                }
            }
            Console.WriteLine("El que tiene el Menor peso acumulado es la nave " + TotalNaves[ñ].retornarNombreNave()+" con un peso total de: "+menor +"t");
        }







        static void Main(string[] args)
       {
            PuertoControl control = new PuertoControl();
            control.ElpesoCadaNave();
            control.ElMayorPeso();
            control.ElmenorPesoTotal();
            Console.ReadKey();
        }
    }
}
