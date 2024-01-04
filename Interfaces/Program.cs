
Console.WriteLine("## Interfaces ##\n");

IControle d = new Demo(); //para acessar o membro definidos na interface, você deve armazenar em instancia da classe no tipo da interface
d.Nome = "Teste";
d.Desenhar();
d.Exibir();





Console.ReadKey();


interface IControle
{

    //public IControle()        //interface não pode ter construtor de instancia
    //{ }

    //int status;              //interface não pode ter campo de instancia

    void Desenhar(); //método sem implementação

    string Nome {  get; set; } //propriedade sem implementação

    public void Exibir()
    {
        Console.WriteLine("Teste");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControle, IGrafico
{
    public string Nome { get; set; } = string.Empty; //é necessario implementar valor da propriedade
    public void Desenhar()
    {
        Console.WriteLine("Desenhando..."); //é necessario implementar um método quando ele não tem implementação
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }
}
