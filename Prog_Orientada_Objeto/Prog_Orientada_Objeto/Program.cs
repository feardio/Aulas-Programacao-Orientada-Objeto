using System;

namespace Prog_Orientada_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento humanas = new Departamento();
            humanas.Nome = "Departamento de Humanas";

            Departamento exatas = new Departamento();
            exatas.Nome = "Departamento de Exatas";


            Aluno aluno = new Aluno();

            aluno.setNome("Gabriel da Silva");
            aluno.setIdade(15);
            aluno.Matricula = 13;
            aluno.Presente = false;
            aluno.imprimir();


            Aluno aluno2 = new Aluno();

            aluno2.setNome("Amanda Santos");
            aluno2.setIdade(19);
            aluno2.Matricula = 89;
            aluno2.Presente = true;
            aluno2.imprimir();


            Professor professor = new Professor();
            professor.setNome("José de Oliveira");
            professor.setIdade(43);
            professor.ValorHora = 50;
            professor.Tipo = 1;
            professor.Bonus = 0;
            Console.WriteLine("Salario: {0:c}", professor.CalcularSalarioFinal(160));
            professor.imprimir();
            professor.addAluno(aluno);
            professor.ImprimirAlunos();
            professor.setDepartamento = exatas;

            Professor professor2 = new Professor();
            professor2.setNome("Maria Carvalho dos Santos");
            professor2.setIdade(56);
            professor2.ValorHora = 50;
            professor2.Tipo = 2;
            professor2.Bonus = 15;
            Console.WriteLine("Salario: {0:c}", professor2.CalcularSalarioFinal(160));
            professor2.imprimir();
            professor2.addAluno(aluno);
            professor2.addAluno(aluno2);
            professor2.ImprimirAlunos();
            professor2.setDepartamento = humanas;


            humanas.addProfessor(professor2);
            exatas.addProfessor(professor);

            //Console.WriteLine($"os alunos {aluno.nome} e {aluno2.nome} tem a idade de {aluno.idade} e {aluno2.idade} anos, suas matriculas são {aluno.matricula} e {aluno2.matricula}");
            Console.ReadLine();
        }
    }
}