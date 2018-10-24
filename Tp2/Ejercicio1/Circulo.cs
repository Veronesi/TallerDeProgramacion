using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Circulo
    {
        private Punto iCentro;
        private double iRadio;
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }
        public Circulo(double pX, double pY, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX,pY);
        }
        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }
        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }
        public Double Area()
        {
            return Math.PI * Math.Pow(this.iRadio,2); 
        }
        public Double Perimetro()
        {
            return 2 * Math.PI * this.iRadio;
        }
    }
}
