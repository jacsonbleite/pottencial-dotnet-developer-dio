using ExemploFundamentos.Models;

int x = 55;
int y = 14;

Caculadora calculadora = new Caculadora();
calculadora.Somar(x,y);
calculadora.Subtrair(x,y);
calculadora.Multiplicar(x,y);
calculadora.Dividir(x,y);

Console.WriteLine("----------------------------");

calculadora.Somar(2,3);
calculadora.Subtrair(5,4);
calculadora.Multiplicar(2,2);
calculadora.Dividir(10,5);

Console.WriteLine("----------------------------");

calculadora.Potencia(3,2);

Console.WriteLine("----------------------------");

calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);

Console.WriteLine("----------------------------");

// Incremento e Decremento
int numero = 10;
Console.WriteLine($"{numero}");
Console.WriteLine("Incremento o 10");

// numero = numero + 1;
// Console.WriteLine(numero);
numero++;
Console.WriteLine(numero);

int numeroDecremento = 10;
Console.WriteLine($"{numeroDecremento}");
Console.WriteLine("Decrementando o 10");

// numeroDecremento = numeroDecremento - 1;
// Console.WriteLine(numeroDecremento);
numeroDecremento--;
Console.WriteLine(numeroDecremento);

Console.WriteLine("----------------------------");

//Raiz Quadrada
calculadora.RaizQuadrada(16);






// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// DateTime dataAtual = DateTime.Now;
// // dataAtual = DateTime.Now.AddDays(5); //adcionado 5 dias



// Console.WriteLine(apresentacao);
// Console.WriteLine("Quentidade: " + quantidade);
// Console.WriteLine("Altura: " + altura);
// Console.WriteLine("Preço: " + preco);
// Console.WriteLine("Condição: " + condicao);
// Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy")); //formatando dada s/ horário
// Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy HH:mm")); //formatando dada c/ horário sem milisgundos


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Jacson";
// pessoa1.Idade = 39;
// pessoa1.Apresentar();