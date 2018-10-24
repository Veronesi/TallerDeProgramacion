using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// 
    /// </summary>
    class Complejo
    {
        private Double iReal;
        private Double iImaginario;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pReal"></param>
        /// <param name="pImaginario"></param>
        public Complejo(Double pReal, Double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }
        /// <summary>
        /// 
        /// </summary>
        public Double Real
        {
            get { return this.iReal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double Imaginario
        {
            get { return this.iImaginario; }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double ArgumentoEnRadianes
        {
            get
            {
                Double z = this.iImaginario / this.iReal;
                return (180 / Math.PI) * Math.Atan(z);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double ArgumentoEnGrados
        {
            get
            {
                Double z = this.iImaginario / this.iReal;
                return Math.Atan(z);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Double Magnitud
        {
            get
            {
                Double z = Math.Pow(this.iReal, 2) + Math.Pow(this.iImaginario, 2);
                return Math.Sqrt(z);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Complejo Conjugado
        {
            get
            {
                return new Complejo(this.iReal, - this.iImaginario);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean EsReal()
        {
            if (this.iImaginario == 0)
                return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean EsImaginario()
        {
            if (this.iImaginario != 0 && this.iReal == 0)
                return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Boolean EsIgual(Complejo pOtroComplejo)
        {
            if (this.iReal == pOtroComplejo.iReal && this.iImaginario == pOtroComplejo.iImaginario)
                return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pReal"></param>
        /// <param name="pImaginario"></param>
        /// <returns></returns>
        public Boolean EsIgual(Double pReal,Double pImaginario)
        {
            if (this.iReal == pReal && this.iImaginario == pImaginario)
                return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            return new Complejo(this.iReal + pOtroComplejo.iReal, this.iImaginario + pOtroComplejo.iImaginario);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo Restar(Complejo pOtroComplejo)
        {
            return new Complejo(this.iReal - pOtroComplejo.iReal, this.iImaginario - pOtroComplejo.iImaginario);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            Double a = this.iReal * pOtroComplejo.iReal - this.iImaginario * pOtroComplejo.iImaginario;
            Double b = this.iReal * pOtroComplejo.iImaginario + this.iImaginario * pOtroComplejo.iReal;
            return new Complejo(a, b);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pOtroComplejo"></param>
        /// <returns></returns>
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            if (Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2) == 0)
                return new Complejo(0, 0);
            Double a = this.iReal * pOtroComplejo.iReal + this.iImaginario * pOtroComplejo.iImaginario;
            Double b = this.iImaginario * pOtroComplejo.iReal - this.iReal * pOtroComplejo.iImaginario;
            Double c = Math.Pow(pOtroComplejo.iReal, 2) + Math.Pow(pOtroComplejo.iImaginario, 2);
            return new Complejo(a / c, b / c);
        }
    }
}
