﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro {
    internal class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qtdMovimentos { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab) {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this .qtdMovimentos = 0;
        }
    }
}