using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Variable para almacenar los elementos i-esimo y j-esimo de la serie de Fibonacci
            Iniciamos los dos primeros valores de la serie.
            */        
            int i = 0;
            int j = 1;
            // calculamos los 58 restantes (ya que tenemos los dos primeros elementos calcualdos)
            int cantidad = 58;
            // Sumamos los 2 primeros elementos.
            Int64 suma = i+j;
            // Calculamos los 58 elementos restantes de la serie.
            while (cantidad != 0)
            {
                cantidad--;
                int sumaParcial = i + j;
                suma += sumaParcial; 
                i = j;
                j = sumaParcial;
            }
            System.Console.WriteLine(suma);
            System.Console.ReadKey();
        }
    }
}