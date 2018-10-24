using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Ejercicio4
{
    class EncriptadorSimetrico : Encriptador
    {
        string iClaveMaestra;
        public EncriptadorSimetrico(string pClavemaestra) : base("Simetrico")
        {
            this.iClaveMaestra = pClavemaestra;
        }
        public string ClaveMaestra
        {
            get { return this.iClaveMaestra; }
            set { this.iClaveMaestra = value; }
        }
        public override string Encriptar(string pCadena)
        {
            // Aqui va el codigo de la funcion encriptar   
            // Convierto la pCadena y la pClaveMaestra en arreglos de bytes   
            // para poder usarlas en las funciones de encriptacion   
            byte[] pCadenaBytes = Encoding.UTF8.GetBytes(pCadena);
            byte[] pClaveMaestraBytes = Encoding.UTF8.GetBytes(iClaveMaestra);
            // Creo un objeto de la clase Rijndael   
            RijndaelManaged rij = new RijndaelManaged();
            // Configuro para que utilice el modo ECB   
            rij.Mode = CipherMode.ECB;
            // Configuro para que use encriptacion de 256 bits.
            rij.BlockSize = 256;
            // Declaro que si necesitara mas bytes agregue ceros.   
            rij.Padding = PaddingMode.Zeros;
            // Declaro un encriptador que use mi pClaveMaestra secreta y un vector  
            // de inicializacion aleatorio   
            ICryptoTransform encriptador;
            encriptador = rij.CreateEncryptor(pClaveMaestraBytes, rij.IV);
            // Declaro un stream de memoria para que guarde los datos   
            // encriptados a medida que se van calculando   
            MemoryStream memStream = new MemoryStream();
            // Declaro un stream de cifrado para que pueda escribir aqui   
            // la pCadena a encriptar. Esta clase utiliza el encriptador   
            // y el stream de memoria para realizar la encriptacion   
            // y para almacenarla   
            CryptoStream cifradoStream;
            cifradoStream = new CryptoStream(memStream, encriptador, CryptoStreamMode.Write);
            // Escribo los bytes a encriptar. A medida que se va escribiendo  
            // se va encriptando la pCadena   
            cifradoStream.Write(pCadenaBytes, 0, pCadenaBytes.Length);
            // Aviso que la encriptación se terminó   
            cifradoStream.FlushFinalBlock();
            // Convert our encrypted data from a memory stream into a byte array.
            byte[] cipherTextBytes = memStream.ToArray();
            // Cierro los dos streams creados   
            memStream.Close();
            cifradoStream.Close();
            // Convierto el resultado en base 64 para que sea legible   
            // y devuelvo el resultado   
            return Convert.ToBase64String(cipherTextBytes);
        }
        public override string Desencriptar(string pCadena)
        {
            // Aqui va el codigo de la funcion desencriptar 
            // Convierto la pCadena y la pClaveMaestra en arreglos de bytes   
            // para poder usarlas en las funciones de encriptacion   
            // En este caso la pCadena la convierta usando base 64   
            // que es la codificacion usada en el metodo encriptar   
            byte[] pCadenaBytes = Convert.FromBase64String(pCadena);
            byte[] pClaveMaestraBytes = Encoding.UTF8.GetBytes(iClaveMaestra);
            // Creo un objeto de la clase Rijndael   
            RijndaelManaged rij = new RijndaelManaged();
            // Configuro para que utilice el modo ECB   
            rij.Mode = CipherMode.ECB;
            // Configuro para que use encriptacion de 256 bits.
            rij.BlockSize = 256;
            // Declaro que si necesitara mas bytes agregue ceros.   
            rij.Padding = PaddingMode.Zeros;
            // Declaro un desencriptador que use mi pClaveMaestra secreta y un vector   
            // de inicializacion aleatorio   
            ICryptoTransform desencriptador;
            desencriptador = rij.CreateDecryptor(pClaveMaestraBytes, rij.IV);
            // Declaro un stream de memoria para que guarde losdatos   
            // encriptados   
            MemoryStream memStream = new MemoryStream(pCadenaBytes);
            // Declaro un stream de cifrado para que pueda leer de aqui   
            // la pCadena a desencriptar. Esta clase utiliza el  desencriptador   
            // y el stream de memoria para realizar la desencriptacion   
            CryptoStream cifradoStream;
            cifradoStream = new CryptoStream(memStream, desencriptador, CryptoStreamMode.Read);
            // Declaro un lector para que lea desde el stream de cifrado.   
            // A medida que vaya leyendo se ira desencriptando.
            StreamReader lectorStream = new StreamReader(cifradoStream);
            // Leo todos los bytes y lo almaceno en una pCadena 
            string resultado = lectorStream.ReadToEnd();
            // Cierro los dos streams creados   
            memStream.Close();
            cifradoStream.Close();
            // Devuelvo la pCadena   
            return resultado;
        }
    }
}
