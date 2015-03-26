namespace TennisGame.Contracts.Interfaces
{
    public interface IGame
    {
        ISide Side1 { get; set; }
        ISide Side2 { get; set; }
        string MarkScore(string teamName);
        string GetFriendlyScore();
        bool IsGameInDeuce();
        bool IsGameOver();
    }
}
