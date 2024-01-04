using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1;

public class Carro : IVeiculo
{
    public int Gasolina { get; set; }
    public Carro(int gasolina)
    {
        Gasolina = gasolina;
    }

    public void Dirigir()
    {
        if (Gasolina > 0) 
        {
            Console.WriteLine("Dirigindo o carro");
        }
        else
        {
            Console.WriteLine("Sem gasolina");
        }
    }

    public bool Abastecer(int quantidade)
    {
        Gasolina = quantidade;
        return true;
    }
}
