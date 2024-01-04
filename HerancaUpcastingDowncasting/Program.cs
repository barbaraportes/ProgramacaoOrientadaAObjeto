
using HerancaUpcastingDowncasting;


Console.WriteLine("## Herança - Upcasting e Downcasting ##\n");

//upcasting

//EXEMPLO 1 

//Forma circulo = new Circulo(10, 20); 

//circulo.Desenhar();


//EXEMPLO 2

//Circulo circulo = new Circulo(10, 20);
//Forma forma = circulo;

//forma.Desenhar();
//Console.WriteLine(forma == circulo);


//DOWNCASTING


Circulo circulo = new Circulo(10, 20);
Forma f = circulo; //upcasting - implicita

Circulo c = (Circulo)f; //downcasting - explicita

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);








Console.ReadKey();