using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicio;

public interface ISalvar
{
    //por padrão é publico
    void Salvar(); //toda classe que implementar a interface, será obrigada a implementar este método

    void Compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
