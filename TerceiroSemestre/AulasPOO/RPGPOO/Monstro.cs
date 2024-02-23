using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Monstro
    {
        protected Status status;
        public string nome { get; private set; }


        public Monstro(string nome)
        {
            this.nome = nome;
            this.status = new Status(50, 50, 1);
        }

        public void Defender(int pontosDeAtaque)
        {
            if(this.status.vida == 0)
            {
                throw new Exception("Não tem vida");
            }

            if (this.status.defesa <= pontosDeAtaque)
            {
                int vida = pontosDeAtaque - this.status.defesa;
                this.status.setVida(vida);
                Console.WriteLine($"{this.nome}: perdeu {vida} pontos de vida");
            }
            else
            {
                Console.WriteLine($"{this.nome}: Defendeu o seu ataque");
            }
        }

    }
}
