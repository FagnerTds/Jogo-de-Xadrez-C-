using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor,Tabuleiro tab) : base(cor,tab) { }

        public override string ToString()
        {
            return "R";
        }
    }
    
}
