using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      string stevensChoice = "rock";
      string kristasChoice = "paper";
      if (stevensChoice == "rock")
      {
        stevenWins = Game.RockBeats(kristasChoice);
      }

    }
  }
}