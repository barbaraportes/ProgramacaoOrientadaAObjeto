using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3;

public class Pessoa
{
    protected string Nome {  get; set; }
    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Olá! Meu nome é {Nome}";
    }
}
