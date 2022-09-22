using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookCustomAppEngine;
using FourInRowLogic;

namespace FourInRowForms
{
    public class GameFormBoard : Form
    {
        private const int k_WidthOfColumnButton = 40;
        private const int k_HighOfMatrixButton = 40;
        private const int k_HighOfRowNumbersButtons = 30;
        private const int k_SpacesInMatrix = 16;
        private const int k_SpacesUpAndDownOfMatrix = 30;
        private const int k_SpaceInLeftAndRightOfMatrix = 60;

        private readonly Image r_Player2Image;
        private readonly int r_NumberOfRows;
        private readonly int r_NumberOfColumns;
        private readonly GameManager r_GameManager;
        private readonly bool r_PlayerAgainstComputer;

        private int m_WindowWidth;
        private int m_WindowHigh;

        private PictureBox m_Player1PictureBox;
        private PictureBox m_Player2PictureBox;
        private Label m_Player1Name;
        private Label m_Player2Name;
        private Label m_Player1Score;
        private Label m_Player2Score;
        private Button[] m_RowNumbersButtons;
        private Button[,] m_BoardMatrix;

        public GameFormBoard(int i_NumberOfRowsOfBoard, int i_NumberOfColumnOfBoard, string i_Player1Name, string i_SecondPlayerName, Image i_SecondPlayerPhoto, bool i_IsPlayer2Computer)
        {
            this.r_Player2Image = i_SecondPlayerPhoto;
            this.r_NumberOfRows = i_NumberOfRowsOfBoard;
            this.r_NumberOfColumns = i_NumberOfColumnOfBoard;
            this.AutoSize = true;
            this.r_PlayerAgainstComputer = i_IsPlayer2Computer;
            this.r_GameManager = new GameManager(this.r_NumberOfRows, this.r_NumberOfColumns, i_Player1Name, i_SecondPlayerName);
            this.initializeComponent();
        }

        private void initializeComponent()
        {
            this.MinimizeBox = false;
            this.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.m_WindowWidth = (this.r_NumberOfColumns * (k_SpacesInMatrix + k_WidthOfColumnButton)) + (2 * k_SpaceInLeftAndRightOfMatrix);
            this.m_WindowHigh = (this.r_NumberOfRows * (k_SpacesInMatrix + k_WidthOfColumnButton)) + (6 * k_SpacesUpAndDownOfMatrix);
            this.BackColor = Color.LightBlue;
            this.MinimizeBox = true;
            this.MaximizeBox = false;
            this.Text = "4 in a Raw !!";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(this.m_WindowWidth, this.m_WindowHigh);
            this.m_RowNumbersButtons = new Button[this.r_NumberOfColumns];
            this.m_BoardMatrix = new Button[this.r_NumberOfColumns, this.r_NumberOfRows];
            this.buildRowOfNumbers();
            this.buildMatrix();
            this.r_GameManager.ActionOnFullBoard += this.doOnTie;
            this.r_GameManager.ActionOnAddToMatrix += this.doOnInserting;
            this.r_GameManager.ActionOnWin += this.doOnWinning;
            this.r_GameManager.ActionOnFullColumn += this.doOnFullColumn;
            this.buildScoreStatus(this.Width);
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void buildRowOfNumbers()
        {
            for (int i = 0; i < this.r_NumberOfColumns; i++)
            {
                this.m_RowNumbersButtons[i] = new Button();
                this.m_RowNumbersButtons[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 177);
                this.m_RowNumbersButtons[i].ForeColor = Color.Black;
                this.m_RowNumbersButtons[i].FlatStyle = FlatStyle.Popup;
                this.m_RowNumbersButtons[i].Width = k_WidthOfColumnButton;
                this.m_RowNumbersButtons[i].Height = k_HighOfRowNumbersButtons;
                this.m_RowNumbersButtons[i].Text = (i + 1).ToString();
                this.m_RowNumbersButtons[i].Top = k_SpacesUpAndDownOfMatrix;
                this.m_RowNumbersButtons[i].Click += this.ButtonColumnNumber_OnClick;
                this.Controls.Add(this.m_RowNumbersButtons[i]);

                if (i == 0)
                {
                    this.m_RowNumbersButtons[i].Left = k_SpaceInLeftAndRightOfMatrix;
                }
                else
                {
                    this.m_RowNumbersButtons[i].Left = this.m_RowNumbersButtons[i - 1].Right + k_SpacesInMatrix;
                }
            }
        }

        private void buildMatrix()
        {
            for (int i = 0; i < this.r_NumberOfColumns; i++)
            {
                for (int j = 0; j < this.r_NumberOfRows; j++)
                {
                    this.m_BoardMatrix[i, j] = new Button();
                    this.m_BoardMatrix[i, j].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 177);
                    this.m_BoardMatrix[i, j].ForeColor = Color.Black;
                    this.m_BoardMatrix[i, j].FlatStyle = FlatStyle.Popup;
                    this.m_BoardMatrix[i, j].Width = k_WidthOfColumnButton;
                    this.m_BoardMatrix[i, j].Height = k_HighOfMatrixButton;
                    this.m_BoardMatrix[i, j].Enabled = false;

                    if (j == 0)
                    {
                        this.m_BoardMatrix[i, j].Top = this.m_RowNumbersButtons[i].Bottom + k_SpacesUpAndDownOfMatrix;
                    }
                    else
                    {
                        this.m_BoardMatrix[i, j].Top = this.m_BoardMatrix[i, j - 1].Bottom + k_SpacesInMatrix;
                    }

                    if (i == 0)
                    {
                        this.m_BoardMatrix[i, j].Left = k_SpaceInLeftAndRightOfMatrix;
                    }
                    else
                    {
                        this.m_BoardMatrix[i, j].Left = this.m_BoardMatrix[i - 1, j].Right + k_SpacesInMatrix;
                    }

                    this.Controls.Add(this.m_BoardMatrix[i, j]);
                }
            }
        }

