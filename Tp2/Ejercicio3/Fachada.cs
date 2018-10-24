using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Fachada
    {
        Juego iJuego;
        public Fachada()
        {
            this.iJuego = new Juego();
        }
        public void NuevaPartida(int pMaximoFallos, String pNombreJugador)
        {
            this.iJuego.NuevaPartida(pMaximoFallos, pNombreJugador);
        }

        public String PartidaActualNombreJugador()
        {
            return this.iJuego.Partida.NombreJugador;
        }

        public int PartidaActualIntentosDisponibles()
        {
            return this.iJuego.Partida.Intentos;
        }

        public String PartidaActualLetrasUsadas()
        {
            return this.iJuego.Partida.LetrasUsadas;
        }

        public string PartidaActualPalabraFormada()
        {
            return this.iJuego.Partida.Palabra;
        }

        public bool PartidaEnJuego()
        {
            return this.iJuego.Partida.EstadoPartida;
        }

        public void IngresarLetra(string pLetra)
        {
            this.iJuego.IngresarLetra(pLetra);
        }

        public bool PartidaGanada()
        {
            return this.iJuego.EstadoUltimaPartida();
        }

        public String PartidaActualPalabraAdivinar()
        {
            return this.iJuego.Partida.PalabraOriginal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Devuelve el tiempo que le tomo terminar la partida</returns>
        public String PartidaActualTiempo()
        {
            TimeSpan tiempo = this.iJuego.Partida.FechaFin - this.iJuego.Partida.FechaInicio;
            return tiempo.ToString();
        }

        /// <summary>
        /// Crea un arreglo de las mejores partidas jugadas.
        /// </summary>
        /// <returns>arreglo con el nombre del jugador y su tiempo</returns>
        public String[,] PartidasAntiguas()
        {
            // Nos fijamos si se jugo al menos una partida.
            if (this.iJuego.CantidadPartidas > 0)
            {
                String[,] listadoPartidas = new String[this.iJuego.CantidadPartidas, 2];
                for (int i = 0; i < this.iJuego.CantidadPartidas; i++)
                {
                    listadoPartidas[i, 0] = this.iJuego.PartidasAntiguas[i].NombreJugador;
                    TimeSpan tiempo = this.iJuego.PartidasAntiguas[i].FechaFin - this.iJuego.PartidasAntiguas[i].FechaInicio;
                    listadoPartidas[i, 1] = tiempo.ToString();
                }
                // Ordenamos las partidas.
                if (this.iJuego.CantidadPartidas > 1)
                {
                    for (int i = 0; i < this.iJuego.CantidadPartidas; i++)
                    {
                        for (int j = 0; j < this.iJuego.CantidadPartidas - 1; j++)
                        {
                            if (Convert.ToDateTime(listadoPartidas[j, 1]) > Convert.ToDateTime(listadoPartidas[j + 1, 1]))
                            {
                                String[,] aux = new String[1, 2];
                                aux[0, 0] = listadoPartidas[j, 0];
                                aux[0, 1] = listadoPartidas[j, 1];

                                listadoPartidas[j, 0] = listadoPartidas[j + 1, 0];
                                listadoPartidas[j, 1] = listadoPartidas[j + 1, 1];

                                listadoPartidas[j + 1, 0] = aux[0, 0];
                                listadoPartidas[j + 1, 1] = aux[0, 1];
                            }
                        }
                    }
                }
                // Dejamos solo los primeros CantidadRanking. (Ver atributos de la clase Juego)
                if(this.iJuego.CantidadPartidas > this.iJuego.CantidadRanking)
                {
                    String[,] listadoPartidasAcotada = new String[this.iJuego.CantidadRanking, 2];
                    for (int i = 0; i < this.iJuego.CantidadRanking; i++)
                    {
                        listadoPartidasAcotada[i, 0] = listadoPartidas[i, 0];
                        listadoPartidasAcotada[i, 1] = listadoPartidas[i, 1];
                    }
                    return listadoPartidasAcotada;
                }
                return listadoPartidas;
            }
            String[,] listaVacia = new String[1, 2];
            listaVacia[0, 0] = " ";
            listaVacia[0, 1] = " ";
            return listaVacia;
        }
    }
}
