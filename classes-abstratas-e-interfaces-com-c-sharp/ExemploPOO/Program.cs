using ExemploPOO.Models;
using ExemploPOO.Interfaces;

/////// Interface na prática
//ICalculadora calc = new ICalculadora(); // impossível instânciar um interface
ICalculadora calc = new Calculadrora();
Console.WriteLine(calc.Multiplicar(3, 9));



// ///// Classe object na prática
// Computador c = new Computador();
// Console.WriteLine(c.ToString());


///// Classe selada na prática
/// ao usar sealed em uma classe ou método, fica impossível herdar ou utilizar por outras classes.



////// Construtor por herança
// Pessoa p1 = new Pessoa("Leonardo");
// Aluno a1 = new Aluno("Eduardo");

// a1.Apresentar();

// Professor prof = new Professor("Josafá");
// prof.Apresentar();