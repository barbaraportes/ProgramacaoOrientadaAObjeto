
using Polimorfismo;

Console.WriteLine("## Polimorfismo com classe abstrata ##\n");
//polimorfismo dinamico atraves de classes abstratas ou concretas através de virtuais
//compilação

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}





Console.ReadKey();


