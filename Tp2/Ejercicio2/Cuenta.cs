using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;
        public Cuenta (double pAcuerdo, double pSaldoInicial)
        {
            iAcuerdo = pAcuerdo;
            iSaldo = pSaldoInicial;
        }
        public double Saldo
        {
            get { return this.iSaldo; }
            set { this.iSaldo = value; }
        }
        public double Acuerdo
        {
            get { return this.iAcuerdo; }
            set { this.iAcuerdo = value; }
        }
        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }
        public bool DebitarSaldo(double pSaldo)
        {
            return (pSaldo <= this.iSaldo);
        }
            
    }
}
