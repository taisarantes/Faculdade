using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Veiculo
    {
        public string nome { get; set; }
        public string marca { get; set; }
        public string cor { get; set; }
        public double valor { get; set; }
        public double valorTotal { get; set; }


        public Veiculo(string nome, string marca, string cor, double valor)
        {
            this.nome = nome;
            this.marca = marca;
            this.cor = cor;
            this.valor = valor;
        }

        public double calculoValorTotal()
        {
            valor += valor*(0.15f);
            valorTotal = valor;

            return valorTotal;
        }

        public virtual string Descricao()
        {
            return $"{this.nome} - R${this.calculoValorTotal()}";
        }
    }
}
