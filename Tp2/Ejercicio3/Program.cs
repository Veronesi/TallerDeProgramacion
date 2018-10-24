using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            void MenuPrinciapal()
            {
                Console.Clear();
                Console.WriteLine("\n\n   1 - Nueva Partida");
                Console.WriteLine("   2 - Ranking Partidas \n\n");
                Console.Write("   Opcion [1/2] : ");
                switch (System.Convert.ToInt16(System.Console.ReadLine()))
                {
                    case 1:
                        MenuJuego();
                        break;
                    case 2:
                        MenuRanking();
                        break;
                    default:
                        MenuPrinciapal();
                        break;
                }
            }
            void MenuJuego()
            {
                int maximoFallos = -1;
                Console.Clear();
                Console.Write("\n\n   Nombre del jugador: ");
                String nombreJugador = Console.ReadLine();
                Console.Write("   Desea cambiar la cantidad de fallos? [s/N]: ");
                if (Console.ReadLine() == "s")
                {
                    Console.Clear();
                    Console.Write("\n\n   Cantidad de fallos: ");
                    maximoFallos = Convert.ToInt16(Console.ReadLine());
                }
                fachada.NuevaPartida(maximoFallos, nombreJugador);
                while (fachada.PartidaEnJuego())
                {
                    Console.Clear();
                    Console.Write("\n\n   Jugador: " + fachada.PartidaActualNombreJugador());
                    Console.Write("\n\n   Cantidad de intentos disponibles: "+fachada.PartidaActualIntentosDisponibles());
                    Console.Write("\n\n   Letras usadas: " + fachada.PartidaActualLetrasUsadas());
                    Console.Write("\n\n   Palabra Formada: " + fachada.PartidaActualPalabraFormada());
                /*  Console.Write("\n\n   Palabra Formada: " + fachada.PartidaActualPalabraAdivinar()); */
                    Console.Write("\n\n   Letra: ");
                    fachada.IngresarLetra(Console.ReadLine());
                }
                Console.Clear();
                if (fachada.PartidaGanada())
                {
                    Console.Write("\n\n   Ganaste la partida!! Felicidades");
                }
                else
                {
                    Console.Write("\n\n   Upps has perdido la partida...");
                    Console.Write("\n   La palabra era: "+fachada.PartidaActualPalabraAdivinar());
                }
                Console.Write("\n   "+ fachada.PartidaActualNombreJugador() + "  tu tiempo fue: "+fachada.PartidaActualTiempo());
                Console.ReadKey();
                MenuPrinciapal();
            }
            void MenuRanking()
            {
                Console.Clear();
                Console.WriteLine("\n\n   Ranking");
                String[,] listaRanking;
                listaRanking = fachada.PartidasAntiguas();
                for(int i = 0; i < listaRanking.GetLength(0); i++)
                {
                    Console.WriteLine("\n\n   "+(i+1)+" - "+ listaRanking[i,1]+"  "+ listaRanking[i, 0]);
                }
                Console.ReadKey();
                MenuPrinciapal();
            }
            MenuPrinciapal();
            Console.ReadKey();
        }
    }
}