﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPOO
{
    public class Status
    {
        public int forca { get; private set; }
        public int defesa { get; private set; }
        public int vida { get; private set; }

        public Status(int forca, int defesa, int vida) { 
            this.forca = forca;
            this.defesa = defesa;
            this.vida = vida;
        }

        public void setVida(int vida)
        {
            this.vida -= vida;
            if (this.vida < 0)
                this.vida = 0;
        }

    }
}
