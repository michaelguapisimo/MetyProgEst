using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParoImpar
{
    internal class NumeroParOImpar
    {
        static void Main(string[] args)
        {
            // Solicita un número al usuario
            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Determina si el número es par o impar
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número {0} es par.", numero);
            }
            else
            {
                Console.WriteLine("El número {0} es impar.", numero);
            }

            // Pausa la consola para que el usuario pueda ver el mensaje antes de que la aplicación se cierre
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
