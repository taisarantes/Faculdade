using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameras
{
    public class Analista : Funcionario, IAcesso
    {
        public Analista(string nome) : base(nome)
        {

        }

        public string Nome()
        {
            return this.nome;
        }
    }
}
