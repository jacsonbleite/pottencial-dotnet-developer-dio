using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdiconarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                // string texto = "Nº " + i + " - " + Alunos[i].NomeCompleto;
                string texto = $"nº {i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto); 
            }            
        }
    }
}