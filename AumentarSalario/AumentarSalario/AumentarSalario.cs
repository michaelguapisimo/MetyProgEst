using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentarSalario
{
    internal class AumentarSalario
    {
        static void Main(string[] args)
        {
            // Solicita el nombre del trabajador
            Console.Write("Ingrese el nombre del trabajador: ");
            string nombre = Console.ReadLine();

            // Solicita el cargo del trabajador
            Console.Write("Ingrese el cargo del trabajador: ");
            string cargo = Console.ReadLine();

            // Solicita el salario del trabajador
            Console.Write("Ingrese el salario del trabajador: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            // Calcula el aumento del 10%
            double aumento = salario * 0.10;

            // Calcula el nuevo salario con el aumento
            double nuevoSalario = salario + aumento;

            // Imprime los datos del trabajador y los resultados
            Console.WriteLine("\nDatos del trabajador:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salario actual: " + salario);
            Console.WriteLine("Aumento del 10%: " + aumento);
            Console.WriteLine("Nuevo salario: " + nuevoSalario);

            // Pausa la consola para que el usuario pueda ver el mensaje antes de que la aplicación se cierre
            Console.WriteLine("\nPresiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
