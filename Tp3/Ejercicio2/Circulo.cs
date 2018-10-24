using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Clase Circulo
    /// </summary>
    class Circulo : FiguraGeometrica
    {
        private Punto iCentro;
        private Double iRadio;
        /// <summary>
        /// Constructor de la clase sabiendo el centro y el radio
        /// </summary>
        /// <param name="pCentro">Punto del centro</param>
        /// <param name="pRadio">Radio del circulo</param>
        public Circulo(Punto pCentro, Double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }
        /// <summary>
        /// Contructor de la clase sabiendo las coordenadas del centro y el radio
        /// </summary>
        /// <param name="pX">Coordenada en X del centro</param>
        /// <param name="pY">Coordenada en Y del centro</param>
        /// <param name="pRadio">Radio del circulo</param>
        public Circulo(Double pX, Double pY, Double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX, pY);
        }
        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }
        public Double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }
        public override Double CalcularArea()
        {
            return Math.PI * Math.Pow(this.iRadio, 2);
        }
        public override Double CalcularPerimetro()
        {
            return 2 * Math.PI * this.iRadio;
        }
    }
}
