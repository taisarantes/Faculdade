using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Automovel : Veiculo
    {
        public string tipo { get; set; }
        public string propriedades { get; set; }

        public Automovel(string nome, string marca, string cor, double valor, string tipo, string propriedades) : base(nome, marca, cor, valor)
        {
            this.tipo = tipo;
            this.propriedades = propriedades;
        }

        public override string Descricao()
        {
            return $"{this.nome} - R${this.calculoValorTotal()}. Tipo: {this.tipo}, propriedades: {this.propriedades}";
        }
    }
}
