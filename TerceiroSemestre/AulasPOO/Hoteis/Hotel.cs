using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteis
{
    public class Hotel
    {
        public List<Quarto> quartos = new List<Quarto>();
        public Hotel() 
        {
            quartos.Add(new Single("S01", 100));
            quartos.Add(new Single("S02", 100));
            quartos.Add(new Single("S03", 100));
            quartos.Add(new Double("D04", 150));
            quartos.Add(new Double("D05", 150));
            quartos.Add(new Presidencial("P06", 1000));
        }

        public List<Quarto> QuartosVagos()
        {
            List<Quarto> quartosVagos = new List<Quarto>();
            foreach(Quarto quarto in quartos)
            {
                if(quarto.cliente == null)
                {
                    quartosVagos.Add(quarto);
                }
            }

            return quartosVagos;
        }
    }
}
