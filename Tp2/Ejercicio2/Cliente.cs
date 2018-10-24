using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Cliente
    {
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;
        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            iTipoDocumento = pTipoDocumento;
            iNombre = pNombre;
            iNroDocumento = pNroDocumento;
        }
        public string NroDocumento
        {
            get { return this.iNroDocumento; }
            set { this.iNroDocumento = value; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
            set { this.iTipoDocumento = value; }
        }


    }
}
