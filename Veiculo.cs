using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConstrucao
{
    public class Veiculo
    {
        public double Velocidade {get; set;}
         public void MedirVelocidade (double Velocidade)
        {
            if (Velocidade < 0 || Velocidade > 200 )
            {
                Velocidade = Velocidade;
                Console.WriteLine("Velocidade não alternada");

            }
        }
    }
}