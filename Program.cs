using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_basica_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aquí se declaran las variables.

            int Num1; int Num2;
            int Suma; int Resta;
            int Multiplicación; double División;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Calculadora básica");

            //Aquí se le solicitan los datos al usuario.
            Console.WriteLine("Por favor ingrese su primer número");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese su segundo número");
            Num2 = Convert.ToInt32(Console.ReadLine());
            
            // Aquí se hacen las operaciones.

            Suma = Num1 + Num2;
            Resta = Num1 - Num2;
            Multiplicación = Num1 * Num2;
            División = Num1 / Num2;

            // Aquí se ven los resultados de las operaciones.
            Console.WriteLine("Resultados de la suma: " + Suma);
            Console.WriteLine("Resultados de la resta: " + Resta);
            Console.WriteLine("Resultados de la Multiplicación: " + Multiplicación);
            Console.WriteLine("Resultados de la División: " + División);
            Console.ReadLine();
        }
    }
}
