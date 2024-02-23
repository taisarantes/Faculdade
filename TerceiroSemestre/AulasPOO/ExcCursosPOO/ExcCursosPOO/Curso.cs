using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Curso
    {
        public string nome { get; set; }
        public List<Disciplina> disciplinas { get; set; }
        public List<Aluno> alunos { get; set; }

        public Curso(string nomeC, List<Disciplina> disciplinasC) 
        {
            this.nome = nomeC;
            this.disciplinas = disciplinasC;
            this.alunos = new List<Aluno>();
        }

        public void matricularAluno(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }
    }
}
