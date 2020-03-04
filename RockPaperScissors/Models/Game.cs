using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public static int PlayerOneScore { get; set; }
    public static int PlayerTwoScore { get; set; }

    public string ChoiceOne { get; set; }
    public string ChoiceTwo { get; set; }

    public Game(string choiceOne, string choiceTwo)
    {
      ChoiceOne = choiceOne;
      ChoiceTwo = choiceTwo;
    }

    public void Battle()
    {
      bool PlayerOneWins;
      if (SameHandEvent(ChoiceOne, ChoiceTwo))
      {
        break;
      }
      else if (ChoiceOne == "rock")
      {
        PlayerOneWins = RockBeats(ChoiceTwo);
      }
      else if (ChoiceOne == "paper")
      {
        PlayerOneWins = PaperBeats(ChoiceTwo);
      }
      else
      {
        PlayerOneWins = ScissorsBeats(ChoiceTwo);
      }

      if (PlayerOneWins)
      {
        PlayerOneScore++;
      }
      else
      {
        PlayerTwoScore++;
      }
    }

    public static bool SameHandEvent(string choicestevens, string kristasChoice)
    {
      if (kristasChoice == stevensChoice)
      {
        return true;
      }

    }
    public static bool RockBeats(string choice)
    {
      if (choice == "scissors")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool PaperBeats(string choice)
    {
      if (choice == "rock")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static bool ScissorsBeats(string choice)
    {
      if (choice == "paper")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static string CompareHands(string player1Choice, string player2Choice)
    {
      if (player1Choice == player2Choice)
      {
        return "tie";
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