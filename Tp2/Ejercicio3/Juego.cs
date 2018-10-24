using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Juego
    {
        private int iCantidadPartidas = 0;
        private String[] iPalabras = { "endulzar", "oro", "condecoracion", "desertar", "callejon", "elegido", "teatro", "sensible", "bomberos", "hierva", "tapiz", "infeccion", "capullo", "huella", "huerto", "bienestar", "facturas", "dama", "escalera", "tenor", "interceptar", "guardaespaldas", "abordaje", "Escenografia", "bombo", "alemania", "vicio", "eructo", "carpa", "parche" };
        private int iMaximoFallos = 10;
        private Partida iPartida;               /* Partida en curso */
        private Partida[] iPartidasAntiguas;    /* Lista de partidas terminadas */
        private int iCantidadRanking = 5;       /* Cantidad de partidas mostradas en el ranking */ 

        public Juego()
        {
            this.iPartidasAntiguas = new Partida[50];
        }
        public int CantidadRanking
        {
            get { return this.iCantidadRanking; }
        }
        public void NuevaPartida(int pMaximoFallos, String pNombreJugador)
        {
            /* -1: Valor para inicializar iMaximoFallos con valor por defecto. */
            if (pMaximoFallos == -1)
                pMaximoFallos = this.iMaximoFallos;
            Random rnd = new Random();
            this.iPartida = new Partida(pMaximoFallos, iPalabras[rnd.Next(0, this.iPalabras.Length)], pNombreJugador);
        }
        public Partida[] PartidasAntiguas
        {
            get { return this.iPartidasAntiguas; }
        }
        public int CantidadPartidas
        {
            get { return this.iCantidadPartidas; }
        }









        public void IngresarLetra(string pLetra)
        {
            this.iPartida.AdivinarPalabra(Convert.ToChar(pLetra));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool EstadoUltimaPartida()
        {
            this.iPartidasAntiguas[this.iCantidadPartidas] = this.iPartida;
            this.iCantidadPartidas++;
            if (!this.iPartida.PartidaGanada)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public Partida Partida
        {
            get { return this.iPartida; }
        }
    }
}
