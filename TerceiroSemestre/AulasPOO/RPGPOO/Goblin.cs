using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Goblin : Monstro
    {
        public Goblin(string nome) : base(nome)
        {
            this.status = new Status(60, 50, 1000);
        }

        public void Atacar(Heroi heroi)
        {
            Console.WriteLine($"{this.nome}: Goblin atacou o {heroi.nome}");
            heroi.Defender(this.status.forca);
        }
    }
}
