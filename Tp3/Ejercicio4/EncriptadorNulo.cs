using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Encriptador "Nulo" Devuelve siempre la misma cadena, tanto cuando se desea encriptar o desencriptar
    /// </summary>
    class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo() : base("Null") { }
        public override String Encriptar(String pCadena)
        {
            return pCadena;
        }
        public override String Desencriptar(String pCadena)
        {
            return pCadena;
        }
    }
}
