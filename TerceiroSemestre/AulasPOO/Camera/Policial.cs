using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cameras
{
    public class Policial : IAcesso
    {
        public string nome { get; set; }

        public Policial(string nome)
        {
            this.nome = nome;
        }

        public string Nome()
        {
            return this.nome;
        }
    }
}
