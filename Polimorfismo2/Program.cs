
Console.WriteLine("## Polimorfismo em tempo de compilação - usando sobrecarga de métodos ##\n");
//sobrecarga de métodos - metodos com o mesmo nome, mas parametros diferentes
//a execução é decidida em tempo de compilação de acordo com os parametros
//polimorfismo estatico

Calcular calc = new Calcular();

Console.WriteLine(calc.Somar(30, 40));
Console.WriteLine(calc.Somar(30, 40, 50));



Console.ReadKey();


class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}
