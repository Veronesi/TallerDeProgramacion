using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Interfaz que establece el contrato mínimo que deben cumplir todos los algoritmos de encriptación.
    /// </summary>
    interface IEncriptador
    {
        /// <summary>
        /// Encripta una Cadena utilizando un metodo de encriptación.
        /// </summary>
        /// <param name="pCadena">Cadena a Encriptar</param>
        /// <returns>Devuelve la cadena Encriptada</returns>
        String Encriptar(String pCadena);
        /// <summary>
        /// Desencripta una Cadena utilizando un metodo de desencriptación.
        /// </summary>
        /// <param name="pCadena">Cadena a Desencriptar</param>
        /// <returns>Devuelve la cadena Desencriptada</returns>
        String Desencriptar(String pCadena);
    }
}
