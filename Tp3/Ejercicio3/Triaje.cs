using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Algoritmo de prioridades en el cual es atendido el que posea mayor nivel de urgencia.
    /// </summary>
    class Triaje : Estrategia
    {
        public Triaje() { }
        public override List<Paciente> Push(List<Paciente> pLista, Paciente pPaciente)
        {
            pLista.Add(pPaciente);
            return pLista;
        }
        public override List<Paciente> Pop(List<Paciente> pLista, ref Paciente pPaciente)
        {
            /* Inicialiamos con un paciente "vacio" */
            pPaciente = new Paciente(0, NivelUrgencia.Blanco);
            /* Recorremos la Lista para ver quien es el que posee mayor prioridad */
            foreach (Paciente paciente in pLista)
            {
                /* Si es Rojo no es necesario seguir buscando */
                if (paciente.GetNivelUrgencia == NivelUrgencia.Rojo)
                {
                    pPaciente = paciente;
                    pLista.Remove(paciente);
                    return pLista;
                }
                /* Guardamos el Paciente con mayor urgencia hasta el momento */
                if (paciente.GetNivelUrgencia < pPaciente.GetNivelUrgencia)
                    pPaciente = paciente;
            }
            pLista.Remove(pPaciente);
            return pLista;
        }
    }
}
