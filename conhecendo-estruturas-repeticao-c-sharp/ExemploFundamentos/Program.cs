using ExemploFundamentos.Models;

// Introdução ao FOR
// Debugando o FOR
// int numero = 10;

// Console.WriteLine($"{numero} x 1 = {numero * 1}");

// for (int count = 0; count <= 10; count++)
// {
//     Console.WriteLine($"Tabuada de Soma com {numero}");
//     Console.WriteLine($"{numero} + {count} = {numero + count}");       
// }





// Introdução ao  WHILE
// Debugando o WHILE
// Intenrrompendo o fluxo de execução (break)
// int numero = 5;
// int count = 1;
// while(count <= 10)
// {
//     Console.WriteLine($"{numero} x {count} = {numero * count}");  
//     count++;

//     if(count == 5){
//         break;
//     }
// }

// Introdução DO WHILE
// Debugando DO WHILE
// int soma = 0; 
// int numero = 0;


// do 
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());   
//     soma += numero;   

// } while (numero != 0);


// Console.WriteLine($"Total da soma é: {soma}");


// Construindo um menu interativo
// Refatorando o menu
string? opcao;
bool exibirMenu = true;

while (exibirMenu)
{

    Console.Clear();
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();



    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro do Cliente");
            break;

        case "2":
            Console.WriteLine("Cadastrar do Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar do Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false; // Sai e executa o que vem depois do WHILE
            // Environment.Exit(0); // Encerra o programa
            break;

        default:
            Console.WriteLine("Opção inválida:");
            break;
    }


}


Console.WriteLine("Programa encerrado!");