using System;

//cirando array de inteiros com 3 elementos
// int[] arrayInteiros = new int[3];

// //declarando valores às posições do array
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// //acessando elementos do array com FOR
// for (int i = 0; i <= arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
// }

// // Acessado índice inválido
// // arrayInteiros[3] = 1;
// // Console.WriteLine($"{arrayInteiros[3]}");


// //Percorrendo array com FOREACH
// Console.WriteLine("Percorrendo array com FOREACH");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

//Debugando um Array

// Redimensionando um Array - Array.Resize()
//cirando array de inteiros com 3 elementos
// int[] arrayInteiros = new int[3];

// //declarando valores às posições do array
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// //acessando elementos do array com FOR
// for (int i = 0; i <= arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
// }



// Copinando um Array para outro
// int[] arrayInteiros = new int[3];

// //declarando valores às posições do array
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// // realizando cópia
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



// //acessando elementos do array com FOR
// for (int i = 0; i <= arrayInteirosDobrado.Length; i++)
// {
//     Console.WriteLine($"Posição nº {i} - {arrayInteirosDobrado[i]}");
// }

// for (int i = 0; i <= arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
// }


// Trabalhando com listas
List<string> listaString = new List<string>();

//add elementos à lista
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


//Percorrendo a lista com FOR
// for( int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição  nº {i} - {listaString[i]}");
// }


// Console.WriteLine("-------------------");
// //Percorrendo a lista com FOREACH
// int count = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição  nº {count} - {item}");
//     count++;
// }

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");
