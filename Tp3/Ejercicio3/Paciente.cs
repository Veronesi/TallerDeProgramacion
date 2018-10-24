using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Clase para representar un Paciente de la Guardia.
    /// </summary>
    class Paciente
    {
        private Int16 iNumeroPaciente;
        private NivelUrgencia iNivelUrgencia;
        /// <summary>
        /// Constructor de la clase Paciente
        /// </summary>
        /// <param name="pNumeroPaciente">Numero de identificacion del Paciente</param>
        /// <param name="pNivelUrgencia">Nivel de urgencia que posee esta Paciente</param>
        public Paciente(Int16 pNumeroPaciente, NivelUrgencia pNivelUrgencia)
        {
            this.iNumeroPaciente = pNumeroPaciente;
            this.iNivelUrgencia = pNivelUrgencia;
        }

        public NivelUrgencia GetNivelUrgencia
        {
            get { return this.iNivelUrgencia; }
            set { this.iNivelUrgencia = value; }
        }
        public Int16 NumeroPaciente
        {
            get { return this.iNumeroPaciente; }
            set { this.iNumeroPaciente = value; }
        }
    }
}
