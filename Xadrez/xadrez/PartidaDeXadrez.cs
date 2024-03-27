using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.colocarPeca(p, destino);

        }
        private void ColocarPecas()
        {
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 1).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('c', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('e', 2).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('e', 1).toPosicao());
            Tabuleiro.colocarPeca(new Rei(Cor.Branca, Tabuleiro), new PosicaoXadrez('d', 1).toPosicao());

            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('c', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('c', 8).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('d', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('e', 7).toPosicao());
            Tabuleiro.colocarPeca(new Torre(Cor.Preta, Tabuleiro), new PosicaoXadrez('e', 8).toPosicao());
            Tabuleiro.colocarPeca(new Rei(Cor.Preta, Tabuleiro), new PosicaoXadrez('d', 8).toPosicao());




        }
    }
}
