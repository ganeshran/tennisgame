using System.Collections.Generic;
using TennisGame.Contracts.Interfaces;

namespace TennisGame.Contracts.Implementation
{
    public class Side : ISide 
    {

        public Side(string teamName, int numberOfPlayers)
        {
            this.TeamName = teamName;
            this.Players = new List<IPlayer>();
            
            this.NumberOfPoints = 0;
        }

        public string TeamName { get; set; }
        public IEnumerable<IPlayer> Players { get; set; }
        public int NumberOfPoints { get; set; }
        public void IncrementScore()
        {
            this.NumberOfPoints++;
        }

        public string GetScoreFriendlyName()
        {
            switch (this.NumberOfPoints)
            {
                case 0:
                    return "love";
                case 1:
                    return "fifteen";
                case 2:
                    return "thirty";
                case 3:
                    return "fourty";
                case 4:
                    return "fourty-five";
                default:
                    return "deuce";

            }
        }
    }
}
