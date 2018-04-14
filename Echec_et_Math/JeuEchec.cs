using System;

namespace Echec_et_Math
{
    class JeuEchec
    {
        public int[,] chessBoard;
        private int chessBoardSize;
        public int[] solution;

        public JeuEchec(int chessBoardSize)
        {
            this.chessBoardSize = chessBoardSize;
            chessBoard = new int[chessBoardSize,chessBoardSize];
            this.solution = new int[chessBoardSize];
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
            if (col >= chessBoardSize)
            {
                for (int i = 0; i < chessBoardSize; i++)
                {
                    for (int j = 0; j < chessBoardSize; j++)
                    {
                        if(this.chessBoard[i,j]==1)
                        {
                            this.solution[i] = j;
                        }
                    }
                }
                //Form1.UI.addSolution2comboBoxSolutions(solution);
                return true;
            }
            for (int i = 0; i < chessBoardSize; i++)
            {
                if (toPlaceOrNotToPlace(this.chessBoard, i, col))
                {
                    this.chessBoard[i, col] = 1;
                    if (chessBoardSolver(col + 1))
                    {
                        return true;
                    }
                    this.chessBoard[i, col] = 0;
                }
            }
            return false;
        }
    }
}
