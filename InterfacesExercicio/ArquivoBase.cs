using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicio;

public abstract class ArquivoBase //classe abstrata: não pode ser instanciada
{
    public virtual void Nome() //virtual: método vai ser sobrescrito pelas classes que herdarem da classe base
    {
        Console.WriteLine("Definir o nome do arquivo");
    }
}
