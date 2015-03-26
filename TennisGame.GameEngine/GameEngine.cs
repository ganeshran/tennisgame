using TennisGame.Contracts.Implementation;
using TennisGame.Contracts.Interfaces;

namespace TennisGame.GameEngine
{
    public class TennisGameEngine : IGameEngine 
    {

        public IGame GameInProgress { get; set; }

        public void InitializeNewGame(ISide OneSide, ISide TwoSide)
        {
            this.GameInProgress = new Game(OneSide, TwoSide);
        }

        public void MarkScore(string teamName)
        {
            this.GameInProgress.MarkScore(teamName);
        }

        public bool IsGameOver()
        {
            return this.GameInProgress.IsGameOver();
        }

    }
}
