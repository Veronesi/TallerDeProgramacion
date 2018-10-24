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
            switch (numero)
            {
                case 1:
                    System.Console.Write("UNO");
                    break;
                case 2:
                    System.Console.Write("DOS");
                    break;
                case 3:
                    System.Console.Write("TRES");
                    break;
                case 4:
                    System.Console.Write("CUATRO");
                    break;
                case 5:
                    System.Console.Write("CINCO");
                    break;
                case 6:
                    System.Console.Write("SEIS");
                    break;
                case 7:
                    System.Console.Write("SIETE");
                    break;
                case 8:
                    System.Console.Write("OCHO");
                    break;
                case 9:
                    System.Console.Write("NUEVE");
                    break;
                default:
                    System.Console.Write("OTROS");
                    break;
            }
            System.Console.ReadKey();
        }
    }
}
