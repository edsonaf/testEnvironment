using NUnit.Framework;
using TestEnvironment.Arcade;

namespace TestEnvironmentUnitTests.Arcade
{
  [TestFixture]
  [Timeout(3000)]
  public class ArcadeCoreTests
  {
    #region Intro Gates

    [Test]
    [TestCase(29, ExpectedResult = 11, TestName = "AddTwoDigitsTest01")]
    [TestCase(48, ExpectedResult = 12, TestName = "AddTwoDigitsTest02")]
    [TestCase(10, ExpectedResult = 1, TestName = "AddTwoDigitsTest03")]
    [TestCase(25, ExpectedResult = 7, TestName = "AddTwoDigitsTest04")]
    public int AddTwoDigitsTest(int n)
    {
      return ArcadeCore.AddTwoDigits(n);
    }


    [Test]
    [TestCase(2, ExpectedResult = 99, TestName = "LargestNumberTest01")]
    [TestCase(1, ExpectedResult = 9, TestName = "LargestNumberTest02")]
    [TestCase(7, ExpectedResult = 9999999, TestName = "LargestNumberTest03")]
    [TestCase(4, ExpectedResult = 9999, TestName = "LargestNumberTest04")]
    [TestCase(3, ExpectedResult = 999, TestName = "LargestNumberTest05")]
    public int LargestNumberTest(int n)
    {
      return ArcadeCore.LargestNumber(n);
    }


    [Test]
    [TestCase(3, 10, ExpectedResult = 9, TestName = "CandiesTest01")]
    [TestCase(1, 2, ExpectedResult = 2, TestName = "CandiesTest02")]
    [TestCase(10, 5, ExpectedResult = 0, TestName = "CandiesTest03")]
    [TestCase(4, 4, ExpectedResult = 4, TestName = "CandiesTest04")]
    public int CandiesTest(int n, int m)
    {
      return ArcadeCore.Candies(n, m);
    }


    [Test]
    [TestCase(16, 11, 5, 3, ExpectedResult = 96, TestName = "SeatsInTheaterTest01")]
    [TestCase(1, 1, 1, 1, ExpectedResult = 0, TestName = "SeatsInTheaterTest02")]
    [TestCase(13, 6, 8, 3, ExpectedResult = 18, TestName = "SeatsInTheaterTest03")]
    [TestCase(60, 100, 60, 1, ExpectedResult = 99, TestName = "SeatsInTheaterTest04")]
    [TestCase(1000, 1000, 1000, 1000, ExpectedResult = 0, TestName = "SeatsInTheaterTest05")]
    public int SeatsInTheaterTest(int nCols, int nRows, int col, int row)
    {
      return ArcadeCore.SeatsInTheater(nCols, nRows, col, row);
    }


    [Test]
    [TestCase(10, 2, ExpectedResult = 7, TestName = "CircleOfNumbersTest01")]
    [TestCase(10, 7, ExpectedResult = 2, TestName = "CircleOfNumbersTest02")]
    [TestCase(4, 1, ExpectedResult = 3, TestName = "CircleOfNumbersTest03")]
    [TestCase(6, 3, ExpectedResult = 0, TestName = "CircleOfNumbersTest04")]
    public int CircleOfNumbersTest(int n, int firstNumber)
    {
      return ArcadeCore.CircleOfNumbers(n, firstNumber);
    }


    [Test]
    [TestCase(240, ExpectedResult = 4, TestName = "LateRideTest01")]
    [TestCase(808, ExpectedResult = 14, TestName = "LateRideTest02")]
    [TestCase(1439, ExpectedResult = 19, TestName = "LateRideTest03")]
    [TestCase(0, ExpectedResult = 0, TestName = "LateRideTest04")]
    [TestCase(23, ExpectedResult = 5, TestName = "LateRideTest05")]
    [TestCase(8, ExpectedResult = 8, TestName = "LateRideTest06")]
    public int LateRideTest(int n)
    {
      return ArcadeCore.LateRide(n);
    }


    [Test]
    [TestCase(3, 1, 2, 20, ExpectedResult = 14, TestName = "PhoneCallTest01")]
    [TestCase(2, 2, 1, 2, ExpectedResult = 1, TestName = "PhoneCallTest02")]
    [TestCase(10, 1, 2, 22, ExpectedResult = 11, TestName = "PhoneCallTest03")]
    [TestCase(2, 2, 1, 24, ExpectedResult = 14, TestName = "PhoneCallTest04")]
    [TestCase(1, 2, 1, 6, ExpectedResult = 3, TestName = "PhoneCallTest05")]
    public int PhoneCallTest(int min1, int min210, int min11, int s)
    {
      return ArcadeCore.PhoneCall(min1, min210, min11, s);
    }

    #endregion Intro Gates

    #region At the Crossroads

    [Test]
    [TestCase(10, 15, 5, ExpectedResult = true, TestName = "ReachNextLevelTest01")]
    [TestCase(16, 23, 16, ExpectedResult = true, TestName = "ReachNextLevelTest10")]
    public bool ReachNextLevelTest(int experience, int threshold, int reward)
    {
      return ArcadeCore.ReachNextLevel(experience, threshold, reward);
    }

    [Test]
    [TestCase(5, 3, 7, 4, 6, ExpectedResult = 7, TestName = "KnapsackLightTest03")]
    [TestCase(3, 5, 3, 8, 10, ExpectedResult = 3, TestName = "KnapsackLightTest08")]
    public int KnapsackLightTest(int value1, int weight1, int value2, int weight2, int maxW)
    {
      return ArcadeCore.KnapsackLight(value1, weight1, value2, weight2, maxW);
    }

