using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Retos
{
    internal class Reto01MayorDeEdad
    {
        public static void Ejecutar() 
        {
            Console.Write("¿Cómo te llamas? "); 
            string nombre = Console.ReadLine(); 
            
            Console.Write("¿Cuál es tu edad? "); 
            int edad = Convert.ToInt32(Console.ReadLine()); 
            
            Console.WriteLine($"Hola, {nombre}"); 
            
            if (edad >= 18)
            
            { 
                Console.WriteLine("Eres mayor de edad");
            } 
            
            else
            { 
                Console.WriteLine("Eres menor de edad"); 
            }
        }
    }
}
