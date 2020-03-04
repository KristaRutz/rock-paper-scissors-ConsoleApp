using System;

namespace RockPaperScissors.Models
{
  public class Game
  {

    public static string CompareHands(string player1Choice, string player2Choice)
    {
      if (player1Choice == player2Choice)
      {
        return "tie";
        // CompareHands();
      }
      else if (player1Choice == "rock")
      {
        if (player2Choice == "scissors")
        {
          return "rock";
        }
        else if (player2Choice == "paper")
        {
          return "paper";
        }
        else
        {
          return "Break";
        }
      }
      else if (player1Choice == "paper")
      {
        if (player2Choice == "scissors")
        {
          return "scissors";
        }
        else if (player2Choice == "rock")
        {
          return "paper";
        }
        else
        {
          return "Break";
        }
      }
      else if (player1Choice == "scissors")
      {
        if (player2Choice == "rock")
        {
          return "rock";
        }
        else if (player2Choice == "paper")
        {
          return "scissors";
        }
        else
        {
          return "Break";
        }
      }
      else
      {
        return "get out of my house krista";
      }
    }
  }
}