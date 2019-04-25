using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment.Interview
{
  public static class Arrays
  {
    /// <assignment>
    /// Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number
    /// for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated
    /// numbers, return the number for which the second occurrence has a smaller index than the second occurrence of
    /// the other number does. If there are no such elements, return -1.
    /// </assignment>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int FirstDuplicate(int[] a)
    {
      HashSet<int> set = new HashSet<int>();
      foreach (int t in a)
      {
        if (set.Contains(t))
          return t;

        set.Add(t);
      }

      return -1;
    }


    /// <assignment>
    /// Given a string s, find and return the first instance of a non-repeating character in it. If there is no such
    /// character, return '_'.
    /// </assignment>
    /// <param name="s"></param>
    /// <returns></returns>
    public static char FirstNotRepeatingCharacter(string s)
    {
//      // too much code bro
//      char[] charArray = s.ToCharArray();
//      int arrayLength = charArray.Length;
//      List<char> charList = new List<char>();
//      List<char> duplicateCharacters = new List<char>();
//      for (int i = 0; i < arrayLength; i++)
//      {
//        if (!duplicateCharacters.Contains(charArray[i]) && 
//            !charList.Contains(charArray[i]))
//        {
//          charList.Add(charArray[i]);
//        }
//        else
//        {
//          charList.Remove(charArray[i]);
//          duplicateCharacters.Add(charArray[i]);
//        }
//      }
//
//      return charList.Count == 0 ? '_' : charList.First();

      IGrouping<char, char> exist = s.GroupBy(x => x).FirstOrDefault(x => x.Count() == 1);
      return exist?.Key ?? '_';
    }


    /// <assignment>
    /// You are given an n x n 2D matrix that represents an image. Rotate the image by 90 degrees (clockwise).
    /// </assignment>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int[][] RotateImage(int[][] a)
    {
      int l = a.GetLength(0);

      int[][] rotated = new int[l][];
      for (int i = 0; i < l; i++)
      {
        rotated[i] = new int[l];
        for (int j = 0; j < l; j++)
        {
          rotated[i][j] = a[l - j - 1][i];
        }
      }

      return rotated;
    }

    /// <assignment>
    /// Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid with numbers in such a way that each
    /// column, each row, and each of the nine 3 × 3 sub-grids that compose the grid all contain all of the numbers
    /// from 1 to 9 one time.\
    /// Implement an algorithm that will check whether the given grid of numbers represents a valid Sudoku puzzle
    /// according to the layout rules described above. Note that the puzzle represented by grid does not have to be
    /// solvable.
    /// </assignment>
    /// <param name="grid"></param>
    /// <returns></returns>
    public static bool Sudoku2(char[][] grid)
    {
      if (grid.Any(IsInvalid) || // across rows
          grid.Select((_, i) => i).Any(c => IsInvalid(grid.Select(_ => _[c])))) // down columns
        return false;

      // within sub-grids
      for (int r = 0; r < grid.Length; r += 3)
      {
        for (int c = 0; c < grid.Length; c += 3)
        {
          // ReSharper disable once AccessToModifiedClosure
          if (IsInvalid(grid.Skip(r).Take(3).SelectMany(_ => _.Skip(c).Take(3))))
            return false;
        }
      }

      return true;
    }

    private static bool IsInvalid(IEnumerable<char> numbers)
    {
      var counts = new int[9];
      return numbers.Any(n => n != '.' && counts[n - '1']++ > 0);
    }

    /// <summary>
    /// A cryptarithm is a mathematical puzzle for which the goal is to find the correspondence between letters and digits,
    /// such that the given arithmetic equation consisting of letters holds true when the letters are converted to digits.
    /// You have an array of strings crypt, the cryptarithm, and an an array containing the mapping of letters and
    /// digits, solution. The array crypt will contain three non-empty strings that follow the
    /// structure: [word1, word2, word3], which should be interpreted as the word1 + word2 = word3 cryptarithm.
    /// If crypt, when it is decoded by replacing all of the letters in the cryptarithm with digits using the mapping in
    /// solution, becomes a valid arithmetic equation containing no numbers with leading zeroes, the answer is true. If it
    /// does not become a valid arithmetic solution, the answer is false.
    /// Note that number 0 doesn't contain leading zeroes (while for example 00 or 0123 do). 
    /// </summary>
    /// <param name="crypt"></param>
    /// <param name="solution"></param>
    /// <returns></returns>
    public static bool IsCryptSolution(string[] crypt, char[][] solution)
    {
      var dict = solution.ToDictionary(x => x[0], x => x[1]);
      string[] w = crypt.Select(x => new string(x.Select(y => dict[y]).ToArray())).ToArray();
      if (w.Any(x => x.Length > 1 && x[0] == '0')) return false;
      var n = w.Select(x => int.TryParse(x, out var r) ? r : 0).ToArray();
      return n[0] + n[1] == n[2];

      // EAF: Code below is selfmade. Code above is from internet. Does the same thing

//      string[] encryptedWords = new string[crypt.Length];
//
//      for (int i = 0; i < crypt.Length; i++)
//      {
//        string word = crypt[i];
//        for (int j = 0; j < word.Length; j++)
//        {
//          var c = word[j];
//          bool found = false;
//          while (!found)
//          {
//            foreach (char[] c1 in solution)
//            {
//              if (!c1.Contains(c)) continue;
//
//              encryptedWords[i] += c1[1];
//              found = true;
//            }
//          }
//        }
//      }
//
//      if ((encryptedWords[0].StartsWith("0") && encryptedWords[0].Length != 1) ||
//          (encryptedWords[1].StartsWith("0") && encryptedWords[1].Length != 1) ||
//          (encryptedWords[2].StartsWith("0") && encryptedWords[2].Length != 1))
//      {
//        return false;
//      }
//
//      int.TryParse(encryptedWords[0], out var word1);
//      int.TryParse(encryptedWords[1], out var word2);
//      int.TryParse(encryptedWords[2], out var word3);
//
//      return word1 + word2 == word3;
    }
  }
}