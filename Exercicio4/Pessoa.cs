using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4;

public class Pessoa
{
    public string? Nome { get; set; }
    public override string ToString()
    {
        return "Ola! Meu nome é " + Nome;
    }
}

