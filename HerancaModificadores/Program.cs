
Console.WriteLine("## Herança - Modificadores\n");

ClasseDerivada cd = new();
cd.VerificaAcesso();




Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        //Private_Membro();

        Console.WriteLine("\nAcesso ao campo private usando uma propriedade");
        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine($"\nTotal soma: {soma}");
    }
}



public class ClasseBase
{
    //campos
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;

    //encapsulamento
    private int private_var = 4;

    //propriedade
    public int Private_var
    {
        get { return private_var; }
        set { private_var = value; }
    }


    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }

    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected Internal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }


}

