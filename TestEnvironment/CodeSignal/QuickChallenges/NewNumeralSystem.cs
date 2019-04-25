using System.Collections.Generic;

namespace TestEnvironment.CodeSignal.QuickChallenges
{
  /// <summary>
  /// Your Informatics teacher at school likes coming up with new ways to help you understand the material. When you
  /// started studying numeral systems, he introduced his own numeral system, which he's convinced will help clarify
  /// things. His numeral system has base 26, and its digits are represented by English capital letters - A for 0,
  /// B for 1, and so on.
  /// The teacher assigned you the following numeral system exercise: given a one-digit number, you should find all
  /// unordered pairs of one-digit numbers whose values add up to the number.
  /// For number = 'G', the output should be newNumeralSystem(number) = ["A + G", "B + F", "C + E", "D + D"].
  /// Translating this into the decimal numeral system we get: number = 6,
  /// so it is ["0 + 6", "1 + 5", "2 + 4", "3 + 3"].
  /// </summary>
  public static class NewNumeralSystem
  {
    private static readonly List<char> NumeralSystem = new List<char>()
    {
      'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
      'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
      'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
    };

    public static string[] GetPairsWhichSumIsNumber(char number)
    {
      int index = NumeralSystem.IndexOf(number);
      List<string> resultList = new List<string>();

      for (int i = 0; i <= index / 2; i++)
      {
        int count = 0;
        while (count != index + 1)
        {
          if (i + count == index) resultList.Add($"{NumeralSystem[i]} + {NumeralSystem[count]}");
          count++;
        }
      }

      return resultList.ToArray();
    }
  }
}