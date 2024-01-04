
Console.WriteLine("## Herança - Modificador Sealed ##\n");
//usado para impedir a herança na classe base
//sealed no método, impede que este metodo continue a ser herdado por outras classes



Console.ReadKey();

// EXEMPLO 1

////sealed na classe base, impede a herança
//sealed class Pessoa
//{
//    public string? Nome { get; set; }
//    public void ExibeNome()
//    {
//        Console.WriteLine($"Meu nome é {Nome}.");
//    }
//}


//class Cliente
//{
//    public void ExibeNome()
//    {
//        Console.WriteLine($"\nNome do cliente: {Nome}");
//    }
//}


// EXEMPLO 2

class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }

    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }

}

class Classe1 : ClasseBase
{
    sealed protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe1.Metodo2()");
    }
}

class Classe2 : Classe1
{
    protected override void Metodo1() //impediu que o método continue a ser sobrescrito nas classes derivadas
    {
        Console.WriteLine("Classe2.Metodo1()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo2()");
    }
}