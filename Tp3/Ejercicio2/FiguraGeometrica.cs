using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /// <summary>
    /// Clase abstacta para las distintas figuras geometricas
    /// </summary>
    abstract class FiguraGeometrica
    {
        /// <summary>
        /// Calcula el area de una figura geometrica.
        /// </summary>
        /// <returns>Devuelve el area de la figura</returns>
        public abstract Double CalcularArea();
        /// <summary>
        /// Calcula el perimetro de una figura geometrica.
        /// </summary>
        /// <returns>Devuelve el perimetro de la figura</returns>
        public abstract Double CalcularPerimetro();
    }
}
