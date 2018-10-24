using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// clase base para los diferentes encriptadores que se deseen implementar
    /// </summary>
    abstract class Encriptador : IEncriptador
    {
        /// <summary>
        /// Nombre del Encriptador
        /// </summary>
        private String iNombre;
        public Encriptador(String pNobre)
        {
            this.iNombre = pNobre;
        }
        String Nombre
        {
            get {return this.iNombre; }
            set {this.iNombre = value; }
        }
        public abstract String Encriptar(String pCadena);
        public abstract String Desencriptar(String pCadena);
    }
}
