using System;

namespace FourInRowLogic
{
    public class GameBoard
    {
        public enum ePlayersCoins
        {
            X = 1,
            O
        }

        private readonly int r_NumberOfRows;
        private readonly int r_NumberOfColumns;
        private readonly ePlayersCoins[,] r_BoardMatrix;

        public GameBoard(int i_NumberOfRowsOfBoard, int i_NumberOfColumnOfBoard)
        {
            r_NumberOfRows = i_NumberOfRowsOfBoard;
            r_NumberOfColumns = i_NumberOfColumnOfBoard;
            r_BoardMatrix = new ePlayersCoins[r_NumberOfColumns, r_NumberOfRows];
        }

        public int NumberOfRows
        {
            get { return r_NumberOfRows; }
        }

        public int NumberOfColumns
        {
            get { return r_NumberOfColumns; }
        }

        public ePlayersCoins[,] BoardMatrix
        {
            get { return r_BoardMatrix; }
        }

        public void AddValueToColumn(int i_ColumnShouldAddTo, int i_RowShouldAddTo, ePlayersCoins i_PlayerSymbol)
        {
            r_BoardMatrix[i_ColumnShouldAddTo, i_RowShouldAddTo] = i_PlayerSymbol;
        }

        public void ClearBoard()
        {
            Array.Clear(r_BoardMatrix, 0, r_BoardMatrix.Length);
        }
    }
}