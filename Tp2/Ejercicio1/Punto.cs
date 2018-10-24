using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Punto
    {
        private double iX;
        private double iY;
        public Punto(double pX,double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        public double X
        {
            get { return this.iX; }
            set { this.iX = value; }
        }
        public double Y
        {
            get { return this.iY; }
            set { this.iY = value; }
        }
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double distanciaX = this.iX - pPunto.iX;
            double distanciaY = this.iY - pPunto.iY;
            return Math.Sqrt(Math.Pow(distanciaX, 2) + Math.Pow(distanciaX, 2));
        }

    }
}
