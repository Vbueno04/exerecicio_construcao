using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConstrucao
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; private set; }

        public Funcionario(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public void AumentarSalario(decimal percentual)
        {
            if (percentual < 0)
            {
                Console.WriteLine("O percentual de aumento não pode ser negativo.");
                return;
            }

            Salario += Salario * (percentual / 100);
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"Novo salário de {Nome} é: {Salario:C}");
        }
    }
}