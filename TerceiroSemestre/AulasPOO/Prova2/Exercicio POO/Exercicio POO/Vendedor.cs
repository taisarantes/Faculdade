using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Vendedor : Funcionario, IAcesso
    {
        public Vendedor(string nome) : base(nome) 
        {

        }
    }
}
