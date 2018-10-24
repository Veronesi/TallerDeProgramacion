using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada iFachada = new Fachada();
            void MainMenu()
            {
                Console.Clear();
                Console.Write("\n\n\n    -César\n    -AES\n    -Clave Publica\n    -Simetrico\n    -Neko");
                Console.Write("\n    Que metodo de encripacion desea utilizar?: ");
                String encriptador = Console.ReadLine();
                Console.Clear();
                Console.Write("\n\n\n    1- Encriptar Cadena");
                Console.Write("\n    2- Desencriptar Cadena");
                Console.Write("\n\n    Opcion [1/2]: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.Write("\n\n\n    Palabra a Encriptar: ");
                        Console.Write("\n    Palabra Encriptada : "+iFachada.Encriptar(Console.ReadLine(), encriptador));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("\n\n\n    Palabra a Desencriptar: ");
                        Console.Write("\n    Palabra Desencriptada : " + iFachada.Desencriptar(Console.ReadLine(), encriptador));
                        Console.ReadKey();
                        break;
                    default:
                        MainMenu();
                        break;
                }
                MainMenu();
            }
            MainMenu();
            Console.ReadKey();
        }
    }
}
