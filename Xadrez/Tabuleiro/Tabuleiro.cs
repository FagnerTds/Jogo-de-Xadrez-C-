using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tabuleiro {
    internal class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }
        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }
        public void colocarPeca(Peca p, Posicao posicao)
        {
            if (existePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição");
            pecas[posicao.Linha,posicao.Coluna] = p;
            p.posicao = posicao;
        }
        public bool posicaoValida(Posicao posicao)
        {
            if(posicao.Linha < 0 || posicao.Linha>linhas || posicao.Coluna<0 || posicao.Coluna>colunas)
                return false;
            return true;
        }

        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
                throw new Exception("Posição inválida");    
        }
    }
}
