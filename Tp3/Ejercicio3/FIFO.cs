using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Algoritmo de Prioridades en la cual el primero en entrar es el primero en ser atendido.
    /// </summary>
    class FIFO : Estrategia
    {
        public FIFO() { }
        public override List<Paciente> Push(List<Paciente> pLista, Paciente pPaciente)
        {
            pLista.Add(pPaciente);
            return pLista;
        }
        public override List<Paciente> Pop(List<Paciente> pLista, ref Paciente pPaciente)
        {
            /* Si hay al menos un Paciente en la Lista */
            if(pLista.Count > 0)
                pPaciente = pLista.First();
            else
                /* Inicialiamos con un paciente "vacio" */
                pPaciente = new Paciente(0, NivelUrgencia.Blanco);
            pLista.Remove(pPaciente);
            return pLista;
        }
    }
}
