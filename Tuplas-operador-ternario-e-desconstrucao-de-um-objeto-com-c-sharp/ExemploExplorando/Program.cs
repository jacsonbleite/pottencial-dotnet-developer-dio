using ExemploExplorando.Models;
using System.Globalization;


// IF TERNÁRIO
int numero = 21;
bool ehPar = false;

// if esle tradicional
// if(numero % 2 == 0){
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }

// utilizando if ternário
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));




// //Desconstrutor
// Pessoa p1 = new Pessoa("Jacson","Leite");
// (string nome, string sobrenome) = p1; //utilizando o Desconstrutor

// Console.WriteLine($"{nome}  {sobrenome}");




////Testando método
// LeituraArquivo arquivo = new LeituraArquivo();
// // Descarts: no lugarde quantidadeLinhas usar _
// var (sucesso, linhasArquivos, _ ) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas); 
//     foreach (string linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }






// //Tupla
// (int, string, string, decimal) tupla = (1, "Jacson", "Leite", 1.70M);

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Miguel", "Leite", 1.20M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Felipe", "Leite", 1.72M);


// Console.WriteLine("Id: " + tupla.Item1);
// Console.WriteLine("Nome: " + tupla.Item2);
// Console.WriteLine("Sobrenome: " + tupla.Item3);
// Console.WriteLine("Altura: " + tupla.Item4);