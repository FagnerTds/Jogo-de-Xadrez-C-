﻿using System;
using System.Threading.Channels;
using tabuleiro;

namespace Xadrez {
    internal class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(tab);
        }
        
    }
}
