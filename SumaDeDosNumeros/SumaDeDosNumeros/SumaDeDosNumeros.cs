using System;

namespace SumaEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita el primer número al usuario
            Console.Write("Ingrese el primer número entero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            // Solicita el segundo número al usuario
            Console.Write("Ingrese el segundo número entero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // Calcula la suma de los dos números
            int suma = numero1 + numero2;

            // Muestra el resultado de la suma
            Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, suma);

            // Pausa la consola para que el usuario pueda ver el mensaje antes de que la aplicación se cierre
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
