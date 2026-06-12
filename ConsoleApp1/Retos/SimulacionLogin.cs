using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.Retos
{
    internal class SimulacionLogin
    {
        public static void Ejecutar() 
        {
            Console.WriteLine("Bienvenido");

            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == "admin" && contraseña == "1234")
            {
                Console.WriteLine("¡Acceso concedido!");
            }
            else
            {
                Console.WriteLine("¡Acceso denegado!");
                Console.WriteLine("Usuario o contraseña incorrecto");
            }
        }
    }
}
