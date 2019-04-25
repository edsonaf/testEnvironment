using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment.CodeWars
{
  public static class CodeWarsMain
  {
    public static string Maskify(string cc)
    {
      if (cc.Length <= 4)
        return cc;

      return cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');

//      string[] result = new string[cc.Length];
//
//      for (int i = 0; i < cc.Length; i++)
//      {
//        if (i < cc.Length - 4)
//        {
//          result[i] = "#";
//        }
//        else
//        {
//          result[i] = char.ToString(cc[i]);
//        }
//      }
//
//      return string.Join("", result);
    }

    public static bool IsSquare(int n)
    {
      return Math.Sqrt(n) % 1 == 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int GetSum(int a, int b)
    {
      int max = Math.Max(a, b);
      int min = Math.Min(a, b);
      int sum = 0;

      for (int i = min; i <= max; i++)
      {
        sum += i;
      }

      return sum;
    }

    /// <summary>
    /// In this kata you are required to, given a string,
    /// replace every letter with its position in the alphabet.
    /// If anything in the text isn't a letter, ignore it and don't return it.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string AlphabetPosition(string text)
    {
      Dictionary<char, int> position = new Dictionary<char, int>
      {
        {'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5}, {'f', 6}, {'g', 7},
        {'h', 8}, {'i', 9}, {'j', 10}, {'k', 11}, {'l', 12}, {'m', 13}, {'n', 14},
        {'o', 15}, {'p', 16}, {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20}, {'u', 21},
        {'v', 22}, {'w', 23}, {'x', 24}, {'y', 25}, {'z', 26},
      };

      text = text.ToLower();
      string result = "";
      for (int i = 0; i < text.Length; i++)
      {
        if (char.IsLetter(text[i]))
        {
          result += position[text[i]].ToString();
          result += " ";
        }
      }

      result = result.TrimEnd(' ');
      return result;

//      return string.Join(" ", text.ToLower()
//        .Where(char.IsLetter)
//        .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
//        .ToArray());
    }
  }
}