using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public static int PlayerOneScore { get; set; } = 0;
    public static int PlayerTwoScore { get; set; } = 0;

    public string ChoiceOne { get; set; }
    public string ChoiceTwo { get; set; }

    public static int InitialRounds { get; set; }

    public Game(string choiceOne, string choiceTwo, int rounds)
    {
      ChoiceOne = choiceOne;
      ChoiceTwo = choiceTwo;
      InitialRounds = rounds;
    }

    public void Battle()
    {
      bool PlayerOneWins = false;
      if (SameHandEvent(ChoiceOne, ChoiceTwo))
      {
        Console.WriteLine("No winner. Play again!");
      }
      else
      {
        if (ChoiceOne == "rock")
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
    }

    public bool PrintScoreBoard()
    {
      Console.WriteLine($"Player One: {PlayerOneScore}");
      Console.WriteLine($"Player Two: {PlayerTwoScore}");
      Console.WriteLine("{check win}");
      if (PlayerOneScore >= (InitialRounds + 1) / 2)
      {
        Console.WriteLine($"Game over! Player One wins!");
        return false;
      }
      else if (PlayerTwoScore >= (InitialRounds + 1) / 2)
      {
        Console.WriteLine($"Game over! Player Two wins!");
        return false;
      }
      else
      {
        Console.WriteLine("Next round!");
        return true;
      }
    }
    public static bool SameHandEvent(string choice1, string choice2)
    {
      if (choice1 == choice2)
      {
        return true;
      }
      return false;
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

    //   public static string CompareHands(string player1Choice, string player2Choice)
    //   {
    //     if (player1Choice == player2Choice)
    //     {
    //       return "tie";
    //     }
    //     else if (player1Choice == "rock")
    //     {
    //       if (player2Choice == "scissors")
    //       {
    //         return "rock";
    //       }
    //       else if (player2Choice == "paper")
    //       {
    //         return "paper";
    //       }
    //       else
    //       {
    //         return "Break";
    //       }
    //     }
    //     else if (player1Choice == "paper")
    //     {
    //       if (player2Choice == "scissors")
    //       {
    //         return "scissors";
    //       }
    //       else if (player2Choice == "rock")
    //       {
    //         return "paper";
    //       }
    //       else
    //       {
    //         return "Break";
    //       }
    //     }
    //     else if (player1Choice == "scissors")
    //     {
    //       if (player2Choice == "rock")
    //       {
    //         return "rock";
    //       }
    //       else if (player2Choice == "paper")
    //       {
    //         return "scissors";
    //       }
    //       else
    //       {
    //         return "Break";
    //       }
    //     }
    //     else
    //     {
    //       return "get out of my house krista";
    //     }
    //   }
    // }
  }
}