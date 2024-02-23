using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Disciplina 
    {
        public string nome { get; set; }
        public Professor professor { get; set; }

        public Disciplina(string nomeD, Professor professorD) 
        {
            this.nome = nomeD;
            this.professor = professorD;
        }
    }
}
