using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDeSupermercado
{
    public class Patins : Funcionario, iAcesso
    {
        public Patins(string nome) : base(nome) 
        { 
        }
    
    }
}
