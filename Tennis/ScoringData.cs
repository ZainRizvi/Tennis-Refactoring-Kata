namespace Tennis
{
    internal class ScoringData
    {
        public static string[] ScoreWorkds = { "Love", "Fifteen", "Thirty", "Forty" };

        public ScoringData(int player1Points, int player2Points, string player1Name, string player2Name)
        {
            Player1Points = player1Points;
            Player2Points = player2Points;
            Player1Name = player1Name;
            Player2Name = player2Name;
            Score = null;
        }

        public ScoringData(ScoringData previous, string score)
        {
            Player1Name = previous.Player1Name;
            Player2Name = previous.Player2Name;
            Player1Points = previous.Player1Points;
            Player2Points = previous.Player2Points;
            Score = score;
        }

        public string Score { get; }

        private int Player1Points { get; }

        private int Player2Points { get; }

        public string Player1Name { get; }

        public string Player2Name { get; }

        public bool EitherPlayerScoredFourOrHigher
        {
            get { return Player1Points >= 4 || Player2Points >= 4; }
        }

        public bool IsScoreEqual
        {
            get { return Player1Points == Player2Points; }
        }

        public int Player1PointAdvantage
        {
            get {
                return GetPointsAdvantage(Player1Points, Player2Points);
            }
        }

        public int Player2PointAdvantage
        {
            get
            {
                return GetPointsAdvantage(Player2Points, Player1Points);
            }
        }

        private int GetPointsAdvantage(int playerPoints, int otherPlayerPoints)
        {
            if (playerPoints > otherPlayerPoints)
            {
                return playerPoints - otherPlayerPoints;
            }

            return 0;
        }

        public string Player1PointsName
        {
            get { return ScoreWorkds[Player1Points]; }
        }

        public string Player2PointsName
        {
            get { return ScoreWorkds[Player2Points]; }
        }

        public bool IsDeuce
        {
            get { return IsScoreEqual && Player1Points >= 3; }
        }

        public bool IsScoringNormal
        {
            get { return Player1Points < 4 && Player2Points < 4 && !IsScoreEqual; }
        }
    }
}