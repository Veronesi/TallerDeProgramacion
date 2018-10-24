using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            void Menu()
            {
                Fachada fachada = new Fachada();
                Console.Clear();
                Console.Write("\n\n   Numerador:");
                int dividendo = Convert.ToInt16(Console.ReadLine());
                Console.Write("   Denominador:");
                int divisor = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                try
                {
                    Double resultado = fachada.Dividir(dividendo, divisor);
                    Console.Write("\n\n   Resultado de la division: "+resultado);
                }
                catch (DivisionPorCeroException ex)
                {
                    Console.Write("\n\n   Error al intentar dividir por cero");
                    Console.WriteLine("\n\n"+ex);
                }
                Console.ReadKey();
                Menu();
            }
            Menu();
            Console.ReadKey();
        }
    }
}
