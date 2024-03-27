
namespace tabuleiro {
    internal class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qtdMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca( Cor cor, Tabuleiro tab) {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this .qtdMovimentos = 0;
        }
        public void IncrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
    }
}
