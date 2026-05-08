using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionC_.Models
{
    public class Multiplicacion
    {
        public int A { get; set; }
        public int B { get; set; }
        public string OperacionCompleta { get; set; } // Aquí guardaremos "3+3+3+3+3=15"

        public void CalcularMultiplicacion()
        {
            int suma = 0;
            string textoSuma = "";

            // Si B es mayor a 0, hacemos el ciclo
            if (B > 0)
            {
                for (int i = 0; i < B; i++)
                {
                    suma += A; // Sumamos A al total
                    textoSuma += A.ToString(); // Agregamos el número al texto

                    // Si NO es la última vuelta del ciclo, agregamos el signo "+"
                    if (i < B - 1)
                    {
                        textoSuma += "+";
                    }
                }

                // Al final del ciclo, le agregamos el "=" y el resultado total
                this.OperacionCompleta = textoSuma + "=" + suma;
            }
            else
            {
                // Por si el profe pone B = 0 para probar si truena tu programa
                this.OperacionCompleta = "0=0";
            }
        }
    }
}