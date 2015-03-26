using TennisGame.Contracts.Enums;
using TennisGame.Contracts.Interfaces;

namespace TennisGame.Contracts.Implementation
{
    public class Player:  IPlayer
    {
        public string Name { get; set; }
        public Gender PlayerGender { get; set; }
    }
}
