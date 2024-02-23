using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeElevador
{
    public class Elevador
    {
        public int andarAtual = 0;
        public int totalAndares = 21;
        public float pesoMax = 100;
        public float pesoAtual = 0;
        public bool porta = true; //0: aberta | 1: fechada
        public List<Pessoa> pessoas = new List<Pessoa>();

        public Elevador()
        {

        }

        public void Subir(int andar)
        {
            this.porta = true;
            Console.WriteLine("Fechando a porta");
            while (this.andarAtual < andar)
            {
                this.andarAtual++;
                Console.WriteLine($"O elevador subiu para o andar {andarAtual}");
            }
        }

        public void Descer(int andar)
        {
            this.porta = true;
            Console.WriteLine("Fechando a porta");
            while (this.andarAtual > andar)
            {
                this.andarAtual--;
                Console.WriteLine($"O elevador desceu para o andar {andarAtual}");
            }
        }

        public void Movimento(int andar)
        {
            if(this.pesoAtual > this.pesoMax)
            {
                Console.WriteLine("Pesso máximo atigido");
                return;
            }

            if(andar > this.andarAtual)
            {
                this.Subir(andar);
            }
            else if(andar < this.andarAtual)
            {
                this.Descer(andar);
            }
            if (this.porta) //SE A PORTA ESTÁ FECHADA
            {
                this.porta = false;
                Console.WriteLine("Elevador abriu a porta");
            }
        }

    }
}