    [Test]
    [TestCase(5, 5, 1, ExpectedResult = 1, TestName = "ExtraNumberTest03")]
    public int ExtraNumberTest(int a, int b, int c)
    {
      return ArcadeCore.ExtraNumber(a, b, c);
    }

    [Test]
    [TestCase(5, 10, ExpectedResult = true, TestName = "IsInfiniteProcessTest01")]
    public bool IsInfiniteProcessTest(int a, int b)
    {
      return ArcadeCore.IsInfiniteProcess(a, b);
    }

    [Test]
    [TestCase(2, 3, 5, ExpectedResult = true, TestName = "ArithmeticExpressionTest01")]
    [TestCase(8, 2, 4, ExpectedResult = true, TestName = "ArithmeticExpressionTest02")]
    [TestCase(8, 3, 2, ExpectedResult = false, TestName = "ArithmeticExpressionTest03")]
    [TestCase(6, 3, 3, ExpectedResult = true, TestName = "ArithmeticExpressionTest04")]
    [TestCase(18, 2, 9, ExpectedResult = true, TestName = "ArithmeticExpressionTest05")]
    [TestCase(2, 3, 6, ExpectedResult = true, TestName = "ArithmeticExpressionTest06")]
    [TestCase(5, 2, 0, ExpectedResult = false, TestName = "ArithmeticExpressionTest07")]
    [TestCase(10, 2, 2, ExpectedResult = false, TestName = "ArithmeticExpressionTest08")]
    [TestCase(5, 2, 2, ExpectedResult = false, TestName = "ArithmeticExpressionTest09")]
    [TestCase(1, 2, 1, ExpectedResult = false, TestName = "ArithmeticExpressionTest10")]
    public bool ArithmeticExpressionTest(int a, int b, int c)
    {
      return ArcadeCore.ArithmeticExpression(a, b, c);
    }


    [Test]
    [TestCase(30, ExpectedResult = new[] {31}, TestName = "MetroCardTest01")]
    [TestCase(31, ExpectedResult = new[] {28, 30, 31}, TestName = "MetroCardTest02")]
    public int[] MetroCardTest(int lastNumberOfDays)
    {
      return ArcadeCore.MetroCard(lastNumberOfDays);
    }

    [Test]
    [TestCase(37, 3, ExpectedResult = 33, TestName = "KillKthBitTest01")]
    [TestCase(37, 4, ExpectedResult = 37, TestName = "KillKthBitTest02")]
    [TestCase(37, 2, ExpectedResult = 37, TestName = "KillKthBitTest03")]
    [TestCase(0, 4, ExpectedResult = 0, TestName = "KillKthBitTest04")]
    [TestCase(2147483647, 16, ExpectedResult = 2147450879, TestName = "KillKthBitTest05")]
    [TestCase(374823748, 13, ExpectedResult = 374819652, TestName = "KillKthBitTest06")]
    [TestCase(2734827, 4, ExpectedResult = 2734819, TestName = "KillKthBitTest07")]
    [TestCase(1084197039, 15, ExpectedResult = 1084197039, TestName = "KillKthBitTest08")]
    [TestCase(1160825071, 3, ExpectedResult = 1160825067, TestName = "KillKthBitTest09")]
    [TestCase(2039063284, 4, ExpectedResult = 2039063284, TestName = "KillKthBitTest10")]
    public int KillKthBitTest(int n, int k)
    {
      return ArcadeCore.KillKthBit(n, k);
    }


    [Test]
    [TestCase(new[] {24, 85, 0}, ExpectedResult = 21784, TestName = "ArrayPackingTest01")]
    public int ArrayPackingTest(int[] a)
    {
      return ArcadeCore.ArrayPacking(a);
    }


    [Test]
    [TestCase(2, 7, ExpectedResult = 11, TestName = "RangeBitCountTest01")]
    [TestCase(0, 1, ExpectedResult = 1, TestName = "RangeBitCountTest02")]
    [TestCase(1, 10, ExpectedResult = 17, TestName = "RangeBitCountTest03")]
    [TestCase(8, 9, ExpectedResult = 3, TestName = "RangeBitCountTest04")]
    [TestCase(9, 10, ExpectedResult = 4, TestName = "RangeBitCountTest05")]
    public int RangeBitCountTest(int a, int b)
    {
      return ArcadeCore.RangeBitCount(a, b);
    }

    [Test]
    [TestCase(97, ExpectedResult = 67, TestName = "MirrorBitsTest01")]
    [TestCase(8, ExpectedResult = 1, TestName = "MirrorBitsTest02")]
    [TestCase(123, ExpectedResult = 111, TestName = "MirrorBitsTest03")]
    [TestCase(86782, ExpectedResult = 65173, TestName = "MirrorBitsTest04")]
    [TestCase(5, ExpectedResult = 5, TestName = "MirrorBitsTest05")]
    public int MirrorBitsTest(int a)
    {
      return ArcadeCore.MirrorBits(a);
    }


    [Test][Ignore("not working on that atm")]
    [TestCase(37, ExpectedResult = 8, TestName = "SecondRightMostZeroBitTest01")]
    [TestCase(1073741824, ExpectedResult = 2, TestName = "SecondRightMostZeroBitTest02")]
    [TestCase(83748, ExpectedResult = 2, TestName = "SecondRightMostZeroBitTest03")]
    [TestCase(4, ExpectedResult = 2, TestName = "SecondRightMostZeroBitTest04")]
    [TestCase(728782938, ExpectedResult = 4, TestName = "SecondRightMostZeroBitTest05")]
    public int SecondRightMostZeroBitTest(int n)
    {
      return ArcadeCore.SecondRightMostZeroBit(n);
    }
    
    #endregion At the Crossroads
  }
}