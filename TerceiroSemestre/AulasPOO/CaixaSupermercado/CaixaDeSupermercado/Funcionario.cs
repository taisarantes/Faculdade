using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeSupermercado
{
    public abstract class Funcionario
    {
        public string nome { get; set; }
        public Funcionario(string nome)
        {
            this.nome = nome;
        }
    }
}
