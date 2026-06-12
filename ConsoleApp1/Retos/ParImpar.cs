using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Retos
{
    internal class ParImpar
    {
        public static void Ejecutar() 
        {
            Console.WriteLine("Hola, averiguemos si es par o impar");
            Console.Write("Ingresa el número entero a evaluar: ");
            int parImpar = Convert.ToInt32(Console.ReadLine());

            if (parImpar % 2 == 0)
            {
                Console.WriteLine("El numero ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar");
            }
        }
    }
}
