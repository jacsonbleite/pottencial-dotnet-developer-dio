using ExemploFundamentos.Models;

// Operador de atribução '='
// int a = 10;
// int b = 20;
// int c = a + b;

// Console.WriteLine(c);

// Combinando Operadores

// c = c + 5;

// Console.WriteLine(c);

// Convertendo tipos de variáveis

// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// int a = int.Parse("5a"); //gera erro

// Console.WriteLine(a);

// Diferença entre Convert e Parse
// int a = Convert.ToInt32(null); // conver para 0
// int a = int.Parse(null); // gera erro, Parse não aceita null

// Console.WriteLine(a);


// Conversão para string
// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// Cast implícito

// int a = 5;
// double b = a;
// long b = a;

// long a = 5;
// int b = a; // gera erro
// int b = Convert.ToInt32(a);

// long a = long.MaxValue; // valor máximo de long
// int b = Convert.ToInt32(a); //erro

// int a = int.MaxValue; // valor máximo de int
// long b = a; //erro
// Console.WriteLine(b);

// Ordem  dos operadores

// double a  = 4 / 2 + 2;
// Console.WriteLine(a);

// convertando de maneira segura

// string a = "15-";
// int b = 0;

// // int.TryParse(a, out b);
// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Com o uso do TryParse o códio continua mesmo...");


// Introdução operadores condicionais

// Operador condicional na prática
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade pedida {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Quantidade em estoque é insuficiente :(");
// }


// Debugando operador condicional
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade pedida {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Quantidade em estoque é insuficiente :(");
// }


// IF aninhado

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade pedida {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Iválida");
// }
// else
// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Quantidade em estoque é insuficiente :(");
// }


// Aprendendo o switch case

// Console.WriteLine("Digite uma letra: ");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"Letra {letra} é uma vogal");
//         break;
//     default:
//         Console.WriteLine($"Letra {letra} não é uma vogal");
//         break;
// }


// Operadores Lógicos

//Operador OR na prática
// bool ehMaiorDeIdadeidade = false;
// bool possuiAutorizacaoDoResposavel = true;

// if (ehMaiorDeIdadeidade || possuiAutorizacaoDoResposavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// Operador AND
// bool possuiPresencaMinima = true;
// double media = 6.5;

// if (possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// }
// else{
//     Console.WriteLine("Reprovado");
// }

// Operador NOT
bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}






// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// DateTime dataAtual = DateTime.Now;
// dataAtual = DateTime.Now.AddDays(5); //adcionado 5 dias



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