using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcCursosPOO
{
    public class Professor 
    {
        public string nome { get; set; }
        public string disciplina;

        public Professor(string nomeP, string disciplinaP)
        {
            this.nome = nomeP;
            this.disciplina = disciplinaP;
        }
    }
}
