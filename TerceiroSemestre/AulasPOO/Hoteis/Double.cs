using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public class Double : Quarto, IFrigobar
    {
        public List<Produto> frigobar { get; } = new List<Produto>();

        public Double(string numero, double preco) : base(numero, preco) 
        {
            frigobar.Add(new Bebida("Coca-cola Lata", 10.50));
            frigobar.Add(new Bebida("Coca-cola Lata", 10.50));
            frigobar.Add(new Bebida("Guaraná Lata", 9.50));
            frigobar.Add(new Alimento("Doritos 200g", 19.50));
            frigobar.Add(new Alimento("Ruffles 50g", 19.50));
        }
    }
}
