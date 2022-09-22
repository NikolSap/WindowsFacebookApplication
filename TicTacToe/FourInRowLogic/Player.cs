namespace FourInRowLogic
{
    public class Player
    {
        private readonly GameBoard.ePlayersCoins r_PlayerShape;
        private readonly string r_Name;
        private int m_Score;

        public Player(string i_Name, GameBoard.ePlayersCoins i_PlayerShape)
        {
            this.m_Score = 0;
            this.r_PlayerShape = i_PlayerShape;
            this.r_Name = i_Name;
        }

        public GameBoard.ePlayersCoins PlayerShape
        {
            get { return r_PlayerShape; }
        }

        public string Name
        {
            get { return r_Name; }
        }

        public int Score
        {
            get { return m_Score; }
            set { m_Score = value; }
        }
    }
}