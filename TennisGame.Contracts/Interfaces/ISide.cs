using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisGame.Contracts.Interfaces
{
    public interface ISide
    {
        string TeamName { get; set; }
        IEnumerable<IPlayer> Players { get; set; }
        int NumberOfPoints { get; set; }
        void IncrementScore();
        string GetScoreFriendlyName();
    }
}
