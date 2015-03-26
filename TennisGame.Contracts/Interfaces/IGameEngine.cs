using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisGame.Contracts.Interfaces
{
    public interface IGameEngine
    {
        IGame GameInProgress { get; set; }
        void InitializeNewGame(ISide OneSide, ISide TwoSide);

        void MarkScore(string teamName);

        bool IsGameOver();
    }
}
