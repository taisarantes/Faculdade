using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeSupermercado
{
    public class ProdutoKg : Produto
    {

        public float kg { get; set; }
        public ProdutoKg(string nome , float valor) : base(nome, valor) 
        {
            
        }

        public ProdutoKg(string nome, float valor, float kg) : base(nome, valor)
        {
            this.kg= kg;
        }

        public override float Preco()
        {
            return kg * valor;
        }

        public override string Descricao()
        {
            return $"{this.nome}(R$ {this.valor}) - R${this.Preco()}";
        }
    }


}
