using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; protected set; }

        public int getMovements { get; protected set; }
        public Tabuleiro tab =  { get; protected set;}
    }
}
