using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public abstract class Quarto
    {
        public string numero { get; set; }
        public double preco { get; set; }
        public List<Produto> consumo = new List<Produto>();
        public Cliente cliente { get; set; }
        public static int QtdQuartos = 0;

        public Quarto(string numero, double preco)
        {
            this.numero = numero;
            this.preco = preco;
            QtdQuartos++;
        }

        public void Cosome(Produto produto)
        {
            this.consumo.Add(produto);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public double CalcularConta()
        {
            double total = 0;
            foreach(Produto produto in this.consumo)
            {
                total += produto.preco;
            }
            return total + ((1-cliente.Desconto()) * this.preco);
        }

    }
}
