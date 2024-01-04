Console.WriteLine("## Herança - Modificadores\n");


Aluno aluno1 = new();

Aluno aluno2 = new Aluno("José");


//primeiro chama construtor base sem parametro, depois construtor derivada sem parametro
//depois chama construtor base com parametro, depois construtor derivada com parametro




Console.ReadKey();

//base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}

//derivada
class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor da classe Aluno com parametro");
    }
}


