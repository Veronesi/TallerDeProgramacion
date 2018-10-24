using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Devuelve verdadero si el numero es primo.
             * @param int
             * @return bool
             */
            bool EsPrimo(int n)
            {
                for(int i = 2; i < n; i++)
                {
                    // Si el resto de la division es 0.
                    if(n%i == 0)
                        return true;
                }
                return false;
            }
            int suma = 0;
            // Recorremos todos los enteros entre 35 y 1977.
            for(int i = 35; i<= 1977; i++)
            {
                // Sumamos solo los primos.
                if (EsPrimo(i))
                    suma += i;
            }
            System.Console.WriteLine("La suma de los impares es :"+suma);
            System.Console.ReadKey();
        }
    }
}
