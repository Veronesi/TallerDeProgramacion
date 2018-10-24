using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double radioCirculo;
            Double areaCirculo;
            Double perimetroCirculo;
            System.Console.Write("Ingrese el radio del circulo: ");
            radioCirculo = Convert.ToInt32(System.Console.ReadLine());
            // Calculamos el area (PI * radio^2 )
            areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
            // Calculamos el perimetro (2 * PI * radio)
            perimetroCirculo = 2 * Math.PI * radioCirculo;
            System.Console.Write("Area : "+ areaCirculo + "\nPerimetro: "+ perimetroCirculo);
            System.Console.ReadKey();
        }
    }
}
