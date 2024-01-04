
using InterfacesExercicio;

Console.WriteLine("## Interfaces - Exercicios ##\n");


SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

//para acessar o método, que contém implementacao, de uma interface que esta sendo herdada por uma classe concreta,
//tem que criar instancia da classe que ta herdando a interface e converter ela pro tipo da interface
ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar(); 


Console.ReadKey();



