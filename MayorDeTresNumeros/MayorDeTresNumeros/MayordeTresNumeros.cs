using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeTresNumeros
{
    internal class MayordeTresNumeros
    {
        static void Main(string[] args)
        {
            // Solicita los tres números al usuario
            Console.Write("Ingrese el primer número entero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número entero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número entero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            // Determina cuál es el mayor de los tres números
            int mayor;

            if (numero1 > numero2 && numero1 > numero3)
            {
                mayor = numero1;
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }

            // Imprime el número mayor
            Console.WriteLine("El número mayor es: " + mayor);

            // Pausa la consola para que el usuario pueda ver el mensaje antes de que la aplicación se cierre
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
