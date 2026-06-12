using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Retos
{
    internal class RetoCalculadora
    {
        public static void Ejecutar() 
        {
            Console.WriteLine("Hola, bienvenido a Operaciones aritmeticas");
            
            Console.WriteLine("Ingresa tu primer número entero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu segundo numero entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El resultado de la suma es: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"El resultado de la resta es: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"El resultado de la multiplicación es: {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"El resultado de la divión es: {num1} / {num2} = {num1 / num2}");
        }
    }
}
