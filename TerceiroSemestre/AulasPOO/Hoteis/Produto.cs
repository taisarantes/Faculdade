using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public abstract class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

    }
}
