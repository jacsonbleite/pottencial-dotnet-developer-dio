using ExemploFundamentos.Models;

int x = 55;
int y = 14;

Caculadora calculadora = new Caculadora();
calculadora.Somar(x,y);
calculadora.Subtrair(x,y);
calculadora.Multiplicar(x,y);
calculadora.Dividir(x,y);


Console.WriteLine("----------------------------");

Caculadora calculadora2 = new Caculadora();
calculadora2.Somar(2,3);
calculadora2.Subtrair(5,4);
calculadora2.Multiplicar(2,2);
calculadora2.Dividir(10,5);






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