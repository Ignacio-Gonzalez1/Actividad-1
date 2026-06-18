using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class DispositivoEnergia
    {
        /*  Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
            CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
            generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
            generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
            imprimir estos datos básicos.
            Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
            un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
            en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
            Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
            En el programa principal (Main):
                ●   Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
                ●   Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
                    puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
                    muestra de información.
        */
        protected string codigoIdentificador;
        protected double generacionKwh;

        
        public DispositivoEnergia()
        {
            Console.WriteLine("Poner EL Codigo Identificador: ");
            codigoIdentificador = Console.ReadLine();
                Console.WriteLine("Poner la Generacion de Kilowatts-hora generados: ");
                string linea;
                linea = Console.ReadLine();
            if (double.Parse(linea) >= 0)
            {
                generacionKwh = double.Parse(linea);
            }
            else
            {
                generacionKwh = 0;
            }
        }
        public string CodigoIdentificador
        {
            set
            {
                codigoIdentificador = value;
            }
            get
            {
                return codigoIdentificador;
            }
        }
        public double GeneracionKwh
        {
            set
            {
                generacionKwh = value;
            }
            get
            {
                return generacionKwh;
            }
        }
        public void ImprimirDeDispositivoEnergia()
        {
            Console.WriteLine("El Id del DispositivoEnergia es: "+ CodigoIdentificador + " su generacion kWh es: " + GeneracionKwh + "kWh");
        }
    }
    class PanelSolar : DispositivoEnergia
    {
        protected double areaMetros;
        public PanelSolar()
        {
            do
            {
                Console.WriteLine("Poner el area del panel solar en Metros cuadrados: ");
                string linea;
                linea = Console.ReadLine();
                if (double.Parse(linea)>0)
                {
                    areaMetros = double.Parse(linea);
                    break;
                }else
                {
                    Console.WriteLine("Poner un area de metros cuardrados que sea mayor a 0");
                }
            } while (true);
        }

        public double AreaMetros
        {
            set
            {
                areaMetros= value;
            }
            get
            {
                return areaMetros;
            }
        }
        public void Imprimirtodo()
        {
            Console.WriteLine("Su Codigo identificador es: "+CodigoIdentificador+ " Su kWh es: "+ GeneracionKwh+ " y su Area en Metros Cuadrados es: "+AreaMetros+ "m²");
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {
            DispositivoEnergia dispotivo1 = new DispositivoEnergia();
            dispotivo1.ImprimirDeDispositivoEnergia();
            PanelSolar panel1 = new PanelSolar();
            panel1.Imprimirtodo();
            Console.ReadKey();
        }
    }
}
