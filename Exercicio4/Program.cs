using Exercicio4;

Console.WriteLine("## Exercicio 4 ##\n");

//Crie um programa que solicite ao usuário os nomes de três pessoas e os armazene em uma
//matriz de objetos do tipo Pessoa.
//Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo
//string, um construtor que receba o nome como parâmetro e sobrescreva o método
//ToString().
//Finalize o programa lendo as pessoas e executando o método ToString() na tela.

int total = 3;
Pessoa[] pessoas = new Pessoa[total];
Console.WriteLine("Informe o nome de 3 Pessoas");
for (int i = 0; i < total; i++)
{
    pessoas[i] = new Pessoa()
    {
        Nome = Console.ReadLine()
    };
}
Console.WriteLine("\nAcessando os dados...\n");
for (int i = 0; i < total; i++)
{
    Console.WriteLine(pessoas[i].ToString());
}
Console.ReadLine();