using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Arqueiro : Heroi
    {
        private int flechas;

        public Arqueiro(int flechas, string nome): base(nome)
        {
            this.flechas = flechas;
            this.status = new Status(80, 30, 1000);
        }

        public void Atacar(Monstro monstro)
        {
            if(this.flechas > 0)
            {
                Console.WriteLine($"{this.nome}: Arqueiro atacou o {monstro.nome}");
                monstro.Defender(this.status.forca);
                this.flechas--;
            }
            else
            {
                Console.WriteLine($"{this.nome}: Não tem flecha suficiente");
            }
        }

    }
}
