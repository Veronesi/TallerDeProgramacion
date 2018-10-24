using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            // Ejercutamos la sumatoria (por la formula de Lebniz).
            for (int n = 0; n <= 1000; n++)
                suma += (Math.Pow(-1, n)) / (2 * n + 1);
            System.Console.WriteLine("Diferencia entre Pi y Lebniz: "+ (suma - Math.PI / 4));
            System.Console.ReadKey();
        }
    }
}
