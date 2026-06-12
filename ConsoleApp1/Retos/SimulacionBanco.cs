using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Retos
{
    internal class SimulacionBanco
    {
        public static void Ejecutar() 
        {
            decimal saldo = 1000m;
            Console.WriteLine("Bienvenid@");
            Console.WriteLine("1. Consulta saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Retirar");
            Console.WriteLine("4. Salir");
            Console.Write("Digite el numero de la opción que desee realizar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion != 4)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("Consultando saldo...");
                    Console.WriteLine($"Su saldo al día de hoy es de; ${saldo}");
                    Console.Write("Digite el numero de la opción que desee realizar: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                else if (opcion == 2)
                {
                    Console.Write("Digite el monto a depositar: ");
                    decimal deposito = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Su saldo anterior era de: ${saldo}");
                    saldo += deposito;
                    Console.WriteLine($"Su nuevo saldo es de: ${saldo}");
                    Console.Write("Digite el numero de la opción que desee realizar: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                else if (opcion == 3)
                {
                    Console.WriteLine($"Su saldo actual es de: ${saldo}");
                    Console.Write("Digite el monto a retirar: ");
                    decimal retiro = Convert.ToDecimal(Console.ReadLine());
                    if (retiro > saldo)
                    {
                        Console.WriteLine("No tiene suficiente saldo para realizar esta operación");
                    }
                    else
                    {
                        saldo -= retiro;
                        Console.WriteLine($"Su nuevo saldo es de: ${saldo}");
                    }
                    Console.Write("Digite el numero de la opción que desee realizar: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Opción no válida, por favor intente nuevamente");
                    Console.Write("Digite el numero de la opción que desee realizar: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Gracias por usar nuestro servicio, vuelva pronto");
        }
    }
}
