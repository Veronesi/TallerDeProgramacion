using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciamos el resultado del factorial en 1.
            Int64 factorial = 1;
            int numero;
            System.Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(System.Console.ReadLine());
            // Ejecutamos la productoria
            for (int i = numero; i >= 1; i--)
                factorial *= i;
            System.Console.Write("Factorial de "+ numero +" es " + factorial);
            System.Console.ReadKey();
        }
    }
}
