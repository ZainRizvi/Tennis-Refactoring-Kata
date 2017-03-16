namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int _mScore1;
        private int _mScore2;
        private readonly string _player1Name;
        private readonly string _player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1Name)
                _mScore1 += 1;
            else
                _mScore2 += 1;
        }

        public string GetScore()
        {
            return new ScoringData(_mScore1, _mScore2, _player1Name, _player2Name).ScoreIt();
        }
    }
}

