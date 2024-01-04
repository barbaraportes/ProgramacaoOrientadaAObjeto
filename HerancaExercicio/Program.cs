
using HerancaExercicio;

Console.WriteLine("## Herança - Exercicio ##\n\n");



Conta conta = new Conta();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine($"\nConta Corrente -\t Numero: {conta.Numero}\t Titular: {conta.Titular}\n");

Console.WriteLine("Depositando R$ 1000,00");
conta.Depositar(1000);

Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da conta: {conta.Saldo:c}");

Console.WriteLine("Sacando R$ 2000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta: {conta.Saldo:c}");


Console.ReadKey();


ContaPoupanca contapoupanca = new();
contapoupanca.Numero = 222;
contapoupanca.Titular = "José";

Console.WriteLine($"\nConta Poupança -\t Numero: {contapoupanca.Numero}\t Titular: {contapoupanca.Titular}\n");

Console.WriteLine("Depositando R$ 1000,00");
contapoupanca.Depositar(1000);
Console.WriteLine($"Saldo da ContaPoupança: {contapoupanca.Saldo:c}");

Console.WriteLine("Sacando R$ 100,00");
contapoupanca.Sacar(100);
Console.WriteLine($"Saldo da ContaPoupança: {contapoupanca.Saldo:c}");

Console.WriteLine("Sacando R$ 2000,00");
contapoupanca.Sacar(2000);
Console.WriteLine($"Saldo da ContaPoupança: {contapoupanca.Saldo:c}");

Console.ReadKey();

ContaInvestimento containvestimento = new();
containvestimento.Numero = 333;
containvestimento.Titular = "Ana";

Console.WriteLine($"\nConta Investimento -\t Numero: {containvestimento.Numero}\t Titular: {containvestimento.Titular}\n");

Console.WriteLine("Depositando R$ 1000,00");
containvestimento.Depositar(1000);
Console.WriteLine($"Saldo da ContaInvestimento: {containvestimento.Saldo:c}");

Console.WriteLine("Sacando R$ 100,00");
containvestimento.Sacar(100);
Console.WriteLine($"Saldo da ContaInvestimento: {containvestimento.Saldo:c}");

Console.WriteLine("Sacando R$ 2000,00");
containvestimento.Sacar(2000);
Console.WriteLine($"Saldo da ContaInvestimento: {containvestimento.Saldo:c}");

Console.ReadKey();