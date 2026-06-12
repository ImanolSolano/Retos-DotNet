using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Retos
{
    internal class TablasDeMultiplicar
    {
        public static void Ejecutar() 
        {
            Console.WriteLine("Tablas de multiplicar del 1 al 10");
            Console.Write("Ingresa el número entero a multiplicar: ");

            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
