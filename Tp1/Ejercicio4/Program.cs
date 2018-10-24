using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteInferior;
            int limiteSuperior;
            int suma = 0;
            System.Console.Write("Limite inferior: ");
            limiteInferior = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Limite Superior: ");
            limiteSuperior = Convert.ToInt32(System.Console.ReadLine());
            // Sumamos todos los enteros desde limiteInferior hasta limiteSuperior.
            while (limiteInferior <= limiteSuperior)
            {
                suma += limiteInferior;
                limiteInferior++;
            }
            System.Console.Write("La suma desde es :" + suma);
            System.Console.ReadKey();
        }
    }
}