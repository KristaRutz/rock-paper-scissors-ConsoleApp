using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static int rounds { get; set; }
    public static void Main()
    {
      Console.WriteLine("Play best out of ___. [Type an odd number]");
      //steven wants a try catch
      rounds = int.Parse(Console.ReadLine());
      Console.WriteLine(rounds);
      newRound();
    }

    public static void newRound()
    {
      Console.WriteLine("Player One: Type 'rock', 'paper', or 'scissors' to beat your opponent!");
      string playerOneChoice = Console.ReadLine();
      Console.WriteLine("Player Two: Type 'rock', 'paper', or 'scissors' to beat your opponent!");
      string playerTwoChoice = Console.ReadLine();
      Game game = new Game(playerOneChoice, playerTwoChoice, rounds);
      game.Battle();
      if (game.PrintScoreBoard())
      {
        newRound();
      }
      else
      {
        Console.WriteLine("Play again? [y/n]");
        string choice = Console.ReadLine().ToLower();
        if (choice == "y")
        {
          Main();
        }
      }
    }
  }
}