        private void buildScoreStatus(int windowWidth)
        {
            this.m_Player1PictureBox = new PictureBox();
            this.m_Player1PictureBox.Image = FacebookAppEngine.Instance.GetUserProfilePicture();
            this.m_Player1PictureBox.Left = ((k_SpacesInMatrix * this.r_NumberOfColumns) / 2);
            this.m_Player1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_Player1PictureBox.Size = new Size(30, 30);
            this.m_Player1PictureBox.Top = this.m_BoardMatrix[this.r_NumberOfColumns - 1, this.r_NumberOfRows - 1].Bottom + k_SpacesUpAndDownOfMatrix;
            this.Controls.Add(this.m_Player1PictureBox);

            this.m_Player1Name = new Label();
            this.m_Player1Name.BackColor = Color.LightBlue;
            this.m_Player1Name.ForeColor = Color.Black;
            this.m_Player1Name.FlatStyle = FlatStyle.Popup;
            this.m_Player1Name.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 177);
            this.m_Player1Name.Text = this.r_GameManager.Player1.Name + ":";
            this.m_Player1Name.Left = this.m_Player1PictureBox.Right;
            this.m_Player1Name.AutoSize = true;
            this.m_Player1Name.Top = this.m_BoardMatrix[this.r_NumberOfColumns - 1, this.r_NumberOfRows - 1].Bottom + k_SpacesUpAndDownOfMatrix;
            this.Controls.Add(this.m_Player1Name);

            this.m_Player1Score = new Label();
            this.m_Player1Score.ForeColor = Color.Black;
            this.m_Player1Score.FlatStyle = FlatStyle.Popup;
            this.m_Player1Score.BackColor = Color.LightBlue;
            this.m_Player1Score.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 177);
            this.m_Player1Score.Text = this.r_GameManager.Player1.Score.ToString();
            this.m_Player1Score.Left = this.m_Player1Name.Right + 2;
            this.m_Player1Score.Top = this.m_Player1Name.Top;
            this.m_Player1Score.AutoSize = true;
            this.Controls.Add(this.m_Player1Score);

            this.m_Player2PictureBox = new PictureBox();

            if (this.r_GameManager.Player2.Name == "Computer")
            {
                this.m_Player2PictureBox.Image = BasicFacebookFeatures.Properties.Resources.Generic_profile_photo;
            }
            else
            {
                this.m_Player2PictureBox.Image = this.r_Player2Image;
            }

            this.m_Player2PictureBox.Left = (this.m_Player1Score.Right + (k_SpacesInMatrix * this.r_NumberOfColumns)/4) ;
            this.m_Player2PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_Player2PictureBox.Size = new Size(30, 30);
            this.m_Player2PictureBox.Top = this.m_BoardMatrix[this.r_NumberOfColumns - 1, this.r_NumberOfRows - 1].Bottom + k_SpacesUpAndDownOfMatrix;
            this.Controls.Add(this.m_Player2PictureBox);

