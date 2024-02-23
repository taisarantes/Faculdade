using System;
using System.Collections.Generic;

namespace GerenciamentoDeCursos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando professores
            ProfessorEfetivo professorEfetivo1 = new ProfessorEfetivo("João Silva", "Matemática");
            ProfessorHorista professorHorista1 = new ProfessorHorista("Maria Souza", "História", 50.0);

            // Criando disciplinas
            Disciplina disciplina1 = new Disciplina("Cálculo I", professorEfetivo1);
            Disciplina disciplina2 = new Disciplina("História do Brasil", professorHorista1);

            // Criando cursos
            Curso curso1 = new Curso("Engenharia Civil", new List<Disciplina> { disciplina1 });
            Curso curso2 = new Curso("História", new List<Disciplina> { disciplina2 });

            // Criando alunos
            AlunoGraduacao alunoGraduacao1 = new AlunoGraduacao("Ana Silva");
            AlunoPosGraduacao alunoPosGraduacao1 = new AlunoPosGraduacao("Pedro Souza");

            // Matriculando alunos nos cursos
            curso1.MatricularAluno(alunoGraduacao1);
            curso2.MatricularAluno(alunoPosGraduacao1);

            // Imprimindo informações dos cursos
            Console.WriteLine("Curso: " + curso1.Nome);
            Console.WriteLine("Alunos matriculados: " + curso1.Alunos.Count);
            Console.WriteLine("Disciplinas: ");
            foreach (Disciplina disciplina in curso1.Disciplinas)
            {
                Console.WriteLine("- " + disciplina.Nome + " (Professor: " + disciplina.Professor.Nome + ")");
            }
            Console.WriteLine("Professores: ");
            foreach (Disciplina disciplina in curso1.Disciplinas)
            {
                Console.WriteLine("- " + disciplina.Professor.Nome);
            }
            Console.WriteLine();
            Console.WriteLine("Curso: " + curso2.Nome);
            Console.WriteLine("Alunos matriculados: " + curso2.Alunos.Count);
            Console.WriteLine("Disciplinas: ");
            foreach (Disciplina disciplina in curso2.Disciplinas)
            {
                Console.WriteLine("- " + disciplina.Nome + " (Professor: " + disciplina.Professor.Nome + ")");
            }
            Console.WriteLine("Professores: ");
            foreach (Disciplina disciplina in curso2.Disciplinas)
            {
                Console.WriteLine("- " + disciplina.Professor.Nome);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    // Classe Aluno
    abstract class Aluno
    {
        public string Nome { get; set; }
        public Aluno(string nome)
        {
            Nome = nome;
        }
    }

    // Classe AlunoGraduacao
    class AlunoGraduacao : Aluno
    {
        public AlunoGraduacao(string nome) : base(nome)
        {
        }
    }

    // Classe AlunoPosGraduacao
    class AlunoPosGraduacao : Aluno
    {
        public AlunoPosGraduacao(string nome) : base(nome)
        {
        }
    }

    // Classe Professor
    abstract class Professor
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public Professor(string nome, string disciplina)
        {
            Nome
= nome;
            Disciplina = disciplina;
        }
    }

    // Classe ProfessorEfetivo
    class ProfessorEfetivo : Professor
    {
        public ProfessorEfetivo(string nome, string disciplina) : base(nome, disciplina)
        {
        }
    }

    // Classe ProfessorHorista
    class ProfessorHorista : Professor
    {
        public double ValorHora { get; set; }
        public ProfessorHorista(string nome, string disciplina, double valorHora) : base(nome, disciplina)
        {
            ValorHora = valorHora;
        }
    }

    // Classe Disciplina
    class Disciplina
    {
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public Disciplina(string nome, Professor professor)
        {
            Nome = nome;
            Professor = professor;
        }
    }

    // Classe Curso
    class Curso
    {
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Curso(string nome, List<Disciplina> disciplinas)
        {
            Nome = nome;
            Disciplinas = disciplinas;
            Alunos = new List<Aluno>();
        }

        public void MatricularAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
    }