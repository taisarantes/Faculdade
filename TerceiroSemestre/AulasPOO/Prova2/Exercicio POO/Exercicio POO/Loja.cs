using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Loja
    {
        public List<Veiculo> listaVeiculos = new List<Veiculo>();
        public List<Funcionario> listaFuncionarios = new List<Funcionario>();

        public Loja()
        {
             
        }

        public void catalogo(List<Veiculo> veiculos)
        {
            foreach(var veiculo in veiculos)
            {
                Console.WriteLine($"Nome: {veiculo.nome}");
                Console.WriteLine($"Marca: {veiculo.marca}");
                Console.WriteLine($"Cor: {veiculo.cor}");
                Console.WriteLine($"Valor: R${veiculo.valor}");
                Console.WriteLine($"Valor Total: R${veiculo.calculoValorTotal()}");
            }
        }

        public void adicionarVeiculo(Veiculo veiculo, Funcionario funcionario)
        {
            if(funcionario is Gerente)
            {
                listaVeiculos.Add(veiculo);
            }
            else
            {
                Console.Error.WriteLine("Erro! Você não tem permissão para adiconar esse produto.");
            }
        }

        public void venderVeiculo(Veiculo veiculo, Funcionario funcionario)
        {
            if(funcionario is IAcesso)
            {
                listaVeiculos.Remove(veiculo);
            }
            else
            {
                Console.WriteLine("Erro! Você não tem permissão para vender esse produto.");
            }
        }

        public void listarVeiculos(List<Veiculo> veiculos)
        {
            foreach (Veiculo veiculo in veiculos) { 
                Console.WriteLine(veiculo.nome); 
            }
        }
    }
}
