using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna=coluna;
            Linha=linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(Coluna-'a',8-Linha);
        }
        public override string ToString()
        {
            return "" + Coluna+Linha;
        }
    }
}
