using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Jacson", sobrenome: "Leite");

Pessoa p2 = new Pessoa();
p2.Nome = "Miguel";
p2.Sobrenome = "Leite";

Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdiconarAluno(p1);
cursoDeingles.AdiconarAluno(p2);
cursoDeingles.ListarAlunos();



// Pessoa p1 = new Pessoa();
// p1.Nome = "Jacson";
// p1.Sobrenome = "Leite";
// p1.Idade = 39;

// p1.Apresentar();

