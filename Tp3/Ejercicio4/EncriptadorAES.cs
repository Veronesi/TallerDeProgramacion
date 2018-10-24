using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ejercicio4
{
    /// <summary>
    /// Encriptador utilizando AES
    /// </summary>
    class EncriptadorAES : Encriptador
    {
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public EncriptadorAES() : base("AES") { }
        public override String Encriptar(String pCadena)
        {
            byte[] Key = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1 };
            byte[] IV = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            byte[] cadenaEncriptada;
            /* Creamos el objeto AES */
            Aes AES = Aes.Create();
            AES.Key = Key;
            AES.IV = IV;
            /* Creamos un encriptador */
            ICryptoTransform encriptador = AES.CreateEncryptor(AES.Key, AES.IV);
            MemoryStream msEncriptador = new MemoryStream();
            CryptoStream csEncriptador = new CryptoStream(msEncriptador, encriptador, CryptoStreamMode.Write);
            StreamWriter swEncriptador = new StreamWriter(csEncriptador);
            swEncriptador.Write(pCadena);
            cadenaEncriptada = msEncriptador.ToArray();
            /* Devolvemos la cadena encriptada */
            return Encoding.Default.GetString(cadenaEncriptada);

        }
        public override string Desencriptar(string pCadena)
        {
            byte[] cadenaEncriptada = Encoding.ASCII.GetBytes(pCadena);
            byte[] Key = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1 };
            byte[] IV = { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            string cadenaOriginal = null;
            /* Creamos el objeto AES */
            Aes AES = Aes.Create();
            AES.Key = Key;
            AES.IV = IV;
            /* Creamos un desncriptador */
            ICryptoTransform desencriptador = AES.CreateDecryptor(AES.Key, AES.IV);
            MemoryStream msDesencriptador = new MemoryStream(cadenaEncriptada);
            CryptoStream csDesencriptador = new CryptoStream(msDesencriptador, desencriptador, CryptoStreamMode.Read);
            StreamReader srDesencriptador = new StreamReader(csDesencriptador);
            cadenaOriginal = srDesencriptador.ReadToEnd();
            /* Devolvemos la cadena desencriptada */
            return cadenaOriginal;
        }
    }
}
