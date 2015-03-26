using System;
using TennisGame.GameEngine;

namespace TennisGame.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInputHandler = new UserInputHandler();
            var engine = userInputHandler.GetInputAndInitGame();
            Console.WriteLine("Side 1 is {0}",engine.GameInProgress.Side1.TeamName);
            Console.WriteLine("Side 2 is {0}",engine.GameInProgress.Side2.TeamName);
            while (!engine.IsGameOver())
            {
                Console.WriteLine("Please enter team name of scoring team");
                string teamName = Console.ReadLine();
                //Make sure teamname exists
                engine.MarkScore(teamName);
                Console.WriteLine("Team Scores {0}",engine.GameInProgress.GetFriendlyScore());
            }
            Console.WriteLine("Game is over. Final Score was {0}",engine.GameInProgress.GetFriendlyScore());
        }
    }
}
