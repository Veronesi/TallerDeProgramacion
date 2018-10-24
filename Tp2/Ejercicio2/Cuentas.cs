using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;
        public Cuentas(Cliente pCliente)
        {
            iCliente = pCliente;
        }
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
            set { this.iCuentaCorriente = value; }
        }
        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
            set { this.iCajaAhorro = value; }
        }
    }
}
