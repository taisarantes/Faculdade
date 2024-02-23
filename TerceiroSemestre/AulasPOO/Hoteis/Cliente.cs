using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public abstract class Cliente
    {
        public string nome { get;set; }

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        public virtual double Desconto()
        {
            return 0;
        }

    }
}
