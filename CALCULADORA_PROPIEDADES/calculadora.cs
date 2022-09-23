using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_PROPIEDADES
{
    internal class calculadora
    {
        internal class cloperaciones
        {
            // Propiedades, campos, etc.
            private int n1;
            private int n2;
            public cloperaciones()
            {

            }

            // Encapsulamiento de las propiedades.
            public int N1 { get => n1; set => n1 = value; }
            public int N2 { get => n2; set => n2 = value; }

            // Metodos.
            public int Sumar()
            {
                return n1 + n2;
            }
            public int Restar()
            {
                return n1 - n2;
            }
            public int Multiplicar()
            {
                return n1 * n2;
            }
            public double Dividir()
            {
                return (double)n1 / n2;
            }
        }
    }
}
