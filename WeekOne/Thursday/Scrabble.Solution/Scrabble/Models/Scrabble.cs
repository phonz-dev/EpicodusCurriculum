using System.Collections.Generic;

namespace Scrabble.Models
{
  public class ScrabbleScorer
  {
    public int CalculateScore(string word)
    {
      int total = 0;

      foreach (char letter in word)
        total += GetLetterPoint(letter);

      return total;
    }

    public int GetLetterPoint(char letter)
    {
      List<char> onePointLetters = new List<char> { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
      List<char> twoPointLetters = new List<char> { 'D', 'G' };
      List<char> threePointLetters = new List<char> { 'B', 'C', 'M', 'P' };
      List<char> fourPointLetters = new List<char> { 'F', 'H', 'V', 'W', 'Y' };
      List<char> eightPointLetters = new List<char> { 'J', 'X' };

      if (letter == 'K') return 5;
      if (onePointLetters.Contains(letter)) return 1;
      if (twoPointLetters.Contains(letter)) return 2;
      if (threePointLetters.Contains(letter)) return 3;
      if (fourPointLetters.Contains(letter)) return 4;
      if (eightPointLetters.Contains(letter)) return 8;

      return 10;
    }
  }
}
