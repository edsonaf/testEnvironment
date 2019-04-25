using System;
using System.Linq;

namespace TestEnvironment.CodeSignal.Arcade
{
  public static class ArcadeCore
  {
    #region Intro Gates

    public static int AddTwoDigits(int n)
    {
      return n / 10 + n % 10;
    }


    /// <assignment>
    /// Given an integer n, return the largest number that contains exactly n digits.
    /// </assignment>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int LargestNumber(int n)
    {
      return (int) Math.Pow(10, n) - 1;
    }


    /// <summary>
    /// n children have got m pieces of candy. They want to eat as much candy as they can, but each child must eat
    /// exactly the same amount of candy as any other child. Determine how many pieces of candy will be eaten by all
    /// the children together. Individual pieces of candy cannot be split.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public static int Candies(int n, int m)
    {
      return (int) (Math.Floor((double) m / n)) * n;
    }


    /// <assignment>
    /// Your friend advised you to see a new performance in the most popular theater in the city. He knows a lot about
    /// art and his advice is usually good, but not this time: the performance turned out to be awfully dull. It's so
    /// bad you want to sneak out, which is quite simple, especially since the exit is located right behind your row
    /// to the left. All you need to do is climb over your seat and make your way to the exit.
    /// The main problem is your shyness: you're afraid that you'll end up blocking the view (even if only for a couple
    /// of seconds) of all the people who sit behind you and in your column or the columns to your left. To gain some
    /// courage, you decide to calculate the number of such people and see if you can possibly make it to the exit
    /// without disturbing too many people.
    /// Given the total number of rows and columns in the theater (nRows and nCols, respectively), and the row and
    /// column you're sitting in, return the number of people who sit strictly behind you and in your column or to
    /// the left, assuming all seats are occupied.
    /// For nCols = 16, nRows = 11, col = 5, and row = 3, the output should be
    ///  seatsInTheater(nCols, nRows, col, row) = 96.
    /// </assignment>
    /// <param name="nCols"></param>
    /// <param name="nRows"></param>
    /// <param name="col"></param>
    /// <param name="row"></param>
    /// <returns></returns>
    public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
      return (nCols - col + 1) * (nRows - row);
    }


    public static int MaxMultiple(int divisor, int bound)
    {
      int i = bound / divisor;
      return i * divisor;
    }


    /// <assignment>
    /// Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between
    /// any two neighboring numbers is equal (note that 0 and n - 1 are neighboring, too).
    /// Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber. 
    /// </assignment>
    /// <param name="n"></param>
    /// <param name="firstNumber"></param>
    /// <returns></returns>
    public static int CircleOfNumbers(int n, int firstNumber)
    {
      int i = n / 2;
      int j = i + firstNumber;
      return j % n;
    }


    /// <assignment>
    /// One night you go for a ride on your motorcycle. At 00:00 you start your engine, and the built-in timer
    /// automatically begins counting the length of your ride, in minutes. Off you go to explore the neighborhood.
    /// When you finally decide to head back, you realize there's a chance the bridges on your route home are up,
    /// leaving you stranded! Unfortunately, you don't have your watch on you and don't know what time it is. All you
    /// know thanks to the bike's timer is that n minutes have passed since 00:00.
    /// Using the bike's timer, calculate the current time. Return an answer as the sum of digits that the digital
    /// timer in the format hh:mm would show.
    /// 
    /// </assignment>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int LateRide(int n)
    {
      string digitalTime = (n / 60) + (n % 60).ToString();
      return digitalTime.Select(x => int.Parse(x.ToString())).Sum();
    }


    /// <summary>
    /// Some phone usage rate may be described as follows:
    /// first minute of a call costs min1 cents,
    /// each minute from the 2nd up to 10th (inclusive) costs min2_10 cents
    /// each minute after 10th costs min11 cents.
    /// You have s cents on your account before the call. What is the duration of the longest call (in minutes rounded
    /// down to the nearest integer) you can have?
    /// </summary>
    /// <param name="min1"></param>
    /// <param name="min210"></param>
    /// <param name="min11"></param>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int PhoneCall(int min1, int min210, int min11, int s)
    {
      if (min1 > s) return 0;
      s -= min1;
      int i1 = s / min210;
      if (i1 <= 9) return i1 + 1;
      s -= min210 * 9;
      return (s / min11) + 10;
    }

    #endregion Intro Gates

    #region At the Crossroads

    /// <assignment>
    /// You are playing an RPG game. Currently your experience points (XP) total is equal
    /// to <param name="experience" />. To reach the next level your XP should be at least at <param name="threshold"/>.
    /// If you kill the monster in
    /// front of you, you will gain more experience points in the amount of the <param name="reward"/>.
    /// </assignment>
    /// <returns>
    /// Given values experience, threshold and reward, check if you reach the next level after killing the monster.
    /// </returns>
    public static bool ReachNextLevel(int experience, int threshold, int reward)
    {
      return experience + reward >= threshold;
    }


    /// <assignment>
    /// You found two items in a treasure chest! The first item weighs weight1 and is worth value1, and the second item weighs weight2 and is worth value2. What is the total maximum value of the items you can take with you, assuming that your max weight capacity is maxW and you can't come back for the items later?
    /// Note that there are only two items and you can't bring more than one item of each type, i.e. you can't take two first items or two second items.
    /// </assignment>
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
    /// You're given three integers, a, b and c. It is guaranteed that two of these integers are equal to each other.
    /// What is the value of the third integer?
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static int ExtraNumber(int a, int b, int c)
    {
      //      return a ^ b ^ c;
      return a == b ? c : b == c ? a : b;
    }


