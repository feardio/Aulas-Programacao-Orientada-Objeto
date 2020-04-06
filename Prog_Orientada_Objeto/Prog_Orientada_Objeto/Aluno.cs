using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Prog_Orientada_Objeto
{
    class Aluno : Pessoa
    {
        
        private int matricula;
        private bool presente;

        public List<Professor> professores = new List<Professor>();


        public int Matricula
        {
            get => matricula;
            set => matricula = value > 100 ? throw new Exception("Matricula não pode ser maior do que 100") : value;
        }

        public bool Presente
        {
            get => presente;
            set => presente = value;
        }



        public void imprimir()
        {
           WriteLine("Nome: {0}", this.getNome());
            WriteLine("Idade: {0}", this.getIdade());
            WriteLine("Matricula: {0}", this.Matricula);
            WriteLine("Presente: {0}", this.Presente);
            WriteLine("Presença: {0}", this.ResponderPresenca());

            WriteLine("\n---------------------------------------------------------\n");
        }

        public string ResponderPresenca()
        {
            
            if (this.Presente)
            {
                return "Está presente!";
            }
            else
            {
                return "Ausente!";
            }

           

        }

        public void AdicionarProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }
    }
}
