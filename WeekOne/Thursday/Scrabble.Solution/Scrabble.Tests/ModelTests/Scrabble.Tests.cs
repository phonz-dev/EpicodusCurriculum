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
      Assert.AreEqual(typeof(ScrabbleScorer), newScrabble.GetType());
    }

    [TestMethod]
    public void GetLetterPoint_ReturnsLetterPoint_Int()
    {
      ScrabbleScorer scrabbleScorer = new ScrabbleScorer();

      int result1 = scrabbleScorer.GetLetterPoint('A');
      int result2 = scrabbleScorer.GetLetterPoint('D');
      int result3 = scrabbleScorer.GetLetterPoint('B');
      int result4 = scrabbleScorer.GetLetterPoint('F');
      int result5 = scrabbleScorer.GetLetterPoint('K');
      int result6 = scrabbleScorer.GetLetterPoint('J');
      int result7 = scrabbleScorer.GetLetterPoint('Q');

      Assert.AreEqual(1, result1);
      Assert.AreEqual(2, result2);
      Assert.AreEqual(3, result3);
      Assert.AreEqual(4, result4);
      Assert.AreEqual(5, result5);
      Assert.AreEqual(8, result6);
      Assert.AreEqual(10, result7);
    }

    [TestMethod]
    public void CalcuateScore_CalculatesScoreOfWord_Int()
    {
      ScrabbleScorer scrabbleScorer = new ScrabbleScorer();
      string word1 = "APPLE";
      string word2 = "ZEBRA";
      int word1Score = 9;
      int word2Score = 16;

      int score01 = scrabbleScorer.CalculateScore(word1);
      int score02 = scrabbleScorer.CalculateScore(word2);

      Assert.AreEqual(word1Score, score01);
      Assert.AreEqual(word2Score, score02);
    }
  }
}
