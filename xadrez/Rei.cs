using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor)
        {            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
