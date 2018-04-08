using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec_et_Math
{
    class JeuEchec
    {
        public int[,] chessBoard;
        private int chessBoardSize;

        public JeuEchec(int chessBoardSize)
        {
            this.chessBoardSize = chessBoardSize;
            chessBoard = new int[chessBoardSize,chessBoardSize];
        }

        public Boolean toPlaceOrNotToPlace(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1) return false;
            }
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (i = row, j = col; j >= 0 && i < chessBoardSize; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }


        public Boolean chessBoardSolver(int col)
        {
         
            if (col >= chessBoardSize) return true;
            for (int i = 0; i < chessBoardSize; i++)
            {
                if (toPlaceOrNotToPlace(this.chessBoard, i, col))
                {
                    this.chessBoard[i, col] = 1;
                    if (chessBoardSolver(col + 1)) return true;
                    this.chessBoard[i, col] = 0;
                }
            }
            return false;
        }
    }
}
