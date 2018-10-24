using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Fachada
    {
        private FabricaEncriptadores iFabrica;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Fachada()
        {
            this.iFabrica = FabricaEncriptadores.Instancia;
        }
        /// <summary>
        /// Encripta una cadena
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <param name="pEncriptador">Nombre del encriptador que se desea utilizar</param>
        /// <returns></returns>
        public String Encriptar(String pCadena, String pEncriptador)
        {
            IEncriptador encriptador = this.iFabrica.GetEncriptador(pEncriptador);
            return encriptador.Encriptar(pCadena);
        }
        /// <summary>
        /// Desencripta una cadena
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <param name="pEncriptador">Nombre del encriptador que se desea utilizar</param>
        /// <returns></returns>
        public String Desencriptar(String pCadena, String pEncriptador)
        {
            IEncriptador encriptador = this.iFabrica.GetEncriptador(pEncriptador);
            return encriptador.Desencriptar(pCadena);
        }
    }
}
