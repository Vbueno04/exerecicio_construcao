using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConstrucao
{
    public class Calculadora
    {
     public double Somar (double ValorA, double ValorB)
        {
          return ValorA + ValorB;
        }

        public double Subtrair (double ValorA, double ValorB)
        {
            return ValorA - ValorB;
        }
        public double Multiplicar (double ValorA, double ValorB)
        {
            return ValorA * ValorB;
        }

        public static double Dividir (double ValorA, double ValorB)
        {
            if (ValorA <= 0 || ValorB <= 0)
            {
                Console.WriteLine ($"Não será possivel realizar a divisão ");
            }

            return ValorA / ValorB;
        }
    }
}