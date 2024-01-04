
using Agregacao;

Console.WriteLine("## Agregação ##\n");

Professor prof1 = new Professor("Carlos", "Quimica");
Professor prof2 = new Professor("Maria", "Ingles");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matematica");


Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof4);
dep1.ListaProfessores();

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListaProfessores();


Console.ReadKey();



