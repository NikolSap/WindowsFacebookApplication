using System;

namespace FourInRowLogic
{
    public delegate void FullColumnEventHandler(int i_ColumnNumber);

    public delegate void OnWinEventHandler(Player i_Winner);

    public delegate void OnFullBoardEventHandler();

    public delegate void OnInsertingCoinEventHandler(int i_RowNumber, int i_ColumnNumber, GameBoard.ePlayersCoins i_Coin);

    public class GameManager
    {
        private const int k_NumberOfCoinsForWinning = 4;
        private readonly int[] r_ArrayHighOfColumns;
        private readonly GameBoard r_GameBoard;
        private readonly Player r_Player1;
        private readonly Player r_Player2;
        private bool m_ItIsFirstPlayerTurn;
        private bool m_IsGameOver;

        public event FullColumnEventHandler ActionOnFullColumn;

        public event OnWinEventHandler ActionOnWin;

        public event OnInsertingCoinEventHandler ActionOnAddToMatrix;

        public event OnFullBoardEventHandler ActionOnFullBoard;

        public GameManager(int i_NumberOfRow, int i_NumberOfColumn, string i_Player1Name, string i_Player2Name)
        {
            this.r_ArrayHighOfColumns = new int[i_NumberOfColumn];
            this.r_GameBoard = new GameBoard(i_NumberOfRow, i_NumberOfColumn);
            this.r_Player1 = new Player(i_Player1Name, GameBoard.ePlayersCoins.X);
            this.r_Player2 = new Player(i_Player2Name, GameBoard.ePlayersCoins.O);
            this.m_ItIsFirstPlayerTurn = true;
            this.m_IsGameOver = false;
        }

        public Player Player1
        {
            get { return this.r_Player1; }
        }

        public Player Player2
        {
            get { return this.r_Player2; }
        }

        public GameBoard Board
        {
            get { return this.r_GameBoard; }
        }

        public bool IsGameOver
        {
            get { return this.m_IsGameOver; }
            set { this.m_IsGameOver = value; }
        }

        public void InitializeFoNewGame()
        {
            this.m_ItIsFirstPlayerTurn = true;

            this.Board.ClearBoard();
            initializeArrayHighOfColumns();
        }

        public void InsertCoin(int i_ColumnNumber)
        {
            addValueToColumn(i_ColumnNumber, this.m_ItIsFirstPlayerTurn ? this.Player1.PlayerShape : this.Player2.PlayerShape);

            if (isPlayerWon(i_ColumnNumber))
            {
                if (this.ActionOnWin != null)
                {
                    this.ActionOnWin.Invoke(this.m_ItIsFirstPlayerTurn ? this.Player1 : this.Player2);
                }
            }

            fullColumnAndBoardChecks(i_ColumnNumber);

            if (!m_IsGameOver)
            {
                this.m_ItIsFirstPlayerTurn = !this.m_ItIsFirstPlayerTurn;
            }
        }

        public void DoComputerTurn()
        {
            int computerColumnNumber = getColumnFromComputer();

            InsertCoin(computerColumnNumber);
        }

        private void addValueToColumn(int i_ColumnToInsert, GameBoard.ePlayersCoins i_UserSymbol)
        {
            this.r_GameBoard.AddValueToColumn(i_ColumnToInsert, this.r_GameBoard.NumberOfRows - this.r_ArrayHighOfColumns[i_ColumnToInsert] - 1, i_UserSymbol);
            this.r_ArrayHighOfColumns[i_ColumnToInsert]++;

            if (this.ActionOnAddToMatrix != null)
            {
                this.ActionOnAddToMatrix.Invoke(this.r_ArrayHighOfColumns[i_ColumnToInsert], i_ColumnToInsert, i_UserSymbol);
            }
        }

        private void initializeArrayHighOfColumns()
        {
            Array.Clear(this.r_ArrayHighOfColumns, 0, this.r_ArrayHighOfColumns.Length);
        }

        private bool isPlayerWon(int i_ColumnToInsert)
        {
            bool thereIsAWinner = isPlayerWonWithHorizontalRow(i_ColumnToInsert, this.r_GameBoard.NumberOfRows - this.r_ArrayHighOfColumns[i_ColumnToInsert])
                    || isPlayerWonWithVerticalRow(i_ColumnToInsert, this.r_GameBoard.NumberOfRows - this.r_ArrayHighOfColumns[i_ColumnToInsert])
                    || isPlayerWonWithDiagonalRow(i_ColumnToInsert, this.r_GameBoard.NumberOfRows - this.r_ArrayHighOfColumns[i_ColumnToInsert]);

            if (thereIsAWinner)
            {
                this.m_IsGameOver = true;
            }

            return thereIsAWinner;
        }

        private bool isColumnFull(int i_ChosenColumn)
        {
            return this.r_ArrayHighOfColumns[i_ChosenColumn] == this.r_GameBoard.NumberOfRows;
        }

        private bool isBoardFull()
        {
            bool isBoardFull = true;

            foreach (int highOfColumn in this.r_ArrayHighOfColumns)
            {
                if (highOfColumn < this.r_GameBoard.NumberOfRows)
                {
                    isBoardFull = false;
                }
            }

            if (isBoardFull)
            {
                this.m_IsGameOver = true;
            }

            return isBoardFull;
        }

