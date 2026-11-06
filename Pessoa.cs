using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosConstrucao
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? Cidade { get; set; }
        public int Idade { get; set; }

                public void Apresentar ()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos e é de {Cidade}");
        }

     public Pessoa(string nome, int idade, string cidade)
{
    Nome = nome;
    Idade = idade;
    Cidade = cidade;
}

    }
}