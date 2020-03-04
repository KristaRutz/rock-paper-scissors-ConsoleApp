using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void Game_CompareSameHands_Tie()
    {
      string result = Game.CompareHands("rock", "rock");
      Assert.AreEqual("tie", result);
    }
    [TestMethod]
    public void Game_CompareRockAndPaper_Paper()
    {
      string result = Game.CompareHands("rock", "paper");
      Assert.AreEqual("paper", result);
    }
    [TestMethod]
    public void Game_CompareRockAndScissors_Rock()
    {
      string result = Game.CompareHands("rock", "scissors");
      Assert.AreEqual("rock", result);
    }
    [TestMethod]
    public void Game_CompareScissorAndPaper_Scissors()
    {
      string result = Game.CompareHands("paper", "scissors");
      Assert.AreEqual("scissors", result);
    }
  }
}