using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeSupermercado
{
    public class Gerente : Funcionario, iAcesso
    {
        public Gerente(string nome) : base(nome)
        {

        }
    }
}
