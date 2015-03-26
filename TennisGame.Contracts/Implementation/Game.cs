using TennisGame.Contracts.Interfaces;

namespace TennisGame.Contracts.Implementation
{
    public class Game : IGame
    {
        public ISide Side1 { get; set; }
        public ISide Side2 { get; set; }

        public Game(ISide sideOne, ISide sideTwo)
        {
            this.Side1 = sideOne;
            this.Side2 = sideTwo;
        }

        public string MarkScore(string teamName)
        {
            //More rigorous check would be required in production. Reducing for simplicity
            var sideToBeScored = this.Side1.TeamName == teamName ? Side1 : Side2;
            sideToBeScored.IncrementScore();
            return this.GetFriendlyScore();
        }

        public bool IsGameOver()
        {
            return IsGameOver(Side1, Side2) || IsGameOver(Side2, Side1);
        }
        
        private bool IsGameOver(ISide sideOne, ISide sideTwo)
        {
           return (sideOne.NumberOfPoints >= 4 && (sideOne.NumberOfPoints - sideTwo.NumberOfPoints) >= 2);
        }

        public string GetFriendlyScore()
        {
            if(!this.IsGameInDeuce())
            return string.Format("{0}:{1}", Side1.GetScoreFriendlyName(), Side2.GetScoreFriendlyName());
            else
            {
                if (Side1.NumberOfPoints == Side2.NumberOfPoints)
                    return string.Format("Deuce. Both players are tied at {0}", Side1.NumberOfPoints);
                else
                    return string.Format("Deuce. Advantage is to {0}. Total Points are {1}:{2}",
                                         this.Side1.NumberOfPoints > this.Side2.NumberOfPoints
                                             ? Side1.TeamName
                                             : Side2.TeamName, Side1.NumberOfPoints, Side2.NumberOfPoints);
            }
        }


        public bool IsGameInDeuce()
        {
            return Side1.NumberOfPoints >= 3 && Side2.NumberOfPoints >= 3;
        }
    }
}
