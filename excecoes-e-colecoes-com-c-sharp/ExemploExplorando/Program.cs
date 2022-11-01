using ExemploExplorando.Models;
using System.Globalization;


//Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RO","Rondônia");
estados.Add("AC","Acre");
estados.Add("AM","Amazonas");

Console.WriteLine(estados["AM"]); //Acessa o valor

// // foreach (var item in estados) ou
// foreach (KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Console.WriteLine(" ------ ");
// // estados.Add("AM","Amazonas"); //gera erro por chave duplicada
// estados.Remove("AM");
// estados["RO"] = "Rondônia - valor aterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

string chave = "RS";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor {chave}, já existe");
}
else
{
    Console.WriteLine($"Valor {chave}, não existe. Pode add!");
}





// //Pilha
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("Elemento " + pilha.Pop() + " removido.");

// pilha.Push(20);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }





// // Filas
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(6);

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }







// new ExemploExcecao().Metodo1();



// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Diretório não existe. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }
