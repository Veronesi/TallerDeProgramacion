using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Clase abstracta para los algoritmos de prioriacion.
    /// </summary>
    abstract class Estrategia
    {
        public Estrategia() { }
        /// <summary>
        /// Agrega un Paciente al final de la lista de Pacientes.
        /// </summary>
        /// <param name="pLista">Lista de Pacientes</param>
        /// <param name="pPaciente">Paciente a agregar</param>
        /// <returns>Devuelve la lista de Pacientes con el nuevo Paciente agregado</returns>
        public abstract List<Paciente> Push(List<Paciente> pLista, Paciente pPaciente);
        /// <summary>
        /// Obtiene el proximo Paiente a ser atentido.
        /// </summary>
        /// <param name="pLista">Lista de Pacientes</param>
        /// <param name="pPaciente">Paciente que debera ser atentido</param>
        /// <returns>Devuelve la lista de Pacientes sin este Paciente</returns>
        public abstract List<Paciente> Pop(List<Paciente> pLista,ref Paciente pPaciente);
    }
}
