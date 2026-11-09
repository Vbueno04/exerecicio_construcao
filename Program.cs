// using System.Security.Cryptography.X509Certificates;
// using ExerciciosConstrucao;

// ///////////////////////////
// /// 1)

// Pessoa p1 = new Pessoa("Victor", 17, "São Caetano do Sul");
// p1.Apresentar();

// ///////////////////////////
// /// 2)

// Calculadora calculadora = new Calculadora();
// Console.WriteLine(calculadora.Somar(10,5));
// Console.WriteLine(calculadora.Subtrair(25,15));
// Console.WriteLine(calculadora.Multiplicar(5,5));
// Console.WriteLine(Calculadora.Dividir(4,2));

///////////////////////////
/// 3)

// Veiculo veiculo = new Veiculo();
// Veiculo veiculo1 = new Veiculo();
// veiculo1.Velocidade = 150; // Valor válido
// Console.WriteLine($"Velocidade do veículo 1: {veiculo1.Velocidade} km/h");

// Veiculo veiculo2 = new Veiculo();
// veiculo2.Velocidade = 250; // Valor inválido
// Console.WriteLine($"Velocidade do veículo 2: {veiculo2.Velocidade} km/h");
// Veiculo veiculo3 = new Veiculo();
// veiculo3.Velocidade = -10; // Valor inválido
// Console.WriteLine($"Velocidade do veículo 3: {veiculo3.Velocidade} km/h");

// Veiculo veiculo4 = new Veiculo();
// veiculo4.Velocidade = 100; // Valor válido
// Console.WriteLine($"Velocidade do veículo 4: {veiculo4.Velocidade} km/h");
// Veiculo veiculo5 = new Veiculo();
// veiculo5.Velocidade = 0; // Valor válido
// Console.WriteLine($"Velocidade do veículo 5: {veiculo5.Velocidade} km/h");

///////////////////////////
/// 4)

// Funcionario funcionario = new Funcionario("Carlos", "Desenvolvedor", 5000m);
// funcionario.AumentarSalario(10m);
// funcionario.ConsultarSalario();

///////////////////////////
/// 5)

// Livro livro1 = new Livro();
// Livro livro2 = new Livro("O Senhor dos Anéis");
// Livro livro3 = new Livro("Anne Frank", "Anne Frank");
// Livro livro4 = new Livro("Harry Potter", "J.K. Rowling", 300);

// Console.WriteLine($"Livro 1: {livro1.Titulo}, Autor: {livro1.Autor}, Páginas: {livro1.NumeroPaginas}");
// Console.WriteLine($"Livro 2: {livro2.Titulo}, Autor: {livro2.Autor}, Páginas: {livro2.NumeroPaginas}");
// Console.WriteLine($"Livro 3: {livro3.Titulo}, Autor: {livro3.Autor}, Páginas: {livro3.NumeroPaginas}");
// Console.WriteLine($"Livro 4: {livro4.Titulo}, Autor: {livro4.Autor}, Páginas: {livro4.NumeroPaginas}");