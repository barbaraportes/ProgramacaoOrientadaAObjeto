Console.WriteLine("## Herança - New ##\n");

Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Qumica";
Console.WriteLine(aluno.Saudacao());




Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }

    public string Saudacao() => $"Oi, eu sou a {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao()
        => $"Oi, eu sou {Nome} do curso de {Curso}.";
}