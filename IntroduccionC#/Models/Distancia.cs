using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionC_.Models
{
    public class Distancia
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double Resultado { get; set; }

        public void CalcularDistancia()
        {
            this.Resultado = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
    }
}