using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea4
{
    public class calculo
    {
        public decimal cuadrado(decimal L1, decimal L2)
        {
            return L1 * L2;
        }
        public decimal triangulo(decimal T1, decimal T2)
        {
            var res = T1 * T2;
            return res / 2;
        }
        public double circulo(double C1)
        {
            double pi = 3.14;
            double ra = C1 * C1;
            return pi * ra;
        }
    }
}