        private void fullColumnAndBoardChecks(int i_ColumnNumber)
        {
            if (isColumnFull(i_ColumnNumber) && this.ActionOnFullColumn != null && !this.m_IsGameOver)
            {
                this.ActionOnFullColumn.Invoke(i_ColumnNumber);

                if (isBoardFull() && this.ActionOnFullBoard != null)
                {
                    this.ActionOnFullBoard.Invoke();
                }
            }
        }

        private bool isPlayerWonWithHorizontalRow(int i_LastColumnIndex, int i_LastRowIndex)
        {
            bool fourInRow;
            GameBoard.ePlayersCoins sign = this.r_GameBoard.BoardMatrix[i_LastColumnIndex, i_LastRowIndex];
            int counterForSign = 1;
            int colIndex = 1;

            while (i_LastColumnIndex - colIndex >= 0
                   && this.r_GameBoard.BoardMatrix[i_LastColumnIndex - colIndex, i_LastRowIndex] == sign)
            {
                counterForSign++;
                colIndex++;
            }

            colIndex = 1;

            while (i_LastColumnIndex + colIndex < this.r_GameBoard.NumberOfColumns
                   && this.r_GameBoard.BoardMatrix[i_LastColumnIndex + colIndex, i_LastRowIndex] == sign)
            {
                counterForSign++;
                colIndex++;
            }

            fourInRow = counterForSign >= k_NumberOfCoinsForWinning;

            return fourInRow;
        }

        private bool isPlayerWonWithVerticalRow(int i_LastColumnIndex, int i_LastRowIndex)
        {
            bool fourInRow = false;
            GameBoard.ePlayersCoins sign = this.r_GameBoard.BoardMatrix[i_LastColumnIndex, i_LastRowIndex];
            int counterForSign = 0;

            if (this.r_GameBoard.NumberOfRows - i_LastRowIndex >= 4)
            {
                while (!fourInRow && i_LastRowIndex + counterForSign + 1 < this.r_GameBoard.NumberOfRows
                                  && sign == this.r_GameBoard.BoardMatrix[i_LastColumnIndex, i_LastRowIndex + counterForSign + 1])
                {
                    counterForSign++;
                    fourInRow = counterForSign == k_NumberOfCoinsForWinning - 1;
                }
            }

            return fourInRow;
        }

        private bool isPlayerWonWithDowngradeRow(int i_LastColumnIndex, int i_LastRowIndex)
        {
            GameBoard.ePlayersCoins sign = this.r_GameBoard.BoardMatrix[i_LastColumnIndex, i_LastRowIndex];
            bool fourInRow;
            int counterForSign = 1;
            int index = 1;

            while (i_LastColumnIndex - index >= 0
                   && i_LastRowIndex - index >= 0
                   && this.r_GameBoard.BoardMatrix[i_LastColumnIndex - index, i_LastRowIndex - index] == sign)
            {
                index++;
                counterForSign++;
            }

            index = 1;

            while (i_LastColumnIndex + index < this.r_GameBoard.NumberOfColumns
                   && i_LastRowIndex + index < this.r_GameBoard.NumberOfRows
                   && this.r_GameBoard.BoardMatrix[i_LastColumnIndex + index, i_LastRowIndex + index] == sign)
            {
                index++;
                counterForSign++;
            }

            fourInRow = counterForSign >= k_NumberOfCoinsForWinning;

            return fourInRow;
        }

        private bool isPlayerWonWithUpgradeRow(int i_LastColumnIndex, int i_LastRowIndex)
        {
            GameBoard.ePlayersCoins sign = this.r_GameBoard.BoardMatrix[i_LastColumnIndex, i_LastRowIndex];
            bool fourInRow;
            int counterForSign = 1;
            int index = 1;

            while (i_LastColumnIndex - index >= 0
                   && i_LastRowIndex + index < this.r_GameBoard.NumberOfRows
                   && this.r_GameBoard.BoardMatrix[i_LastColumnIndex - index, i_LastRowIndex + index] == sign)
            {
                index++;
                counterForSign++;
            }

            index = 1;

            while (i_LastRowIndex - index >= 0
                   && i_LastColumnIndex + index < this.r_GameBoard.NumberOfColumns
                   && this.r_GameBoard.BoardMatrix[i_LastColumnIndex + index, i_LastRowIndex - index] == sign)
            {
                index++;
                counterForSign++;
            }

            fourInRow = counterForSign >= k_NumberOfCoinsForWinning;

            return fourInRow;
        }

        private bool isPlayerWonWithDiagonalRow(int i_LastColumnIndex, int i_LastRowIndex)
        {
            return isPlayerWonWithDowngradeRow(i_LastColumnIndex, i_LastRowIndex)
                   || isPlayerWonWithUpgradeRow(i_LastColumnIndex, i_LastRowIndex);
        }

        private int getColumnFromComputer()
        {
            Random randomComputerChoice = new Random();
            int actualColumn;

            do
            {
                actualColumn = randomComputerChoice.Next(0, this.r_ArrayHighOfColumns.Length);
            }
            while (isColumnFull(actualColumn));

            return actualColumn;
        }
    }
}