using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('b', 2);

            Console.WriteLine(pos);

            Console.Write(pos.toPosicao());
        }
    }
}
