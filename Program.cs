using System.Security.Cryptography.X509Certificates;
using ExerciciosConstrucao;

///////////////////////////
/// 1)

Pessoa p1 = new Pessoa("Victor", 17, "São Caetano do Sul");
p1.Apresentar();

///////////////////////////
/// 2)

Calculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(10,5));
Console.WriteLine(calculadora.Subtrair(25,15));
Console.WriteLine(calculadora.Multiplicar(5,5));
Console.WriteLine(Calculadora.Dividir(4,2));

///////////////////////////
/// 3)
