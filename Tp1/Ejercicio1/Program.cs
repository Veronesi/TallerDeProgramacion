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
            int numero;
            System.Console.Write("Escriba un numero:");
            numero = Convert.ToInt32(System.Console.ReadLine());
            // Mostramos una cadena de texto dependiendo el numero ingresado.
            if (numero == 1)
            {
                System.Console.Write("UNO");
            }
            else if (numero == 2)
            {
                System.Console.Write("DOS");
            }
            else if (numero == 3)
            {
                System.Console.Write("TRES");
            }
            else if (numero == 4)
            {
                System.Console.Write("CUATRO");
            }
            else if (numero == 5)
            {
                System.Console.Write("CINCO");
            }
            else if (numero == 6)
            {
                System.Console.Write("SEIS");
            }
            else if (numero == 7)
            {
                System.Console.Write("SIETE");
            }
            else if (numero == 8)
            {
                System.Console.Write("OCHO");
            }
            else if (numero == 9)
            {
                System.Console.Write("NUEVE");
            }
            else
            {
                System.Console.Write("OTROS");
            }
            System.Console.ReadKey();
        }
    }
}
