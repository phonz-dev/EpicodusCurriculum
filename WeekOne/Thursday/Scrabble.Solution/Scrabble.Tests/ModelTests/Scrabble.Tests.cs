using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void ScrabbleScorerConstructor_CreatesInstanceOfScrabbleScorer_ScrabbleScorer()
    {
      ScrabbleScorer newScrabble = new ScrabbleScorer();
    }
  }
}
