
using HerancaModificadorAbstract;

Console.WriteLine("## Herança - Modificador abstract ##\n");

//Forma forma = new Forma(); //não é possivel instanciar de uma classe abstrata

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nArea do quadrado: {q.Area} m2");
Console.WriteLine($"\nPerímetro do quadrado: {q.Perimetro} m");

Console.WriteLine($"O quadrado tem a cor: {q.Cor}");