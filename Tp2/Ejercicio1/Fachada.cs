using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Fachada
    {
        public Fachada() { }
        public double GetPerimetroCirculo(int pPuntoCentroX, int pPuntoCentroY, double pRadio)
        {
            Circulo circulo = new Circulo(pPuntoCentroX, pPuntoCentroY, pRadio);
            return circulo.Perimetro();
        }

        public double GetAreaCirculo(int pPuntoCentroX, int pPuntoCentroY, double pRadio)
        {
            Circulo circulo = new Circulo(pPuntoCentroX, pPuntoCentroY, pRadio);
            return circulo.Area();
        }

        public double GetPerimetroTriangulo(int pPunto1X, int pPunto1Y, int pPunto2X, int pPunto2Y, int pPunto3X, int pPunto3Y)
        {
            Punto punto1 = new Punto(pPunto1X, pPunto1Y);
            Punto punto2 = new Punto(pPunto2X, pPunto2Y);
            Punto punto3 = new Punto(pPunto3X, pPunto3Y);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto2);
            return triangulo.Perimetro();
        }

        public double GetAreaTriangulo(int pPunto1X, int pPunto1Y, int pPunto2X, int pPunto2Y, int pPunto3X, int pPunto3Y)
        {
            Punto punto1 = new Punto(pPunto1X, pPunto1Y);
            Punto punto2 = new Punto(pPunto2X, pPunto2Y);
            Punto punto3 = new Punto(pPunto3X, pPunto3Y);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto2);
            return triangulo.Area();
        }
    }
}
