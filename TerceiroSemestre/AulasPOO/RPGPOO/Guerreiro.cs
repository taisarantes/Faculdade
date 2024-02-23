using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Guerreiro : Heroi
    {

        public Guerreiro(string nome) : base(nome) 
        {
            this.status = new Status(100, 50, 1000);
        }

        public void Atacar(Monstro monstro)
        {
            try
            {
                Console.WriteLine($"{this.nome}: Guerreiro atacou o {monstro.nome}");
                monstro.Defender(this.status.forca);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{monstro.nome}: {e.Message}");
            }
            
        }

        public override void Defender(int pontosDeAtaque)
        {
            if (this.status.defesa <= pontosDeAtaque)
            {
                int vida = pontosDeAtaque - this.status.defesa;
                this.status.setVida(vida);
                Console.WriteLine($"{this.nome}: Guerreiro perdeu {vida} pontos de vida");
            }
            else
            {
                Console.WriteLine($"{this.nome}: Guerreiro defendeu o seu ataque");
            }
        }


    }
}
