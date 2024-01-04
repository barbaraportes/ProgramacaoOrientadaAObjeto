using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3;

public class Aluno : Pessoa
{
    public Aluno(string nome) : base(nome)
    {
        Nome = nome;
    }
    public void Estudar()
    {
        Console.WriteLine($"{Nome} Estudando...");
    }
}
