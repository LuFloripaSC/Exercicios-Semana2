// See https://aka.ms/new-console-template for more information
using Exercicio1;

Console.WriteLine("Hello, World!");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Luciano";
funcionario.DataNascimento = DateTime.Now;
funcionario.SalvarFuncionario();
