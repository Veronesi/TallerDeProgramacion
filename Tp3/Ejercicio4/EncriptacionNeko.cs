using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class EncriptacionNeko : Encriptador
    {
        public EncriptacionNeko() : base("Neko") { }
        public override string Encriptar(string pCadena)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pCadena);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public override string Desencriptar(string pCadena)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(pCadena);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
