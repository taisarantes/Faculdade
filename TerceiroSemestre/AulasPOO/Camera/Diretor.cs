using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameras
{
    public class Diretor : Funcionario, IAcesso
    {
        public Diretor(string nome) : base(nome) { }

        public string Nome()
        {
            return this.nome;
        }
    }
}
