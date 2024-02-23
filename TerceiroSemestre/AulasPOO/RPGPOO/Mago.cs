using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Mago : Heroi
    {
        private int mana;

        public Mago(int mana, string nome) : base(nome)
        {
            this.mana = mana;
            this.status = new Status(50, 50, 1000);
        }

        public void Atacar(Monstro monstro)
        {
            if (this.mana > 0)
            {
                Console.WriteLine($"{this.nome}: Mago atacou o {monstro.nome}");
                monstro.Defender(this.status.forca);
                this.mana -= 10;
            }
            else
            {
                Console.WriteLine($"{this.nome}: Não tem mana suficiente");
            }
        }
    }
}
