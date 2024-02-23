using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGPOO
{
    internal class Dragao : Monstro
    {
        public Dragao(string nome) : base(nome) {
            this.status = new Status(50, 50, 1);
        }

        public void Atacar(Heroi heroi)
        {
            Console.WriteLine($"{this.nome}: Dragão atacou o {heroi.nome}");
            heroi.Defender(this.status.forca);
        }



    }
}
