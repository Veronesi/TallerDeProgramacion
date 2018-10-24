using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /// <summary>
    /// Fachada de la aplicacion del sistema de atencion de la Guardia.
    /// </summary>
    class Fachada
    {
        private Guardia iGuardia;
        public Fachada()
        {
            this.iGuardia = new Guardia(new FIFO());
        }
        /// <summary>
        /// Cambia el algoritmo de prioridades de la Guardia.
        /// </summary>
        /// <param name="pTipoEstrategia">Tipo de algoritmo de prioridades</param>
        public void CambiarEstrategia(String pTipoEstrategia)
        {
            if (pTipoEstrategia == "FIFO")
                this.iGuardia.TipoCola = new FIFO();
            else
                this.iGuardia.TipoCola = new Triaje();
        }
        /// <summary>
        /// Agrega un Paciente a la lista de Pacientes de la Guardia.
        /// </summary>
        /// <param name="pNumeroPaciente">Numero de identificacion del Paciente</param>
        /// <param name="pNivelUrgencia">Nivel de urgencia que posee esta Paciente</param>
        public void PushPaciente(Int16 pNumeroPaciente, Int16 pNivelUrgencia)
        {
            NivelUrgencia nivelUrgencia;
            switch (pNivelUrgencia)
            {
                case 1:
                    nivelUrgencia = NivelUrgencia.Rojo;
                    break;
                case 2:
                    nivelUrgencia = NivelUrgencia.Anaranjado;
                    break;
                case 3:
                    nivelUrgencia = NivelUrgencia.Amarillo;
                    break;
                case 4:
                    nivelUrgencia = NivelUrgencia.Verde;
                    break;
                case 5:
                    nivelUrgencia = NivelUrgencia.Azul;
                    break;
                default:
                    nivelUrgencia = NivelUrgencia.Azul;
                    break;
            }
            this.iGuardia.PushPaciente(new Paciente(pNumeroPaciente, nivelUrgencia));
        }
        /// <summary>
        /// Obtiene el proximo Paiente a ser atentido.
        /// </summary>
        /// <returns>Devuelve un Array con el numero de paciente y el nivel de urgencia del mismo</returns>
        public String[] PopPaciente()
        {
            Paciente paciente = this.iGuardia.PopPaciente();
            String[] ret = new string[2];
            ret[0] = paciente.NumeroPaciente.ToString();
            ret[1] = paciente.GetNivelUrgencia.ToString();
            return ret;
        }
    }
}
