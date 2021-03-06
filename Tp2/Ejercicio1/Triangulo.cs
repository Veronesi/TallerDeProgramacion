﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;
        public Triangulo(Punto pPunto1, Punto pPunto3, Punto pPunto2)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }
        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }
        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }
        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }
        public double Area()
        {
            double ladoA = this.iPunto1.CalcularDistanciaDesde(this.iPunto2);
            double ladoB = this.iPunto2.CalcularDistanciaDesde(this.iPunto3);
            double ladoC = this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
            // Forumula de heron : 0.25√((a^2 + b^2 + c^2)^2 - 2(a^4 + b^4 + c^4))
            return 0.25 * Math.Sqrt((Math.Pow(ladoA, 2)+ Math.Pow(ladoB, 2)+ Math.Pow(ladoC, 2)) -2* (Math.Pow(ladoA, 4) + Math.Pow(ladoB, 4) + Math.Pow(ladoC, 4)));
        }
        public double Perimetro()
        {
            double ladoA = this.iPunto1.CalcularDistanciaDesde(this.iPunto2);
            double ladoB = this.iPunto2.CalcularDistanciaDesde(this.iPunto3);
            double ladoC = this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
            return ladoA + ladoB + ladoC;
        }
    }
}
