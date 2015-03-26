using TennisGame.Contracts.Enums;

namespace TennisGame.Contracts.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }

        Gender PlayerGender { get;set; }
    }
}
