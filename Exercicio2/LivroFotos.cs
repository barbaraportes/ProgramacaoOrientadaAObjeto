using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2;

public class LivroFotos
{
    protected int numeroPaginas;

    public LivroFotos()
    {
        numeroPaginas = 16;
    }

    public LivroFotos(int numeroPaginas)
    {
        this.numeroPaginas = numeroPaginas;
    }

    public int GetNumeroPaginas()
    { 
        return numeroPaginas; 
    }

    public class SuperLivroFotos : LivroFotos
    {
        public SuperLivroFotos()
        {
            numeroPaginas = 64;
        }
    }
}
