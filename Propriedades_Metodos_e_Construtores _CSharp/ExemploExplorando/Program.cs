using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Adriano";
p1.Sobrenome = "Lengruber";

Pessoa p2 = new Pessoa();
p2.Nome = "Gustavo";
p2.Sobrenome = "Guanabara";

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Ingles";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAluno();








// p1.Idade = 37;

// p1.Apresentar();