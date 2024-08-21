using System;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita el nombre del usuario
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Saluda al usuario
            Console.WriteLine("Hola, " + nombre + "! Bienvenido.");


        }
    }
}
