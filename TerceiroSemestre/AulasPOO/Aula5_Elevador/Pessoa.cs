using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeElevador
{
    public class Pessoa
    {
        public string nome;
        public float peso;
        public int andarAtual;
        public int andarDesejado;

        public Pessoa(string nome, float peso, int andarAtual, int andarDesejado)
        {
            this.nome = nome;
            this.peso = peso;
            this.andarAtual = andarAtual;
            this.andarDesejado = andarDesejado;
        }

        public void Chamar(Elevador elevador)
        {
            Console.WriteLine($"{this.nome}: Chamou o elevador para o andar {this.andarAtual}");
            elevador.Movimento(this.andarAtual);
        }

        public void Entrar(Elevador elevador)
        {
            Console.WriteLine($"{this.nome}: entrou no elevador");
            elevador.pessoas.Add(this);
            elevador.pesoAtual += this.peso;
        }

        public void Sair(Elevador elevador)
        {
            Console.WriteLine($"{this.nome}: saiu do elevador");
            elevador.pessoas.Remove(this);
            elevador.pesoAtual -= this.peso;
        }

        public void EscolheAndar(Elevador elevador)
        {
            Console.WriteLine($"{this.nome}: Escolheu o o andar {this.andarDesejado}");
            elevador.Movimento(this.andarDesejado);
        }
    }
}
