using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class JeuEchec
    {
        private bool[,] chessBoard;
        private int chessBoardSize;

        public JeuEchec(int chessBoardSize)
        {
            this.chessBoardSize = chessBoardSize;
            this.chessBoard = new bool[chessBoardSize,chessBoardSize];
        }


    }
}
