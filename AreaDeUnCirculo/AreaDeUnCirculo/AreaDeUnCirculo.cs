using System;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita el radio del círculo al usuario
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Calcula el área del círculo utilizando la fórmula: Área = π * radio^2
            double area = Math.PI * Math.Pow(radio, 2);

            // Muestra el resultado
            Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);

            // Pausa la consola para que el usuario pueda ver el mensaje antes de que la aplicación se cierre
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
