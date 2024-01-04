using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo;

public class Figura
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Executando Desenhar na classe base");
    }
}
