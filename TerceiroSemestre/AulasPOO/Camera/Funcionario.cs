using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameras
{
    public abstract class Funcionario : Pessoas
    {
        public string nome { get; set; }

        public Funcionario(string nome)
        {
            this.nome = nome;
        }

    }
}
