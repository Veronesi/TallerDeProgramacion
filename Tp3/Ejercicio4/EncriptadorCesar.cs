using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;
        public EncriptadorCesar(int pDesplazamiento) : base("César")
        {
            this.Desplazamiento = pDesplazamiento;
        }
        public int Desplazamiento
        {
            get { return this.iDesplazamiento; }
            set { this.iDesplazamiento = value; }
        }
        public override string Encriptar(string pCadena)
        {
            int iCantidad = pCadena.Length;
            char[] iVectorCadena = new char[iCantidad];
            for (int i = 1; i <= iCantidad; i++)
            {
                iVectorCadena[i] = pCadena[i];
            }
            for (int i = 1; i <= iCantidad; i++)
            {
                if (iVectorCadena[i] >= 65 && iVectorCadena[i] <= 90 && iDesplazamiento < 26)
                {
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + iDesplazamiento);
                    if (iVectorCadena[i] > 90)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) - 26);
                    }
                }
                if (iVectorCadena[i] >= 65 && iVectorCadena[i] <= 90 && iDesplazamiento > 26)
                {
                    int auxDesplazamiento = iDesplazamiento % 26;
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + auxDesplazamiento);
                    if (iVectorCadena[i] > 90)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) - 26);
                    }
                }
                if (iVectorCadena[i] >= 97 && iVectorCadena[i] <= 122 && iDesplazamiento < 26)
                {
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + iDesplazamiento);
                    if (iVectorCadena[i] > 122)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) - 26);
                    }
                }
                if (iVectorCadena[i] >= 97 && iVectorCadena[i] <= 122 && iDesplazamiento > 26)
                {
                    int auxDesplazamiento = iDesplazamiento % 26;
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + auxDesplazamiento);
                    if (iVectorCadena[i] > 122)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) - 26);
                    }
                }
                if (iVectorCadena[i] >= 48 && iVectorCadena[i] <= 57 && iDesplazamiento < 10)
                {
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + iDesplazamiento);
                    if (iVectorCadena[i] > 57)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) - 10);
                    }
                }
                if (iVectorCadena[i] >= 48 && iVectorCadena[i] <= 57 && iDesplazamiento > 10)
                {
                    int auxDesplazamiento = iDesplazamiento % 10;
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + auxDesplazamiento);
                    if (iVectorCadena[i] > 57)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) - 10);
                    }
                }
            }
            return iVectorCadena.ToString();
        }
        public override string Desencriptar(string pCadena)
        {
            int iCantidad = pCadena.Length;
            char[] iVectorCadena = new char[iCantidad];
            for (int i = 1; i <= iCantidad; i++)
            {
                iVectorCadena[i] = pCadena[i];
            }
            for (int i = 1; i <= iCantidad; i++)
            {
                if (iVectorCadena[i] >= 65 && iVectorCadena[i] <= 90 && iDesplazamiento < 26)
                {
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + iDesplazamiento);
                    if (iVectorCadena[i] < 65)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + 26);
                    }
                }
                if (iVectorCadena[i] >= 65 && iVectorCadena[i] <= 90 && iDesplazamiento > 26)
                {
                    int auxDesplazamiento = iDesplazamiento % 26;
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + auxDesplazamiento);
                    if (iVectorCadena[i] < 65)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + 26);
                    }
                }
                if (iVectorCadena[i] >= 97 && iVectorCadena[i] <= 122 && iDesplazamiento < 26)
                {
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + iDesplazamiento);
                    if (iVectorCadena[i] < 97)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + 26);
                    }
                }
                if (iVectorCadena[i] >= 97 && iVectorCadena[i] <= 122 && iDesplazamiento > 26)
                {
                    int auxDesplazamiento = iDesplazamiento % 26;
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + auxDesplazamiento);
                    if (iVectorCadena[i] < 97)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + 26);
                    }
                }
                if (iVectorCadena[i] >= 48 && iVectorCadena[i] <= 57 && iDesplazamiento < 10)
                {
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + iDesplazamiento);
                    if (iVectorCadena[i] < 48)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + 10);
                    }
                }
                if (iVectorCadena[i] >= 48 && iVectorCadena[i] <= 57 && iDesplazamiento > 10)
                {
                    int auxDesplazamiento = iDesplazamiento % 10;
                    iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + auxDesplazamiento);
                    if (iVectorCadena[i] < 48)
                    {
                        iVectorCadena[i] = Convert.ToChar(Convert.ToInt16(iVectorCadena[i]) + 10);
                    }
                }
            }
            return iVectorCadena.ToString();
        }
    }
}
