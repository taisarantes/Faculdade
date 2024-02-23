using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public class Ouro : Cliente
    {
        public Ouro(string nome) : base(nome)
        {

        }

        public override double Desconto()
        {
            return 0.1;
        }

    }
}
