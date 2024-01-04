
using Exercicio1;

Console.WriteLine("## Exercicio 1 ##\n");

//1. Crie um programa que implemente uma interface IVeiculo com dois métodos, um para Dirigir
//do tipo void e outro para Abastecer do tipo bool que possui um parâmetro do tipo int com a
//quantidade de gasolina a abastecer.(defina isso como uma propriedade)
//2. Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a
//quantidade inicial de gasolina do carro e implemente os métodos Dirigir e Abastecer do carro.
//3. O método Dirigir deve exibir na tela ”Dirigindo o carro..”, se a gasolina for maior que 0, caso
//contrário deve exibir “Sem gasolina...”, e o método Abastecer deve aumentar a gasolina do
//carro e retornar true.
//4. Para testar, crie um objeto do tipo Carro com 0 de gasolina inicial e solicite ao usuário a
//informação de uma quantidade de gasolina para abastecer via teclado e por fim execute o
//método Dirigir do carro.


Carro carro = new Carro(0);

Console.WriteLine("Informe quantos litros de gasolina: ");
int gasolina = Convert.ToInt32(Console.ReadLine());

if(carro.Abastecer(gasolina))
{
    carro.Dirigir();
}

Console.ReadKey();






