using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {

        public decimal Salario { get; set; }

        //sobrescrevendo o método Apresentar da classe Pessoa
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tneho {Idade} anos, sou uma professor e ganho {Salario} por mês");
        }
    }
}