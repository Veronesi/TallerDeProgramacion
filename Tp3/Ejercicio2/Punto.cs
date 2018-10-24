using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Clase punto
    /// </summary>
    class Punto
    {
        private Double iX;
        private Double iY;
        /// <summary>
        /// Constructor de la clase punto
        /// </summary>
        /// <param name="pX">Coordenada en X del punto</param>
        /// <param name="pY">Coordenada en Y del punto</param>
        public Punto(Double pX, Double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        public Double X
        {
            get { return this.iX; }
            set { this.iX = value; }
        }
        public Double Y
        {
            get { return this.iY; }
            set { this.iY = value; }
        }
        /// <summary>
        /// Calcula la distancia que existe entre este punto y otro
        /// </summary>
        /// <param name="pPunto">Punto a calcular su distancia</param>
        /// <returns>Devuelve la distancia que existe entre estos dos puntos</returns>
        public Double CalcularDistanciaDesde(Punto pPunto)
        {
            Double distanciaX = this.iX - pPunto.iX;
            Double distanciaY = this.iY - pPunto.iY;
            return Math.Sqrt(Math.Pow(distanciaX, 2) + Math.Pow(distanciaX, 2));
        }

    }
}
