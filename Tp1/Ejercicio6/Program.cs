using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio;
            int suma = 0;
            int cantidad = 0; 
            // aumentamos dos en dos para tomar solo los valores impartes.
            for (int i = 1; i< 100; i += 2)
            {
                suma += i;
                cantidad++;
            }
            promedio = suma / cantidad;
            System.Console.WriteLine("La suma de los numeros impoartes es: " + suma);
            System.Console.WriteLine("El promedio es: " + promedio);
            System.Console.ReadKey();
        }
    }
}
