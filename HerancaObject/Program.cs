
Console.WriteLine("## Herança - Object ##\n");
//Classe Object é a classe Base/Pai de todas
//Metodos da classe object estão disponiveis para todos os objetos: Equals/ToString, etc
//uma classe só pode herdar de outra classe e de apenas 1 classe


Nada nada = new Nada();
nada.Equals(nada); 





Console.ReadKey();

public struct Struct1
{

}

public class Classe1
{

}

public class Classe2 : Struct1 //não é possivel herdar de struct, herda apenas de classe
{

}

public class ClassDerivada : Classe1, Classe2 //não é possivel herdar de mais de uma classe, apenas de 1
{

}


