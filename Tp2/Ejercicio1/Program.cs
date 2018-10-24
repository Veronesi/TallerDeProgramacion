using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada ifachada = new Fachada();
            System.Console.Write("1)Circulo\n2)Triangulo\n\nOpcion [1/2]: ");
            char opcionFigura = Convert.ToChar(System.Console.ReadLine());
            switch (opcionFigura)
            {
                // Circulo
                case '1':
                    // Datos del Centro.
                    System.Console.Write("Coordenada X del centro: ");
                    int puntoCentroX = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Write("Coordenada Y del dentro: ");
                    int puntoCentroY = Convert.ToInt32(System.Console.ReadLine());

                    // Datos del Radio.
                    System.Console.Write("Radio: ");
                    double radio = Convert.ToInt32(System.Console.ReadLine());
                
                    System.Console.Write("1)Perimetro\n2)Area\n\nOpcion [1/2]: ");
                    char opcionCalculoCirculo = Convert.ToChar(System.Console.ReadLine());
                    switch (opcionCalculoCirculo)
                    {
                        // Perimetro del Ciruclo.
                        case '1':
                            double perimetroCirculo = ifachada.GetPerimetroCirculo(puntoCentroX, puntoCentroY, radio);
                            System.Console.Write("El perimetro del Ciruclo es : "+ perimetroCirculo);
                            break;
                        // Area del Ciruclo.
                        case '2':
                            double areaCirculo = ifachada.GetAreaCirculo(puntoCentroX, puntoCentroY, radio);
                            System.Console.Write("El perimetro del Ciruclo es : " + areaCirculo);
                            break;
                    }
                    break;
                case '2':
                    // Datos del Punto 1.
                    System.Console.Write("Coordenada X del 1er punto: ");
                    int punto1X = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Write("Coordenada Y del 1er punto: ");
                    int punto1Y = Convert.ToInt32(System.Console.ReadLine());

                    // Datos del Punto 2.
                    System.Console.Write("Coordenada X del 2er punto: ");
                    int punto2X = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Write("Coordenada Y del 2er punto: ");
                    int punto2Y = Convert.ToInt32(System.Console.ReadLine());

                    // Datos del Punto 3.
                    System.Console.Write("Coordenada X del 3er punto: ");
                    int punto3X = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Write("Coordenada Y del 3er punto: ");
                    int punto3Y = Convert.ToInt32(System.Console.ReadLine());

                    System.Console.Write("1)Perimetro\n2)Area\n\nOpcion [1/2]: ");
                    char opcionCalculoTriangulo = Convert.ToChar(System.Console.ReadLine());
                    switch (opcionCalculoTriangulo)
                    {
                        // Perimetro del Triangulo.
                        case '1':
                            double GetPerimetroTriangulo = ifachada.GetPerimetroTriangulo(punto1X, punto1Y, punto2X, punto2Y, punto3X, punto3Y);
                            System.Console.Write("El perimetro del Triangulo es : " + GetPerimetroTriangulo);
                            break;
                        // Area del Triangulo.
                        case '2':
                            double GetAreaTriangulo = ifachada.GetAreaTriangulo(punto1X, punto1Y, punto2X, punto2Y, punto3X, punto3Y);
                            System.Console.Write("El perimetro del Triangulo es : " + GetAreaTriangulo);
                            break;
                    }
                    break;
            }
            System.Console.ReadKey();
        }
    }
}