    public static bool IsInfiniteProcess(int a, int b)
    {
      return a > b || (b - a) % 2 > 0;
    }


    public static bool ArithmeticExpression(int a, int b, int c)
    {
      return a + b == c || a - b == c || a * b == c || ((double) a / b).Equals(c);
    }

    public static bool TennisSet(int score1, int score2)
    {
      int neededToWin = (score1 == 5 || score2 == 5) ? 7 : 6;
      return (score1 == neededToWin && score2 != neededToWin) ||
             (score2 == neededToWin && score1 != neededToWin);
    }


    public static bool WillYou(bool young, bool beautiful, bool loved)
    {
      return (young && beautiful) != loved;
    }


    /// <summary>
    /// You just bought a public transit card that allows you to ride the Metro for a certain number of days.
    /// Here is how it works: upon first receiving the card, the system allocates you a 31-day pass, which equals the
    /// number of days in January. The second time you pay for the card, your pass is extended by 28 days, i.e. the
    /// number of days in February (note that leap years are not considered), and so on. The 13th time you extend the
    /// pass, you get 31 days again.
    /// You just ran out of days on the card, and unfortunately you've forgotten how many times your pass has been
    /// extended so far. However, you do remember the number of days you were able to ride the Metro during this most
    /// recent month. Figure out the number of days by which your pass will now be extended, and return all the options
    /// as an array sorted in increasing order.
    /// For lastNumberOfDays = 30, the output should be metroCard(lastNumberOfDays) = [31].
    /// There are 30 days in April, June, September and November, so the next months to consider are May, July, October
    /// or December. All of them have exactly 31 days, which means that you will definitely get a 31-days pass the next
    /// time you extend your card.
    /// </summary>
    /// <param name="lastNumberOfDays"></param>
    /// <returns></returns>
    public static int[] MetroCard(int lastNumberOfDays)
    {
      return (lastNumberOfDays == 30 || lastNumberOfDays == 28) ? new[] {31} : new[] {28, 30, 31};
    }

    #endregion At the Crossroads

    #region Corner of 0s and 1s

    /// <summary>
    /// In order to stop the Mad Coder evil genius you need to decipher the encrypted message he sent to his minions.
    /// The message contains several numbers that, when typed into a supercomputer, will launch a missile into the sky
    /// blocking out the sun, and making all the people on Earth grumpy and sad.
    /// You figured out that some numbers have a modified single digit in their binary representation. More
    /// specifically, in the given number n the kth bit from the right was initially set to 0, but its current value
    /// might be different. It's now up to you to write a function that will change the kth bit of n back to 0.
    /// Example: For n = 37 and k = 3, the output should be killKthBit(n, k) = 33.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public static int KillKthBit(int n, int k)
    {
      return n & ~(1 << (k - 1));
    }


    /// <summary>
    /// You are given an array of up to four non-negative integers, each less than 256.
    /// Your task is to pack these integers into one number M in the following way:
    /// The first element of the array occupies the first 8 bits of M;
    /// The second element occupies next 8 bits, and so on.
    /// Return the obtained integer M.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int ArrayPacking(int[] a)
    {
      string bits = a.Aggregate("", (current, t) => current.Insert(0, Convert.ToString(t, 2).PadLeft(8, '0')));
      return Convert.ToInt32(bits, 2);

      // another possible solution:
      //     return a.Reverse().Aggregate((t,n) => (t << 8) + n);

      // which is this solution if im not mistaken
//      int ret = 0;
//      for (int i=a.Length-1; i >= 0; i--)
//      {
//        ret = (ret << 8) + a[i];
//      }
//      return ret;
    }


    /// <summary>
    /// You are given two numbers a and b where 0 ≤ a ≤ b. Imagine you construct an array of all the integers from
    /// a to b inclusive. You need to count the number of 1s in the binary representations of all the numbers in
    /// the array.
    /// For a = 2 and b = 7, the output should be rangeBitCount(a, b) = 11.
    /// Given a = 2 and b = 7 the array is: [2, 3, 4, 5, 6, 7]. Converting the numbers to binary,
    /// we get [10, 11, 100, 101, 110, 111], which contains 1 + 2 + 1 + 2 + 2 + 3 = 11 1s.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int RangeBitCount(int a, int b)
    {
      int count = 0;
      for (int i = a; i <= b; i++)
      {
        string binaryString = Convert.ToString(i, 2).PadLeft(4, '0');
        count += binaryString.GroupBy(c => c)
          .Select(c => new {Char = c.Key, Count = c.Count()})
          .Where(v => v.Char == '1').Sum(v => v.Count);
      }

      return count;
    }

    /// <summary>
    /// Reverse the order of the bits in a given integer.
    /// For a = 97, the output should be mirrorBits(a) = 67.
    /// 97 equals to 1100001 in binary, which is 1000011 after mirroring, and that is 67 in base 10.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public static int MirrorBits(int a)
    {
      string reverse = new string(Convert.ToString(a, 2).Reverse().ToArray());
      return Convert.ToInt32(reverse, 2);
    }


    /// <summary>
    /// Presented with the integer n, find the 0-based position of the second rightmost zero bit in its binary
    /// representation (it is guaranteed that such a bit exists), counting from right to left.
    /// Return the value of 2 ^ position_of_the_found_bit.
    /// For n = 37, the output should be secondRightmostZeroBit(n) = 8.
    /// 37 = 100101. The second rightmost zero bit is at position 3 (0-based) from the right in the binary
    /// representation of n.
    /// Thus, the answer is 2^3 = 8.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int SecondRightMostZeroBit(int n)
    {
      return n;
    }

    #endregion
  }
}