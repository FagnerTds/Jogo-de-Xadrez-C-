using System;
using xadrez;
using tabuleiro;


namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.Tabuleiro);

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.Tabuleiro);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem =Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao desino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, desino);
                }



            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);

            }



        }

    }
}
