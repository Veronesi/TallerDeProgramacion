using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Fabrica de encriptadores
    /// </summary>
    class FabricaEncriptadores
    {
        private static FabricaEncriptadores cInstancia = null;
        /// <summary>
        /// Diccionario que contiene los distitnos tipos de Encriptadores.
        /// </summary>
        private Dictionary<String, IEncriptador> iEncriptadores;
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        private FabricaEncriptadores()
        {
            this.iEncriptadores = new Dictionary<string, IEncriptador>();
            this.iEncriptadores.Add("Null", new EncriptadorNulo());
            this.iEncriptadores.Add("AES", new EncriptadorAES());
            this.iEncriptadores.Add("Neko", new EncriptacionNeko());
            this.iEncriptadores.Add("Simetrico", new EncriptadorSimetrico("NONE"));
        }
        /// <summary>
        /// Metodo para obtener un encriptador en especifico.
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        /// <returns>Devuelve un encriptador en especifico</returns>
        public IEncriptador GetEncriptador(String pNombre)
        {
            /* Verificamos si existe ese encriptador */
            if (this.iEncriptadores.ContainsKey(pNombre))
                return this.iEncriptadores[pNombre];
            return this.iEncriptadores["Null"];
        }
        /// <summary>
        /// Instancia de la fabrica
        /// </summary>
        public static FabricaEncriptadores Instancia
        {
            get
            {
                if (cInstancia == null)
                    cInstancia = new FabricaEncriptadores();
                return cInstancia;
            }
            set
            {
                cInstancia = new FabricaEncriptadores();
            }
        }
    }
}
