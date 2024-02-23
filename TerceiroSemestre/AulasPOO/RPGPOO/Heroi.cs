using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Heroi
    {
        public string nome { get; private set; }
        protected Status status { get; set; }

        public Heroi(string nome)
        {
            this.nome = nome;
        }

        public virtual void Defender(int pontosDeAtaque)
        {
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
