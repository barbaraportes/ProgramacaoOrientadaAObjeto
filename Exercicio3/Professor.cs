using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3;

public class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    {
        Nome = nome;
    }

    public void Explicar()
    {
        Console.WriteLine($"{Nome} Explicando...");
    }
}
