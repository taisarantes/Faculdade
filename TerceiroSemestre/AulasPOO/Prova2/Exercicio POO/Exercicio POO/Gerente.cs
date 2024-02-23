using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Gerente : Funcionario, IAcesso
    {
        public Gerente(string nome) : base(nome) 
        {

        }

    }
}
