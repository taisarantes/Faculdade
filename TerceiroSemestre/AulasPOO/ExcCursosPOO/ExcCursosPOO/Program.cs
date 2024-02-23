using System;
using System.Collections.Generic;

namespace ExcCursosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor thyago = new Professor("Thyago Quintas", "Introdução à Computação");
            Professor thiago = new Professor("Thiago Claro", "Algoritmos");
            Professor abenza = new Professor("Fabio Abenza", "Desenvolvimento Web");

            Disciplina introComp = new Disciplina("Introdução à Computação", thyago);
            Disciplina algoritmos = new Disciplina("Algoritmos", thiago);
            Disciplina desenvWeb = new Disciplina("Introdução à Computação", thyago);

            Curso bcc = new Curso("Ciências da Computação", new List<Disciplina>() { introComp, algoritmos, desenvWeb });

            Aluno aluno1 = new Aluno("Tais");
            Aluno aluno2 = new Aluno("Arthur");
            Aluno aluno3 = new Aluno("Davi");

            bcc.matricularAluno(aluno1);
            bcc.matricularAluno(aluno2);
            bcc.matricularAluno(aluno3);

            Console.WriteLine(bcc.nome + "(" + ((bcc.alunos.Count) + 97) + ")");
            foreach(Disciplina disciplina in bcc.disciplinas)
            {
                Console.WriteLine("- " + disciplina.nome + "- " + disciplina.professor.nome);
            }
        }
    }
}