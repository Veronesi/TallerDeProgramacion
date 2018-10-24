using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Guardia
    {
        /// <summary>
        /// Estrategia actual de la Guardia
        /// </summary>
        private Estrategia iTipoCola;
        /// <summary>
        /// Lista de los Pacientes de la Guardia
        /// </summary>
        private List<Paciente> iCola = new List<Paciente>();
        /// <summary>
        /// Constructor de la clase Guardia.
        /// </summary>
        /// <param name="pTipoCola"></param>
        public Guardia(Estrategia pTipoCola)
        {
            this.iTipoCola = pTipoCola;
        }
        public Estrategia TipoCola
        {
            get { return this.iTipoCola; }
            set { this.iTipoCola = value; }
        }
        public List<Paciente> Cola
        {
            get {return this.iCola ; }
            set {this.iCola = value; }
        }
        /// <summary>
        /// Agrega un Paciente al final de la lista de Pacientes.
        /// </summary>
        /// <param name="pPaciente">Paciente a agregar</param>
        public void PushPaciente(Paciente pPaciente)
        {
            this.Cola = this.TipoCola.Push(this.Cola, pPaciente);
        }
        /// <summary>
        /// Obtiene el proximo Paiente a ser atentido.
        /// </summary>
        /// <returns>Devuelve la lista de Pacientes sin este Paciente</returns>
        public Paciente PopPaciente()
        {
            /* Inicialiamos con un paciente "vacio" */
            Paciente paciente = new Paciente(0, NivelUrgencia.Blanco);
            /* Actualizamos la Lista y almacenamos en paciente el Paciente que sera atendido */
            this.Cola = this.TipoCola.Pop(this.Cola,ref paciente);
            return paciente;
        }
    }
}
