using ExemploExplorando.Models;
using System.Globalization;


//DateTime
// DateTime data = DateTime.Now;
// // Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// DateTime data = DateTime.Parse("05/10/2022 17:46");
// Console.WriteLine(data);


string dataString = "2022-12-17 17:46";

bool sucesso = DateTime.TryParseExact(dataString,
                       "yyyy-MM-dd HH:mm", 
                       CultureInfo.InvariantCulture, 
                       DateTimeStyles.None, out DateTime data);


if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

// Console.WriteLine(data);







// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // valor monetário em Dolar

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}"); // R$ 82,40

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // valor monetário em Real

// Console.WriteLine(valorMonetario.ToString("C2")); //numero de casas decimais

// Console.WriteLine(valorMonetario.ToString("N2")); //N trata como número, mantendo a formatação

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));




// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;

// int numero1 = 10;
// string numero2 = "20";
// string resultado = numero1 + numero2;

// int numero1 = 10;
// int numero2 = 20;
// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);







// Pessoa p1 = new Pessoa(nome: "Jacson", sobrenome: "Leite");

// Pessoa p2 = new Pessoa();
// p2.Nome = "Miguel";
// p2.Sobrenome = "Leite";

// Curso cursoDeingles = new Curso();
// cursoDeingles.Nome = "Inglês";
// cursoDeingles.Alunos = new List<Pessoa>();

// cursoDeingles.AdiconarAluno(p1);
// cursoDeingles.AdiconarAluno(p2);
// cursoDeingles.ListarAlunos();



// Pessoa p1 = new Pessoa();
// p1.Nome = "Jacson";
// p1.Sobrenome = "Leite";
// p1.Idade = 39;

// p1.Apresentar();

