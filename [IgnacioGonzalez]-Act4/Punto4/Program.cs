using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
               cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
               finalizar al ingresar un valor negativo en el número de cuenta.
               Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
               informe:
               a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
               que:
               Estado de la cuenta:
               ○ “Acreedor” si el saldo es >0.
               ○ “Deudor” si el saldo es <0.
               ○ “Nulo” si el saldo es =0.
               b) La suma total de los saldos acreedores.
             */
            int numeroCuenta, saldo, corte, saldosAcredores;
            numeroCuenta = 0;
            corte = 0;
            saldo = 0;
            saldosAcredores = 0;
            string linea, mensaje_total, estado_Cuenta;
            mensaje_total ="";
            estado_Cuenta = "";

            do
            {
                Console.WriteLine("Ingresar los Numeros de Cuenta: (al poner un numero negativo termina) ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);
                if (numeroCuenta < 0) { corte = 1; break; } 

                Console.WriteLine("Ingresar el saldo: ");
                linea = Console.ReadLine();
                saldo = int.Parse(linea);
                if (saldo > 0)
                {
                    saldosAcredores = saldosAcredores + saldo;
                    estado_Cuenta = "Es Acreedor   ";

                }
                else
                    if (saldo < 0)
                    {
                        estado_Cuenta = "Es Deudor  ";
                    }
                    else
                    {
                        estado_Cuenta = "Es Nulo   ";
                    }
                
                mensaje_total += ("Numero de cuenta:" + numeroCuenta + " saldo:$" + saldo + " Estado de la cuenta:" + estado_Cuenta);






            } while (corte != 1);
            Console.WriteLine(mensaje_total);
            Console.WriteLine("El total de los Saldos de los Acredores es " + saldosAcredores);




            Console.ReadKey();
        }
    }
}
