using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


// instalar pacote pelo CLI .NET
// dotnet add package Newtonsoft.Json



//Deserializando um objeto
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} - Preço: {venda.Preco}, Data {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}






////serialização na prática
// serialização de coleção

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Meterial de construção", 75.99M, dataAtual);
// Venda v2 = new Venda(2, "Meterial de elétrico", 55.72M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas);

// File.WriteAllText("Arquivos/vendas.json", serializado); // cria um arquivo JSON

// Console.WriteLine(serializado);


