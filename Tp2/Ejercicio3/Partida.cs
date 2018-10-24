using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Partida
    {
        private string iNombreJugador;
        private bool iEstadoPartida = true; /* True si la partida aun no termino. */
        private bool iPartidaGanada;        /* True: Partida ganada; False: Partida perdida. */
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private int iIntentos;              /* Intentos que le quedan al jugador antes de perder. */
        private char[] iPalabra;            /* Palabra que va formando el jugador a medida que va ingresando letras. */
        private char[] iPalabraOriginal;    /* Palabra a adivinar. */
        private char[] iLetrasUsadas;       
        private int iLetrasIngresadas;      /* Cantidad de letras ingresadas (pertenezcan o no a la palabra a adivinar). 
                                               Se utiliza esta variable para saber en que posicion del Array de iLetrasUsadas 
                                               debemos pushear la proxima letra que ingresa el usuario. 
                                            */
        public Partida(int pIntentos, String pPalabra, String pNombreJugador)
        {
            this.iNombreJugador = pNombreJugador;
            this.iLetrasIngresadas = 0;
            this.iFechaInicio = DateTime.Now;
            this.iIntentos = pIntentos;
            this.iPalabraOriginal = pPalabra.ToCharArray();
            this.iPalabra = this.GenerarPalabra(pPalabra.Length); /* Inicilizamos el String que va generando el usuario : "______" */
            this.iLetrasUsadas = new char[27];
        }

        public void AdivinarPalabra(char pLetra)
        {
            // Verificamos si ya perdio.
            if (this.iEstadoPartida)
            {
                // Verificamos si ya se uso esta letra anteriormente.
                if (!this.iLetrasUsadas.Contains(pLetra))
                {
                    // Verificamos si esta en la palabra a adivinar.
                    if (this.iPalabraOriginal.Contains(pLetra))
                    {
                        for (int i = 0; i < this.iPalabraOriginal.Length; i++)
                        {
                            // Escribimos la letra usada en todas las ocurrencias en iPalabra.
                            if (pLetra == this.iPalabraOriginal[i])
                                this.iPalabra[i] = pLetra;
                        }
                    }
                    else
                    {
                        this.iIntentos--;
                    }
                    this.iLetrasIngresadas++;
                    this.iLetrasUsadas.SetValue(pLetra, this.iLetrasIngresadas);
                    this.VerificarEstadoPartida();
                }
            }
        }

        public void VerificarEstadoPartida()
        {
            // Si el jugador adivino la palabra por completo.
            if (this.Palabra == this.PalabraOriginal)
            {
                this.iEstadoPartida = false;
                this.iPartidaGanada = true;
                this.iFechaFin = DateTime.Now;
            }
            // Si el jugador perdio.
            else if (this.iIntentos == 0)
            {
                this.iEstadoPartida = false;
                this.iPartidaGanada = false;
                this.iFechaFin = DateTime.Now;
            }
        }
        /**
         * @param iTamanio: longitud de la palabra a adivinar.
         * @return Devuelve una cadena rellena del simbolo "_".
         */
        public char[] GenerarPalabra(int iTamanio)
        {
            char[] palabra = new char[iTamanio];
            for (int i = 0; i < iTamanio; i++)
            {
                palabra[i] = '_';
            }
            return palabra;
        }
        public String NombreJugador
        {
            get { return this.iNombreJugador; }
            set { this.iNombreJugador = value; }
        }
        public bool EstadoPartida
        {
            get { return this.iEstadoPartida; }
            set { this.iEstadoPartida = value; }
        }
        public bool PartidaGanada
        {
            get { return this.iPartidaGanada; }
            set { this.iPartidaGanada = value; }
        }
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }
        public int Intentos
        {
            get { return this.iIntentos; }
            set { this.iIntentos = value; }
        }
        public string Palabra
        {
            get { return new String(this.iPalabra); }
            set { this.iPalabra = value.ToCharArray(); }
        }
        public string PalabraOriginal
        {
            get { return new String(this.iPalabraOriginal); }
            set { this.iPalabraOriginal = value.ToCharArray(); }
        }
        public string LetrasUsadas
        {
            get { return new string(this.iLetrasUsadas); }
            set { this.iLetrasUsadas = value.ToCharArray(); }
        }
        public string LetrasIngresadas
        {
            get { return new string(this.iLetrasUsadas); }
            set { this.iLetrasUsadas = value.ToCharArray(); }
        }
    }
}
