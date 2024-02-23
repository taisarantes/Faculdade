using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Aranha : Monstro
    {
        public Aranha(string nome) : base(nome)
        {
            this.status = new Status(30, 20, 1000);
        }

        public void Atacar(Heroi heroi)
        {
            Console.WriteLine($"{this.nome}: Aranha atacou o {heroi.nome}");
            heroi.Defender(this.status.forca);
        }
    }
}
