using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TennisGame.Contracts.Implementation;
using TennisGame.Contracts.Interfaces;

namespace TennisGame.GameEngine
{
    public class UserInputHandler
    {
        public IGameEngine GetInputAndInitGame()
        {
            Console.WriteLine("Welcome to Tennis Scoring System");
            Console.WriteLine("Enter 1 for Singles, 2 for Doubles");
            //Error handing to be done here. Assuming correct input
            int numberOfPlayers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Team Name for Side 1");
            string teamNameOne = Console.ReadLine();
            Console.WriteLine("Enter The Team Name for Side 2");
            string teamNameTwo = Console.ReadLine();
            var sideOne = new Side(teamNameOne, numberOfPlayers);
            var sideTwo = new Side(teamNameTwo, numberOfPlayers);
            var engine = new TennisGameEngine();
            engine.InitializeNewGame(sideOne,sideTwo);
            return engine;
        }
    }
}
