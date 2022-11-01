using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


/////// Métodos de extensão
int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O" + numero + " " + "é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem);



//////Testando Classe genérica MeuArray
// MeuArray<int> arraInteiro = new MeuArray<int>();
// arraInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arraInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("texto");

// Console.WriteLine(arrayString[0]);


//////Tipos dinâmicos
// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "texto";
// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");











//////Tipo anônimos
// var tipoAnonimo = new { Nome = "Jacson", Sobrenome = "Leite", Altura = 1.80};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);


//// tipos anônimos em coleção
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }











// using System;  

// class minhaClasse
// {

//     static void Main(string[] args)
//     {

//         double salario = 0.00;
//         double reajuste = 0.00;
//         double novoSalario = 0.00;
//         double percentual = 0.00;

//         salario = Convert.ToDouble(Console.ReadLine());

//         //TODO: Complete os espaços em branco com uma possível solução para o problema:

//         if (salario > 0)
//         {
//             reajuste = salario * 0.15;
//             novoSalario = salario + reajuste;
//             percentual = 15;
//         }
//         else
//         if (salario > 400)
//         {
//             percentual = 12;
//             reajuste = salario * 0.12;
//             novoSalario = salario + reajuste;
//         }
//         else
//         if (salario > 800)
//         {
//             percentual = 10;
//             reajuste = salario * 0.10;
//             novoSalario = salario + reajuste;
//         }
//         else
//         if (salario > 1200)
//         {
//             percentual = 7;
//             reajuste = salario * 0.07;
//             novoSalario = salario + reajuste;
//         }
//         else
//         {
//             percentual = 4;
//             reajuste = salario * 0.04;
//             novoSalario = salario + reajuste;
//         }

//         Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}\n"
//                             + $" Reajuste ganho: {reajuste.ToString("F2")}\n"
//                             + $" Em percentual: {percentual}%\n");

//     }
// }






// if (salario < 0.0)
// {
//     return;

// }
// else if (salario >= 0.0 && salario <= 400.00)
// {
//     percentual = 15.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;




// }
// else if (salario > 400.00 && salario <= 800.00)
// {
//     percentual = 12.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;


// }
// else if (salario > 800.00 && salario <= 1200.00)
// {
//     percentual = 10.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;


// }
// else if (salario > 1200.00 && salario <= 2000.00)
// {
//     percentual = 7.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;


// }
// else
// {
//     percentual = 4.0 / 100.00;
//     reajuste = salario * percentual;
//     novoSalario = reajuste + salario;


// }



// instalar pacote pelo CLI .NET
// dotnet add package Newtonsoft.Json






// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//     $" Preço: {venda.Preco}, Data {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + 
//     $"{(venda.Desconto.HasValue ? $", Desconto de: {venda.Desconto}" : "")}");
// }
