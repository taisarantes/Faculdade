using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeSupermercado
{
    public class SistemaCaixa
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Funcionario> funcionarios = new List<Funcionario>();
        public List<Produto> carrinho = new List<Produto>();
        public float TotalCompra = 0;

        public SistemaCaixa()
        {
            produtos.Add(new ProdutoKg("mamão", 19.90F));
            produtos.Add(new Produto("Fralda", 100.00F));
            produtos.Add(new Produto("Skol", 1.79F));
            produtos.Add(new ProdutoKg("Carne de 2", 39.99F));

            funcionarios.Add(new Caixa("Caixa"));
            funcionarios.Add(new Gerente("Gerente"));

        }

        public void AdicionarCarrinho(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void AdicionarCarrinho(ProdutoKg produto)
        {
            carrinho.Add((Produto)produto);
        }

        public void RemoverCarrinho(int indice)
        {
            carrinho.RemoveAt(indice);
        }

    }
}
