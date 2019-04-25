using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace TestEnvironment.Arcade
{
  public static class ArcadeIntro
  {
    #region Edge of the Ocean

    /// <assignment>
    /// Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing
    /// sequence by removing no more than one element from the array.
    /// </assignment>
    /// <param name="sequence"></param>
    /// <returns></returns>
    public static bool AlmostIncreasingSequence(int[] sequence)
    {
      int r = 0;
      for (int i = 0; i < sequence.Length - 1; i++)
      {
        if (sequence[i] >= sequence[i + 1])
          r++;
        if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
          r++;
      }

      return r <= 2;
    }


    /// <assignment>
    /// After they became famous, the CodeBots all decided to move to a new building and live together. The building
    /// is represented by a rectangular matrix of rooms. Each cell in the matrix contains an integer that represents
    /// the price of the room. Some rooms are free (their cost is 0), but that's probably because they are haunted,
    /// so all the bots are afraid of them. That is why any room that is free or is located anywhere below a free room
    /// in the same column is not considered suitable for the bots to live in.
    ///
    /// Help the bots calculate the total price of all the rooms that are suitable for them.
    /// </assignment>
    /// <returns></returns>
    public static int MatrixElementsSum(int[][] matrix)
    {
      int r = 0;
      for (int i = 0; i < matrix[0].Length; i++) // for every array in this array
      for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
        r += matrix[j][i];

      return r;
    }

    #endregion Edge of the Ocean

    #region Smooth Sailing

    /// <assignment>
    /// Given an array of strings, return another array containing all of its longest strings.
    /// </assignment>
    /// <param name="inputArray"></param>
    /// <returns></returns>
    public static string[] AllLongestStrings(string[] inputArray)
    {
      int length = inputArray.Max(s => s.Length);
      IEnumerable<string> enumerable = inputArray.Where(s => s.Length == length);
      return enumerable.ToArray();
    }


    /// <assignment>
    /// Given two strings, find the number of common characters between them.
    /// </assignment>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public static int CommonCharacterCount(string s1, string s2)
    {
      return s1.Distinct().Sum(_ => Math.Min(s1.Count(l => l == _), s2.Count(l => l == _)));
    }


    /// <assignment>
    /// Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of
    /// the first half of the digits is equal to the sum of the second half.
    /// Given a ticket number n, determine if it's lucky or not.
    /// </assignment>
    /// <param name="n"></param>
    /// <returns></returns>
    public static bool IsLucky(int n)
    {
      // found as first answer
      string stringN = n.ToString();
      n = stringN.Length / 2;
      return stringN.Substring(n).Sum(_ => _ - '0') == stringN.Remove(n).Sum(_ => _ - '0');

      // my code
//      string s = n.ToString();
//      int half = s.Length / 2;
//      string firstHalf = s.Substring(0, half);
//      string secondHalf = s.Substring(half);
//      int firstHalfInt = 0;
//      int secondHalfInt = 0;
//      foreach (char t in firstHalf)
//      {
//        firstHalfInt += Convert.ToInt32(t);
//      }
//      foreach (char t in secondHalf)
//      {
//        secondHalfInt += Convert.ToInt32(t);
//      }
//      
//      return firstHalfInt == secondHalfInt;
    }


    /// <assignment>
    /// Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task
    /// is to rearrange the people by their heights in a non-descending order without moving the trees. People can
    /// be very tall!
    ///
    /// Example:
    /// For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
    /// sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
    /// </assignment>
    /// <param name="a">
    ///  If a[i] = -1, then the ith position is occupied by a tree. Otherwise a[i] is the height of a person standing
    /// in the ith position.
    /// </param>
    /// <returns>
    /// Sorted array a with all the trees untouched.
    /// </returns>
    public static int[] SortByHeight(int[] a)
    {
//      int[] withoutTree = a.Where(i => i != -1).ToArray();
//      int[] orderedEnumerable = withoutTree.OrderBy(w => w).ToArray();
//      int count = 0;
//      for (int i = 0; i < a.Length; i++)
//      {
//        if (a[i] == -1) continue;
//
//        a[i] = orderedEnumerable[count];
//        count++;
//      }
//
//      return a;

      // look at this beauty
      int[] people = a.Where(p => p != -1).OrderBy(p => p).ToArray();
      int i = 0;

      return a.Select(p => p != -1 ? people[i++] : -1).ToArray();
    }


    /// <assignment>
    /// You have a string s that consists of English letters, punctuation marks, whitespace characters, and brackets.
    /// It is guaranteed that the parentheses in s form a regular bracket sequence.
    ///
    /// Your task is to reverse the strings contained in each pair of matching parentheses, starting from the innermost
    /// pair. The results string should not contain any parentheses.
    /// </assignment>
    /// <example>
    /// For string s = "a(bc)de", the output should be reverseParentheses(s) = "acbde".
    /// </example>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string ReverseParentheses(string s)
    {
      return Reverse(s);
    }

    private static string Reverse(string s)
    {
      while (true)
      {
        int left = s.LastIndexOf('(');
        if (left == -1) return s;
        int right = s.IndexOf(')', left);
        char[] arr = s.Substring(left + 1, right - left - 1).ToCharArray();
        Array.Reverse(arr);
        s = s.Substring(0, left) + new string(arr) + s.Substring(right + 1);
      }
    }

    #endregion

    #region Exploring the Waters

    /// <assignment>
    /// Several people are standing in a row and need to be divided into two teams. The first person goes into team 1,
    /// the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.
    /// You are given an array of positive integers - the weights of the people. Return an array of two integers,
    /// where the first element is the total weight of team 1, and the second element is the total weight of team 2
    /// after the division is complete.
    /// </assignment>
    /// <example>
    /// For a = [50, 60, 60, 45, 70], the output should be alternatingSums(a) = [180, 105].
    /// </example>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int[] AlternatingSums(int[] a)
    {
      int[] teams = {0, 0};

      for (int i = 0; i < a.Length; i++)
      {
        teams[i % 2] += a[i];
      }

      return teams;
    }


    /// <assignment>
    /// Given a rectangular matrix of characters, add a border of asterisks(*) to it.
    /// </assignment>
    /// <example>
    /// For  picture = ["abc", "ded"]
    /// The output should be: addBorder(picture) = ["*****", "*abc*", "*ded*","*****"]
    /// </example>
    /// <returns></returns>
    public static string[] AddBorder(string[] picture)
    {
      var stars = new[] {new string('*', picture[0].Length + 2)};
      return stars.Concat(picture.Select(s => "*" + s + "*"))
        .Concat(stars)
        .ToArray();
    }


    /// <assignment>
    /// Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in
    /// one of the arrays.
    /// Given two arrays a and b, check whether they are similar.
    /// </assignment>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool AreSimilar(int[] a, int[] b)
    {
      var diffs = a.Select((_, i) => i).Where(_ => a[_] != b[_]).ToArray();
      return diffs.Length == 0 || diffs.Length == 2 && a[diffs[0]] == b[diffs[1]] && b[diffs[0]] == a[diffs[1]];
    }


    /// <assignment>
    /// You are given an array of integers. On each move you are allowed to increase exactly one of its element by one.
    /// Find the minimal number of moves required to obtain a strictly increasing sequence from the input.
    /// </assignment>
    /// <param name="inputArray"></param>
    /// <returns></returns>
    public static int ArrayChange(int[] inputArray)
    {
      int count = 0;
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (i == inputArray.Length - 1) break;

        while (inputArray[i + 1] <= inputArray[i])
        {
          inputArray[i + 1]++;
          count++;
        }
      }

      return count;
    }


    /// <summary>
    /// Given a string, find out if its characters can be rearranged to form a palindrome.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static bool PalindromeRearranging(string inputString)
    {
      IEnumerable<IGrouping<char, char>> groupBy = inputString.GroupBy(a => a);

      if (inputString.Length % 2 == 0)
      {
        // string has even characters. characters must be able to be grouped
        return groupBy.All(grouped => grouped.Count() % 2 == 0);
      }

      // string has uneven characters. all characters (except one) must be able to be grouped
      var @by = groupBy.ToList();
      IEnumerable<IGrouping<char, char>> enumerable = @by.Where(g => g.Count() % 2 == 1);
      int count = 0;
      var cs = enumerable.ToList();
      foreach (var c in cs) count++;
      return count == 1 && @by.Where(grouped => grouped.Key != cs.First().Key)
               .All(grouped => grouped.Count() % 2 == 0);
    }

    #endregion

    #region Island of Knowledge 

    /// <summary>
    /// Call two arms equally strong if the heaviest weights they each are able to lift are equal.
    /// Call two people equally strong if their strongest arms are equally strong (the strongest arm can be
    /// both the right and the left), and so are their weakest arms.
    /// Given your and your friend's arms' lifting capabilities find out if you two are equally strong.
    /// </summary>
    /// <param name="yourLeft"></param>
    /// <param name="yourRight"></param>
    /// <param name="friendsLeft"></param>
    /// <param name="friendsRight"></param>
    /// <returns></returns>
    public static bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
    {
//      if (yourLeft != friendsLeft && yourLeft != friendsRight) return false;
//      return yourRight == friendsLeft || yourRight == friendsRight;

      return (yourLeft + yourRight) == (friendsLeft + friendsRight) && (yourLeft * yourLeft + yourRight * yourRight) ==
             (friendsLeft * friendsLeft + friendsRight * friendsRight);
    }


    /// <summary>
    /// Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
    /// </summary>
    public static int ArrayMaximalAdjacentDifference(int[] inputArray)
    {
      int last = inputArray[0];
      return inputArray.Max(_ => Math.Abs(last - (last = _)));

//      int maxDifference = 0;
//      for (int i = 0; i < inputArray.Length - 1; i++)
//      {
//        int currentDiff = inputArray[i + 1] - inputArray[i];
//        if (currentDiff < 0) currentDiff = Math.Abs(currentDiff);
//        if (currentDiff > maxDifference) maxDifference = currentDiff;
//      }
//      return maxDifference;
    }


    /// <summary>
    /// An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a
    /// computer network that uses the Internet Protocol for communication. There are two versions of the Internet
    /// protocol, and thus two versions of addresses. One of them is the IPv4 address.
    /// Given a string, find out if it satisfies the IPv4 address naming rules.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static bool IsIPv4Address(string inputString)
    {
      var strings = inputString.Split('.');
      if (strings.Length != 4) return false;

      foreach (string s in strings)
      {
        if (!int.TryParse(s, out var current)) return false;

        if (current < 0 || current > 255)
          return false;
      }

      return true;

//      System.Net.IPAddress result;
//      return System.Net.IPAddress.TryParse(inputString, out result); // doesnt work for inputString "1"    
    }


    /// <summary>
    /// You are given an array of integers representing coordinates of obstacles situated on a straight line.
    /// Assume that you are jumping from the point with coordinate 0 to the right. You are allowed only to make jumps
    /// of the same length represented by some integer.
    /// Find the minimal length of the jump enough to avoid all the obstacles.
    /// </summary>
    public static int AvoidObstacles(int[] inputArray)
    {
      int result = 1;
      for (int g = 0; g < inputArray.Length; g++)
      for (int h = 0; h < inputArray.Length; h++)
        while (inputArray[h] % result == 0)
          result++;

      return result;
    }

    /// <summary>
    /// Last night you partied a little too hard. Now there's a black and white photo of you that's about to
    /// go viral! You can't let this ruin your reputation, so you want to apply the box blur algorithm to the
    /// photo to hide its content.
    /// The pixels in the input image are represented as integers. The algorithm distorts the input image in the
    /// following way: Every pixel x in the output image has a value equal to the average value of the pixel values
    /// from the 3 × 3 square that has its center at x, including x itself. All the pixels on the border of x are
    /// then removed.
    /// Return the blurred image as an integer, with the fractions rounded down.
    /// </summary>
    /// <param name="image"></param>
    /// <returns></returns>
    public static int[][] BoxBlur(int[][] image)
    {
      int x = image[0].Length - 2;
      int y = image.Length - 2;
      int[][] b = new int[y][];

      for (int i = 0; i < y; i++)
      {
        b[i] = new int[x];
        for (int j = 0; j < x; j++)
        {
          b[i][j] = image[i][j] + image[i][j + 1] + image[i][j + 2] +
                    image[i + 1][j] + image[i + 1][j + 1] + image[i + 1][j + 2] +
                    image[i + 2][j] + image[i + 2][j + 1] + image[i + 2][j + 2];
          b[i][j] /= 9;
        }
      }

      return b;
    }


    /// <summary>
    /// In the popular Minesweeper game you have a board with some mines and those cells that don't contain a mine
    /// have a number in it that indicates the total number of mines in the neighboring cells. Starting off with some
    /// arrangement of mines we want to create a Minesweeper game setup.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static int[][] Minesweeper(bool[][] matrix)
    {
      int[][] b = new int[matrix.Length][];
      for (int i = 0; i < matrix.Length; i++)
      {
        b[i] = new int[matrix[0].Length];
        for (int j = 0; j < matrix[0].Length; j++)
        {
          for (int n = i - 1; n <= i + 1; n++)
          {
            for (int m = j - 1; m <= j + 1; m++)
            {
              //Console.WriteLine("{0} {1}", n, m);
              if (n == i && m == j)
                continue;
              try
              {
                if (matrix[n][m]) b[i][j] += 1;
              }
              catch
              {
                // ignore
              }
            }
          }
        }
      }

      return b;
    }

    #endregion

    #region Rains of Reason 

    /// <summary>
    /// Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.
    /// For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, the output should be
    /// arrayReplace(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].
    ///  </summary>
    /// <param name="inputArray"></param>
    /// <param name="elemToReplace"></param>
    /// <param name="substitutionElem"></param>
    /// <returns></returns>
    public static int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
    {
      int[] replaced = inputArray;
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (inputArray[i] == elemToReplace)
        {
          replaced[i] = substitutionElem;
        }
      }

      return replaced;
    }


    /// <summary>
    /// Check if all digits of the given integer are even.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static bool EvenDigitsOnly(int n)
    {
      foreach (var c in n.ToString())
      {
        if (!int.TryParse(c.ToString(), out var result) || result % 2 != 0)
        {
          return false;
        }
      }

      return true;
    }


    /// <summary>
    /// Correct variable names consist only of English letters, digits and underscores and they can't start with
    /// a digit. Check if the given string is a correct variable name. 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static bool VariableName(string name)
    {
      // faster
      return name.All(o => char.IsLetterOrDigit(o) || o == '_') && !char.IsDigit(name[0]);

      // more roads to Rome
//      var match = Regex.Match(name, "[_a-zA-Z][_a-zA-Z0-9]*");
//      return match.Length == name.Length;
    }


    /// <summary>
    /// Given a string, replace each of its character by the next one in the English alphabet (z would be replaced by a).
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static string AlphabeticShift(string inputString)
    {
//      Dictionary<char, char> table = new Dictionary<char, char>
//      {
//        {'a', 'b'},
//        {'b', 'c'},
//        {'c', 'd'},
//        {'d', 'e'},
//        {'e', 'f'},
//        {'f', 'g'},
//        {'g', 'h'},
//        {'h', 'i'},
//        {'i', 'j'},
//        {'j', 'k'},
//        {'k', 'l'},
//        {'l', 'm'},
//        {'m', 'n'},
//        {'n', 'o'},
//        {'o', 'p'},
//        {'p', 'q'},
//        {'q', 'r'},
//        {'r', 's'},
//        {'s', 't'},
//        {'t', 'u'},
//        {'u', 'v'},
//        {'v', 'w'},
//        {'w', 'x'},
//        {'x', 'y'},
//        {'y', 'z'},
//        {'z', 'a'}
//      };
//
//      string result = "";
//      foreach (char c in inputString)
//      {
//        result += table[c];
//      }
//
//      return result;

      return string.Concat(inputString.Select(_ => ++_ > 'z' ? 'a' : _));
    }


    /// <summary>
    /// Given two cells on the standard chess board, determine whether they have the same color or not.
    /// </summary>
    /// <param name="cell1"></param>
    /// <param name="cell2"></param>
    /// <returns></returns>
    public static bool ChessBoardCellColor(string cell1, string cell2)
    {
      return IsEven(cell1) == IsEven(cell2);
    }

    private static bool IsEven(string cell)
    {
      return cell[0] % 2 == 1 && cell[1] % 2 == 1 || cell[0] % 2 == 0 && cell[1] % 2 == 0;
    }

    #endregion

    #region Through the Fog 

    /// <summary>
    /// Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between
    /// any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
    /// Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="firstNumber"></param>
    /// <returns></returns>
    public static int CircleOfNumbers(int n, int firstNumber)
    {
      // copy from core
      int i = n / 2;
      int j = i + firstNumber;
      return j % n;
    }


    /// <summary>
    /// You have deposited a specific amount of money into your bank account. Each year your balance increases at the
    /// same growth rate. With the assumption that you don't make any additional deposits, find out how long it would
    /// take for your balance to pass a specific threshold.
    /// </summary>
    /// <param name="deposit"></param>
    /// <param name="rate"></param>
    /// <param name="threshold"></param>
    /// <returns></returns>
    public static int DepositProfit(int deposit, int rate, int threshold)
    {
      int years = 0;
      double accountSum = deposit;

      while (accountSum < threshold)
      {
        accountSum += accountSum * (rate / 100.0);
        years++;
      }

      return years;
    }


    /// <summary>
    /// Given a sorted array of integers a, find an integer x from a such that the value of:
    /// abs(a[0] - x) + abs(a[1] - x) + ... + abs(a[a.length - 1] - x)
    /// is the smallest possible (here abs denotes the absolute value).
    /// If there are several possible answers, output the smallest one.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int AbsoluteValuesSumMinimization(int[] a)
    {
      return a[(a.Length - 1) / 2];
    }


    /// <summary>
    /// Given an array of equal-length strings, you'd like to know if it's possible to rearrange the order of the
    /// elements in such a way that each consecutive pair of strings differ by exactly one character. Return true if
    /// it's possible, and false if not.
    /// </summary>
    /// <param name="inputArray"></param>
    /// <returns></returns>
    public static bool StringsRearrangement(string[] inputArray)
    {
      return inputArray.Any(_ => S(inputArray, _));
    }

    private static bool S(string[] r, string s)
    {
      return !r.Any() | r.Where((_, i) =>
               _.Where((c, j) => c != s[j]).Count() == 1 && S(r.Where((o, j) => i != j).ToArray(), _)).Any();
    }

    #endregion

    #region Diving Deeper 

    /// <summary>
    /// Given array of integers, remove each kth element from it.
    /// </summary>
    /// <param name="inputArray"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static int[] ExtractEachKth(int[] inputArray, int k)
    {
      List<int> result = new List<int>();

      for (int i = 0; i < inputArray.Length; i++)
      {
        if ((i + 1) % k != 0) result.Add(inputArray[i]);
      }

      return result.ToArray();
    }


    /// <summary>
    /// Find the leftmost digit that occurs in a given string.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static char FirstDigit(string inputString)
    {
      return inputString.FirstOrDefault(char.IsDigit);
    }


    /// <summary>
    /// Given a string, find the number of different characters in it.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int DifferentSymbolsNaive(string s)
    {
      return s.Distinct().Count();
    }


    /// <summary>
    /// Given array of integers, find the maximal possible sum of some of its k consecutive elements.
    /// </summary>
    /// <param name="inputArray"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static int ArrayMaxConsecutiveSum(int[] inputArray, int k)
    {
      int m = inputArray.Where((x, i) => i < k).Sum();
      int n = m;

      for (int i = 0; i < inputArray.Length - k; i++)
      {
        n = n - inputArray[i] + inputArray[i + k];
        if (n > m) m = n;
      }

      return m;
    }

    #endregion

    #region Dark Wilderness 

    /// <summary>
    /// Caring for a plant can be hard work, but since you tend to it regularly, you have a plant that grows
    /// consistently. Each day, its height increases by a fixed amount represented by the integer upSpeed. But due to
    /// lack of sunlight, the plant decreases in height every night, by an amount represented by downSpeed.
    ///
    /// Since you grew the plant from a seed, it started at height 0 initially. Given an integer desiredHeight,
    /// your task is to find how many days it'll take for the plant to reach this height.
    /// </summary>
    /// <param name="upSpeed"></param>
    /// <param name="downSpeed"></param>
    /// <param name="desiredHeight"></param>
    /// <returns></returns>
    public static int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
    {
      int days = 1;
      int currentHeight = 0;

      while (currentHeight < desiredHeight)
      {
        currentHeight += upSpeed;

        if (currentHeight >= desiredHeight) return days;

        // otherwise night time
        currentHeight -= downSpeed;

        // its a new day
        days++;
      }

      return days;
    }


    /// <summary>
    /// You found two items in a treasure chest! The first item weighs weight1 and is worth value1, and the second
    /// item weighs weight2 and is worth value2. What is the total maximum value of the items you can take with you,
    /// assuming that your max weight capacity is maxW and you can't come back for the items later?
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="weight1"></param>
    /// <param name="value2"></param>
    /// <param name="weight2"></param>
    /// <param name="maxW"></param>
    /// <returns></returns>
    public static int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
    {
      if (weight1 > maxW && weight2 > maxW) return 0;
      if (weight1 > maxW) return value2;
      if (weight2 > maxW) return value1;

      return weight1 + weight2 <= maxW ? value1 + value2 : Math.Max(value1, value2);
    }


    /// <summary>
    /// Given a string, output its longest prefix which contains only digits.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static string LongestDigitsPrefix(string inputString)
    {
//      string result = "";
//
//      foreach (char c in inputString)
//      {
//        if (char.IsDigit(c)) result += c;
//        else break;
//      }
//      
//      return result;
//      
      return new string(inputString.TakeWhile(char.IsDigit).ToArray());
    }


    /// <summary>
    /// Let's define digit degree of some positive integer as the number of times we need to replace this number with
    /// the sum of its digits until we get to a one digit number.
    /// Given an integer, find its digit degree.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int DigitDegree(int n)
    {
      int count = 0;

      if (n.ToString().Length == 1) return count;

      int sum = GetSum(n);
      count++;

      while (sum.ToString().Length > 1)
      {
        sum = GetSum(sum);
        count++;
      }

      return count;
    }

    private static int GetSum(int n)
    {
      int sum = 0;
      while (n != 0)
      {
        sum = sum + n % 10;
        n = n / 10;
      }

      return sum;
    }


    /// <summary>
    /// Given the positions of a white bishop and a black pawn on the standard chess board, determine whether the
    /// bishop can capture the pawn in one move.
    /// The bishop has no restrictions in distance for each move, but is limited to diagonal movement. Check out the
    /// example below to see how it can move:
    /// </summary>
    /// <param name="bishop"></param>
    /// <param name="pawn"></param>
    /// <returns>true if the bishop can capture the pawn, false otherwise.</returns>
    public static bool BishopAndPawn(string bishop, string pawn)
    {
      return Math.Abs(Convert.ToInt32(bishop[0]) - Convert.ToInt32(pawn[0])) ==
             Math.Abs(bishop[1] - pawn[1]);
    }

    #endregion

    #region Eruption of Light 


    /// <summary>
    /// A string is said to be beautiful if each letter of the alphabet appears at most as many times as than the
    /// previous letter; ie: b occurs no more times than a; c occurs no more times than b; etc.
    ///
    /// Given a string, check whether it is beautiful.
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static bool IsBeautifulString(string inputString)
    {
      
      return false;
    }
    
    
    #endregion

    #region Rainbow of Clarity 

    #endregion

    #region Land of Logic 

    #endregion
  }
}