using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEnvironment
{
  public class Main
  {
    private bool SumOfTwo(int[] a, int[] b, int v)
    {
      HashSet<int> bHash = new HashSet<int>(b);
      return a.Any(x => bHash.Contains(v - x));
    }

    public bool AlternatingSort(int[] a)
    {
      if (a.Length == 1) return true;

      int[] b = new int[a.Length];
      int j = 0;
      for (int i = 0; i < a.Length; i++)
      {
        if (i % 2 == 0)
        {
          b[i] = a[j];
          j++;
        }
        else
        {
          b[i] = a[a.Length - j];
        }
      }

      int firstDiff = b[1] - b[0];
      for (int i = 0; i < b.Length - 1; i++)
      {
        if (b[i + 1] - b[i] != firstDiff)
        {
          return false;
        }
      }

      return true;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public int countTinyPairs(int[] a, int[] b, int k)
    {
      int j = a.Length - 1;
      int count = 0;
      for (int i = 0; i < a.Length;)
      {
        string s = string.Concat(a[i], b[j]);
        var tryParse = int.TryParse(s, out var result);

        if (result < k) count++;

        i++;
        j--;
      }

      return count;
    }

    /// <summary>
    /// Given a string str and an integer k, your task is to split
    /// "str" into a minimal possible number of substrings so that
    /// there are no more than "k" different symbols in each of them.
    /// Return the minimal possible number of such substrings.
    /// </summary>
    /// <param name="str">A string that can contains only English lowercase letters.</param>
    /// <param name="k">The maximal number of different letters allowed in one substring.</param>
    /// <returns>An integer representing the minimal number of substrings
    /// that str can be split into.</returns>
    public int upToKDifferences(string str, int k)
    {
      int count = 1;
      HashSet<char> currentAllowedSymbols = new HashSet<char>();

      for (int i = 0; i < str.Length; i++)
      {
        if (currentAllowedSymbols.Count == k && !currentAllowedSymbols.Contains(str[i]))
        {
          currentAllowedSymbols.Clear();
          count++;
        }

        if (!currentAllowedSymbols.Contains(str[i])) currentAllowedSymbols.Add(str[i]);
      }

      return count;
    }

    /// <summary>
    /// Given an array of positive integers a, your task is to calculate the sum of every
    /// possible a[i] . a[j], where a[i] . a[j] is the concatenation of the string representations
    /// of a[i] and a[j] respectively.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public long ConcatenationsSum(int[] a)
    {
      return a.Sum(t1 => a.Sum(t => Convert.ToInt64(string.Concat(t1, t))));
    }

    /// <summary>
    /// Given integers x and n, find the largest integer k such that x0+x1+x2+...+xk ≤ n.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int SpecialPolynomial(int x, int n)
    {
      int currentK = 0;
      int currentResult = 0;
      while ((currentResult + Math.Pow(x, currentK)) <= n)
      {
        currentResult += (int) Math.Pow(x, currentK);
        currentK++;
      }

      return currentK - 1;
    }

        /// <summary>
        /// You work in a company that prints and publishes books. You are responsible
        /// for designing the page numbering mechanism in the printer. You know how many
        /// digits a printer can print with the leftover ink. Now you want to write a
        /// function to determine what the last page of the book is that you can number
        /// given the current page and numberOfDigits left. A page is considered numbered
        /// if it has the full number printed on it (e.g. if we are working with page 102
        /// but have ink only for two digits then this page will not be considered numbered).
        /// 
        /// It's guaranteed that you can number the current page, and that you can't number
        /// the last one in the book.
        /// For current = 1 and numberOfDigits = 5, the output should be
        /// pagesNumberingWithInk(current, numberOfDigits) = 5.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="numberOfDigits"></param>
        /// <returns></returns>
        public int PagesNumberingWithInk(int current, int numberOfDigits)
    {
        int result = current - 1;
        while (current.ToString().Length <= numberOfDigits)
        {
            result++;
            current++;
            numberOfDigits -= result.ToString().Length;
        }

        return result;
    }

    }
}