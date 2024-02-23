using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public class Presidencial : Quarto, IFrigobar
    {
        public List<Produto> frigobar { get; } = new List<Produto>();
        public Presidencial(string numero, double preco) : base(numero, preco) 
        {
            frigobar.Add(new Bebida("Coca-cola Lata", 10.50));
            frigobar.Add(new Bebida("Coca-cola Lata", 10.50));
            frigobar.Add(new Bebida("Guaraná Lata", 9.50));
            frigobar.Add(new Bebida("Skol Lata", 5.50));
            frigobar.Add(new Alimento("Doritos 200g", 19.50));
            frigobar.Add(new Alimento("Ruffles 50g", 19.50));
            frigobar.Add(new Alimento("Chocolate 50g", 5.50));
        }
        


    }
}
