using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Prog_Orientada_Objeto
{
    class Professor : Pessoa
    {

        private double _valorHora;

        public List<Aluno> alunos = new List<Aluno>();

        private Departamento departamento = new Departamento();

        public Departamento setDepartamento
        {
            get => departamento;
            set => departamento = value;
        }

        public double ValorHora
        {
            get => _valorHora;

            set => _valorHora = value;
        }


        private int _tipo;
        public int Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }


        private int _bonus;
        public int Bonus
        {
            get => _bonus;
            set => _bonus = value;
        }


        public void imprimir()
        {
            WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Presença: {0}", this.ResponderPresenca());

            WriteLine("\n---------------------------------------------------------\n");
        }

        public string ResponderPresenca()
        {
            return "Bateu ponto hoje!";
        }

        public double CalcularSalario(int horas)
        {
            return this.ValorHora * horas;
        }

        public double CalcularSalario(int horas, double bonificacao)
        {
            double valor = this.ValorHora * horas;
            double pct = bonificacao / 100;
            return valor + (valor * pct);

        }

        public double CalcularSalarioFinal(int horas)
        {

            if (this.Tipo == 1)
            {
                return this.CalcularSalario(horas);
            }
            else
            {
                var bonus = this.Bonus;
                return this.CalcularSalario(horas, bonus);
            }
        }

        public void ImprimirAlunos()
        {
            foreach (Aluno aluno in this.alunos)
            {
                WriteLine("Aluno: {0} professor {1}", aluno.getNome(), this.getNome());
            }
            WriteLine("\n---------------------------------------------------------\n");
        }

        public void addAluno(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }

    }
}