            this.m_Player2Name = new Label();
            this.m_Player2Name.ForeColor = Color.Black;
            this.m_Player2Name.FlatStyle = FlatStyle.Popup;
            this.m_Player2Name.BackColor = Color.LightBlue;
            this.m_Player2Name.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 177);
            this.m_Player2Name.Left = this.m_Player2PictureBox.Right + 3;
            this.m_Player2Name.Top = this.m_Player1Name.Top;
            this.m_Player2Name.Text = this.r_GameManager.Player2.Name + ":";
            this.m_Player2Name.AutoSize = true;
            this.Controls.Add(this.m_Player2Name);

            this.m_Player2Score = new Label();
            this.m_Player2Score.ForeColor = Color.Black;
            this.m_Player2Score.FlatStyle = FlatStyle.Popup;
            this.m_Player2Score.BackColor = Color.LightBlue;
            this.m_Player2Score.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 177);
            this.m_Player2Score.Text = this.r_GameManager.Player2.Score.ToString();
            this.m_Player2Score.Left = this.m_Player2Name.Right + 2;
            this.m_Player2Score.Top = this.m_Player1Name.Top;
            this.m_Player2Score.AutoSize = true;
            this.Controls.Add(this.m_Player2Score);
        }

        private void updateScoreLabel()
        {
            this.m_Player1Score.Text = this.r_GameManager.Player1.Score.ToString();
            this.m_Player2Score.Text = this.r_GameManager.Player2.Score.ToString();
        }

        private void clearFrontMatrixBoard()
        {
            for (int i = 0; i < this.r_NumberOfColumns; i++)
            {
                for (int j = 0; j < this.r_NumberOfRows; j++)
                {
                    this.m_BoardMatrix[i, j].ResetText();
                }

                this.m_RowNumbersButtons[i].Enabled = true;
            }
        }

        private void initializeBackAndFront()
        {
            this.clearFrontMatrixBoard();
            this.r_GameManager.InitializeFoNewGame();
        }

        private void ButtonColumnNumber_OnClick(object sender, EventArgs e)
        {
            int columnNumber;

            if (sender is Button)
            {
                int.TryParse(((Button)sender).Text, out columnNumber);
                columnNumber--;
                this.r_GameManager.InsertCoin(columnNumber);

                if (this.r_PlayerAgainstComputer && !this.r_GameManager.IsGameOver)
                {
                    this.r_GameManager.DoComputerTurn();
                }

                if (this.r_GameManager.IsGameOver)
                {
                    this.r_GameManager.IsGameOver = false;
                }
            }
        }

        private void doOnWinning(Player i_Winner)
        {
            StringBuilder winMessage = new StringBuilder();

            i_Winner.Score++;
            this.updateScoreLabel();
            winMessage.AppendFormat("{0} Won!!", i_Winner.Name);
            winMessage.AppendLine();
            winMessage.Append("Another Round?");
            DialogResult gameEndWithWinMessage = MessageBox.Show(winMessage.ToString(), "A Win!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (gameEndWithWinMessage == DialogResult.Yes)
            {
                this.initializeBackAndFront();
                this.Show();
            }
            else if (gameEndWithWinMessage == DialogResult.No)
            {
                this.Close();
            }
        }

        private void doOnTie()
        {
            StringBuilder tieMessage = new StringBuilder();
            tieMessage.AppendLine("Tie!!");
            tieMessage.Append("Another Round?");
            DialogResult gameEndWithTieMessage = MessageBox.Show(tieMessage.ToString(), "A Tie!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (gameEndWithTieMessage == DialogResult.Yes)
            {
                this.initializeBackAndFront();
                this.Show();
            }
            else if (gameEndWithTieMessage == DialogResult.No)
            {
                this.Close();
            }
        }

        private void doOnInserting(int i_Raw, int i_Column, GameBoard.ePlayersCoins i_coin)
        {
            int raw = this.r_NumberOfRows - i_Raw;
            this.m_BoardMatrix[i_Column, raw].Text = i_coin.ToString();
        }

        private void doOnFullColumn(int i_Column)
        {
            this.m_RowNumbersButtons[i_Column].Enabled = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameFormBoard
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "GameFormBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}