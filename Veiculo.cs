using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConstrucao
{
    public class Veiculo
    {
        // A propriedade deve aceitar apenas valores entre 0 e 200 km/h.
        private int velocidade;
        public int Velocidade
        {
            get { return velocidade; }
            set
            {
                if (value < 0 || value > 200)
                {
                    Console.WriteLine("Velocidade deve estar entre 0 e 200 km/h.");
                    value = 0;
                }
                velocidade = value;
            }
        }
    }
}