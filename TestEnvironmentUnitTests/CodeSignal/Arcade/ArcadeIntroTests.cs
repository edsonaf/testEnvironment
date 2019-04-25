using NUnit.Framework;
using TestEnvironment.CodeSignal.Arcade;

namespace TestEnvironmentUnitTests.CodeSignal.Arcade
{
  [TestFixture]
  [Timeout(3000)]
  public class ArcadeIntroTests
  {
    [Test]
    [TestCase(new[] {1, 3, 2, 1}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 01")]
    [TestCase(new[] {1, 3, 2}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 02")]
    [TestCase(new[] {1, 2, 1, 2}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 03")]
    [TestCase(new[] {1, 4, 10, 4, 2}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 04")]
    [TestCase(new[] {10, 1, 2, 3, 4, 5}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 05")]
    [TestCase(new[] {1, 1, 1, 2, 3}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 06")]
    [TestCase(new[] {0, -2, 5, 6}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 07")]
    [TestCase(new[] {1, 2, 3, 4, 5, 3, 5, 6}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 08")]
    [TestCase(new[] {40, 50, 60, 10, 20, 30}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 09")]
    [TestCase(new[] {1, 1}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 10")]
    [TestCase(new[] {1, 2, 5, 3, 5}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 11")]
    [TestCase(new[] {1, 2, 5, 5, 5}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 12")]
    [TestCase(new[] {10, 1, 2, 3, 4, 5, 6, 1}, ExpectedResult = false, TestName = "AlmostIncreasingSequenceTest 13")]
    [TestCase(new[] {1, 2, 3, 4, 3, 6}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 14")]
    [TestCase(new[] {1, 2, 3, 4, 99, 5, 6}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 15")]
    [TestCase(new[] {123, -17, -5, 1, 2, 3, 12, 43, 45}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 16")]
    [TestCase(new[] {3, 5, 67, 98, 3}, ExpectedResult = true, TestName = "AlmostIncreasingSequenceTest 17")]
    public bool AlmostIncreasingSequenceTest(int[] sequence)
    {
      return ArcadeIntro.AlmostIncreasingSequence(sequence);
    }

    [Test]
    public void MatrixElementsSumTest()
    {
      // Arrange
      const int result01 = 9;
      const int result02 = 9;
      const int result03 = 18;
      const int result04 = 0;

      int[][] test01 =
      {
        new[] {0, 1, 1, 2},
        new[] {0, 5, 0, 0},
        new[] {2, 0, 3, 3}
      };

      int[][] test02 =
      {
        new[] {1, 1, 1, 0},
        new[] {0, 5, 0, 1},
        new[] {2, 1, 3, 10}
      };

      int[][] test03 =
      {
        new[] {1, 1, 1},
        new[] {2, 2, 2},
        new[] {3, 3, 3}
      };

      int[][] test04 =
      {
        new[] {0}
      };

      // Act & Assert
      Assert.AreEqual(result01, ArcadeIntro.MatrixElementsSum(test01));
      Assert.AreEqual(result02, ArcadeIntro.MatrixElementsSum(test02));
      Assert.AreEqual(result03, ArcadeIntro.MatrixElementsSum(test03));
      Assert.AreEqual(result04, ArcadeIntro.MatrixElementsSum(test04));
    }

    [Test]
    public void AllLongestStringsTest()
    {
      // Arrange
      string[] inputTest01 = {"aba", "aa", "ad", "vcd", "aba"};
      string[] inputTest02 = {"aa"};
      string[] inputTest03 = {"abc", "eeee", "abcd", "dcd"};
      string[] inputTest04 = {"a", "abc", "cbd", "zzzzzz", "a", "abcdef", "asasa", "aaaaaa"};

      string[] expectedOutputTest01 = {"aba", "vcd", "aba"};
      string[] expectedOutputTest02 = {"aa"};
      string[] expectedOutputTest03 = {"eeee", "abcd"};
      string[] expectedOutputTest04 = {"zzzzzz", "abcdef", "aaaaaa"};

      // Act
      string[] outputTest01 = ArcadeIntro.AllLongestStrings(inputTest01);
      string[] outputTest02 = ArcadeIntro.AllLongestStrings(inputTest02);
      string[] outputTest03 = ArcadeIntro.AllLongestStrings(inputTest03);
      string[] outputTest04 = ArcadeIntro.AllLongestStrings(inputTest04);

      // Assert
      Assert.AreEqual(expectedOutputTest01, outputTest01);
      Assert.AreEqual(expectedOutputTest02, outputTest02);
      Assert.AreEqual(expectedOutputTest03, outputTest03);
      Assert.AreEqual(expectedOutputTest04, outputTest04);
    }

    [Test]
    [TestCase("aabcc", "adcaa", ExpectedResult = 3, TestName = "CommonCharacterCountTest01")]
    [TestCase("zzzz", "zzzzzzz", ExpectedResult = 4, TestName = "CommonCharacterCountTest02")]
    [TestCase("abca", "xyzbac", ExpectedResult = 3, TestName = "CommonCharacterCountTest03")]
    [TestCase("a", "b", ExpectedResult = 0, TestName = "CommonCharacterCountTest04")]
    [TestCase("a", "aaa", ExpectedResult = 1, TestName = "CommonCharacterCountTest05")]
    public int CommonCharacterCountTest(string s1, string s2)
    {
      return ArcadeIntro.CommonCharacterCount(s1, s2);
    }


    [Test]
    [TestCase(1230, ExpectedResult = true, TestName = "IsLuckyTest01")]
    [TestCase(239017, ExpectedResult = false, TestName = "IsLuckyTest02")]
    [TestCase(134008, ExpectedResult = true, TestName = "IsLuckyTest03")]
    [TestCase(10, ExpectedResult = false, TestName = "IsLuckyTest04")]
    [TestCase(11, ExpectedResult = true, TestName = "IsLuckyTest05")]
    [TestCase(1010, ExpectedResult = true, TestName = "IsLuckyTest06")]
    [TestCase(261534, ExpectedResult = false, TestName = "IsLuckyTest07")]
    [TestCase(100000, ExpectedResult = false, TestName = "IsLuckyTest08")]
    [TestCase(999999, ExpectedResult = true, TestName = "IsLuckyTest09")]
    [TestCase(123321, ExpectedResult = true, TestName = "IsLuckyTest10")]
    public bool IsLuckyTest(int n)
    {
      return ArcadeIntro.IsLucky(n);
    }


    [Test]
    [TestCase(new[] {-1, 150, 190, 170, -1, -1, 160, 180}, TestName = "SortByHeightTest01",
      ExpectedResult = new[] {-1, 150, 160, 170, -1, -1, 180, 190})]
    [TestCase(new[] {1, -1, -1, -1, -1}, TestName = "SortByHeightTest02", ExpectedResult = new[] {1, -1, -1, -1, -1})]
    [TestCase(new[] {-1}, TestName = "SortByHeightTest03", ExpectedResult = new[] {-1})]
    [TestCase(new[] {4, 2, 9, 11, 2, 16}, TestName = "SortByHeightTest04", ExpectedResult = new[] {2, 2, 4, 9, 11, 16})]
    [TestCase(new[] {2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1}, TestName = "SortByHeightTest05",
      ExpectedResult = new[] {1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2})]
    [TestCase(new[] {23, 54, -1, 43, 1, -1, -1, 77, -1, -1, -1, 3}, TestName = "SortByHeightTest06",
      ExpectedResult = new[] {1, 3, -1, 23, 43, -1, -1, 54, -1, -1, -1, 77})]
    public int[] SortByHeightTest(int[] a)
    {
      return ArcadeIntro.SortByHeight(a);
    }

    [Test]
    [TestCase("a(bc)de", ExpectedResult = "acbde", TestName = "ReverseParenthesesTest01")]
    [TestCase("a(bcdefghijkl(mno)p)q", ExpectedResult = "apmnolkjihgfedcbq", TestName = "ReverseParenthesesTest02")]
    [TestCase("co(de(fight)s)", ExpectedResult = "cosfighted", TestName = "ReverseParenthesesTest03")]
    [TestCase("Code(Cha(lle)nge)", ExpectedResult = "CodeegnlleahC", TestName = "ReverseParenthesesTest04")]
    [TestCase("Where are the parentheses?", ExpectedResult = "Where are the parentheses?",
      TestName = "ReverseParenthesesTest05")]
    [TestCase("abc(cba)ab(bac)c", ExpectedResult = "abcabcabcabc", TestName = "ReverseParenthesesTest06")]
    [TestCase("The ((quick (brown) (fox) jumps over the lazy) dog)",
      ExpectedResult = "The god quick nworb xof jumps over the lazy", TestName = "ReverseParenthesesTest07")]
    public string ReverseParenthesesTest(string s)
    {
      return ArcadeIntro.ReverseParentheses(s);
    }


    [Test]
    [TestCase(new[] {50, 60, 60, 45, 70}, ExpectedResult = new[] {180, 105}, TestName = "AlternatingSumsTest01")]
    [TestCase(new[] {100, 50}, ExpectedResult = new[] {100, 50}, TestName = "AlternatingSumsTest02")]
    [TestCase(new[] {80}, ExpectedResult = new[] {80, 0}, TestName = "AlternatingSumsTest03")]
    [TestCase(new[] {100, 50, 50, 100}, ExpectedResult = new[] {150, 150}, TestName = "AlternatingSumsTest04")]
    [TestCase(new[] {100, 51, 50, 100}, ExpectedResult = new[] {150, 151}, TestName = "AlternatingSumsTest05")]
    public int[] AlternatingSumsTest(int[] a)
    {
      return ArcadeIntro.AlternatingSums(a);
    }


    [Test]
    public void AddBorderTest()
    {
      // Arrange
      string[] inputTest01 = {"abc", "ded"};
      string[] inputTest02 = {"a"};
      string[] inputTest03 = {"aa", "**", "zz"};
      string[] inputTest04 = {"abcde", "fghij", "klmno", "pqrst", "uvwxy"};
      string[] inputTest05 = {"wzy**"};

      string[] expectedOutputTest01 = {"*****", "*abc*", "*ded*", "*****"};
      string[] expectedOutputTest02 = {"***", "*a*", "***"};
      string[] expectedOutputTest03 = {"****", "*aa*", "****", "*zz*", "****"};
      string[] expectedOutputTest04 = {"*******", "*abcde*", "*fghij*", "*klmno*", "*pqrst*", "*uvwxy*", "*******"};
      string[] expectedOutputTest05 = {"*******", "*wzy***", "*******"};

      // Act
      string[] outputTest01 = ArcadeIntro.AddBorder(inputTest01);
      string[] outputTest02 = ArcadeIntro.AddBorder(inputTest02);
      string[] outputTest03 = ArcadeIntro.AddBorder(inputTest03);
      string[] outputTest04 = ArcadeIntro.AddBorder(inputTest04);
      string[] outputTest05 = ArcadeIntro.AddBorder(inputTest05);

      // Assert
      Assert.AreEqual(expectedOutputTest01, outputTest01);
      Assert.AreEqual(expectedOutputTest02, outputTest02);
      Assert.AreEqual(expectedOutputTest03, outputTest03);
      Assert.AreEqual(expectedOutputTest04, outputTest04);
      Assert.AreEqual(expectedOutputTest05, outputTest05);
    }


    [Test]
    [TestCase(new[] {1, 2, 3}, new[] {1, 2, 3}, ExpectedResult = true, TestName = "AreSimilarTest01")]
    [TestCase(new[] {1, 2, 3}, new[] {2, 1, 3}, ExpectedResult = true, TestName = "AreSimilarTest02")]
    [TestCase(new[] {1, 2, 2}, new[] {2, 1, 1}, ExpectedResult = false, TestName = "AreSimilarTest03")]
    [TestCase(new[] {1, 1, 4}, new[] {1, 2, 3}, ExpectedResult = false, TestName = "AreSimilarTest04")]
    [TestCase(new[] {1, 2, 3}, new[] {1, 10, 2}, ExpectedResult = false, TestName = "AreSimilarTest05")]
    [TestCase(new[] {2, 3, 1}, new[] {1, 3, 2}, ExpectedResult = true, TestName = "AreSimilarTest06")]
    [TestCase(new[] {2, 3, 9}, new[] {10, 3, 2}, ExpectedResult = false, TestName = "AreSimilarTest07")]
    [TestCase(new[] {4, 6, 3}, new[] {3, 4, 6}, ExpectedResult = false, TestName = "AreSimilarTest08")]
    [TestCase(new[] {832, 998, 148, 570, 533, 561, 894, 147, 455, 279},
      new[] {832, 998, 148, 570, 533, 561, 455, 147, 894, 279}, ExpectedResult = true, TestName = "AreSimilarTest09")]
    [TestCase(new[] {832, 998, 148, 570, 533, 561, 894, 147, 455, 279},
      new[] {832, 570, 148, 998, 533, 561, 455, 147, 894, 279}, ExpectedResult = false, TestName = "AreSimilarTest10")]
    public bool AreSimilarTest(int[] a, int[] b)
    {
      return ArcadeIntro.AreSimilar(a, b);
    }


    [Test]
    [TestCase(new[] {1, 1, 1}, ExpectedResult = 3, TestName = "ArrayChangeTest01")]
    [TestCase(new[] {-1000, 0, -2, 0}, ExpectedResult = 5, TestName = "ArrayChangeTest02")]
    [TestCase(new[] {2, 1, 10, 1}, ExpectedResult = 12, TestName = "ArrayChangeTest03")]
    [TestCase(new[] {2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15}, ExpectedResult = 13, TestName = "ArrayChangeTest04")]
    public int ArrayChangeTest(int[] inputArray)
    {
      return ArcadeIntro.ArrayChange(inputArray);
    }


    [Test]
    [TestCase("aabb", ExpectedResult = true, TestName = "PalindromeRearrangingTest01")]
    [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabc", ExpectedResult = false, TestName = "PalindromeRearrangingTest02")]
    [TestCase("abbcabb", ExpectedResult = true, TestName = "PalindromeRearrangingTest03")]
    [TestCase("zyyzzzzz", ExpectedResult = true, TestName = "PalindromeRearrangingTest04")]
    [TestCase("z", ExpectedResult = true, TestName = "PalindromeRearrangingTest05")]
    [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbcccc", ExpectedResult = true, TestName = "PalindromeRearrangingTest15")]
    public bool PalindromeRearrangingTest(string inputString)
    {
      return ArcadeIntro.PalindromeRearranging(inputString);
    }


    [Test]
    [TestCase(10, 15, 15, 10, ExpectedResult = true, TestName = "AreEquallyStrongTest01")]
    [TestCase(15, 10, 15, 10, ExpectedResult = true, TestName = "AreEquallyStrongTest02")]
    [TestCase(15, 10, 15, 9, ExpectedResult = false, TestName = "AreEquallyStrongTest03")]
    public bool AreEquallyStrongTest(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
    {
      return ArcadeIntro.AreEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight);
    }


    [Test]
    [TestCase(new[] {2, 4, 1, 0}, ExpectedResult = 3, TestName = "ArrayMaximalAdjacentDifferenceTest01")]
    [TestCase(new[] {1, 1, 1, 1}, ExpectedResult = 0, TestName = "ArrayMaximalAdjacentDifferenceTest02")]
    [TestCase(new[] {-1, 4, 10, 3, -2}, ExpectedResult = 7, TestName = "ArrayMaximalAdjacentDifferenceTest03")]
    public int ArrayMaximalAdjacentDifferenceTest(int[] inputArray)
    {
      return ArcadeIntro.ArrayMaximalAdjacentDifference(inputArray);
    }


    [Test]
    [TestCase("172.16.254.1", ExpectedResult = true, TestName = "IsIPv4AddressTest01")]
    [TestCase("172.316.254.1", ExpectedResult = false, TestName = "IsIPv4AddressTest02")]
    [TestCase(".254.255.0", ExpectedResult = false, TestName = "IsIPv4AddressTest03")]
    [TestCase("1", ExpectedResult = false, TestName = "IsIPv4AddressTest05")]
    public bool IsIPv4AddressTest(string inputString)
    {
      return ArcadeIntro.IsIPv4Address(inputString);
    }


    [Test]
    [TestCase(new[] {5, 3, 6, 7, 9}, ExpectedResult = 4, TestName = "AvoidObstaclesTest01")]
    [TestCase(new[] {2, 3}, ExpectedResult = 4, TestName = "AvoidObstaclesTest02")]
    [TestCase(new[] {1, 4, 10, 6, 2}, ExpectedResult = 7, TestName = "AvoidObstaclesTest03")]
    public int AvoidObstaclesTest(int[] inputArray)
    {
      return ArcadeIntro.AvoidObstacles(inputArray);
    }


    [Test]
    public void BoxBlurTest()
    {
      int[][] imageTest01 = {new[] {1, 1, 1}, new[] {1, 7, 1}, new[] {1, 1, 1},};
      int[][] imageTest06 =
      {
        new[] {36, 0, 18, 9, 9, 45, 27},
        new[] {27, 0, 254, 9, 0, 63, 90},
        new[] {81, 255, 72, 45, 18, 27, 0},
        new[] {0, 0, 9, 81, 27, 18, 45},
        new[] {45, 45, 227, 227, 90, 81, 72},
        new[] {45, 18, 9, 255, 9, 18, 45},
        new[] {27, 81, 36, 127, 255, 72, 81},
      };

      int[][] expectedOutputTest06 =
      {
        new[] {82, 73, 48, 25, 31},
        new[] {77, 80, 57, 32, 32},
        new[] {81, 106, 88, 68, 42},
        new[] {44, 96, 103, 89, 45},
        new[] {59, 113, 137, 126, 80}
      };

      int[][] expectedOutputTest01 = {new[] {1}};

      var actualOutputTest01 = ArcadeIntro.BoxBlur(imageTest01);
      var actualOutputTest06 = ArcadeIntro.BoxBlur(imageTest06);

      Assert.AreEqual(expectedOutputTest01, actualOutputTest01);
      Assert.AreEqual(expectedOutputTest06, actualOutputTest06);
    }


    [Test]
    public void MinesweeperTest()
    {
      bool[][] input =
      {
        new[] {true, false, false},
        new[] {false, true, false},
        new[] {false, false, false}
      };

      int[][] expectedOutput =
      {
        new[] {1, 2, 1},
        new[] {2, 1, 1},
        new[] {1, 1, 1}
      };

      var actualOutput = ArcadeIntro.Minesweeper(input);

      Assert.AreEqual(expectedOutput, actualOutput);
    }


    [Test]
    [TestCase(248622, ExpectedResult = true, TestName = "EvenDigitsOnlyTest01")]
    [TestCase(642386, ExpectedResult = false, TestName = "EvenDigitsOnlyTest02")]
    public bool EvenDigitsOnlyTest(int n)
    {
      return ArcadeIntro.EvenDigitsOnly(n);
    }


    [Test]
    [TestCase("var_1__Int", ExpectedResult = true, TestName = "VariableNameTest01")]
    [TestCase("qq-q", ExpectedResult = false, TestName = "VariableNameTest02")]
    [TestCase("2w2", ExpectedResult = false, TestName = "VariableNameTest03")]
    [TestCase(" variable", ExpectedResult = false, TestName = "VariableNameTest04")]
    [TestCase("va[riable0", ExpectedResult = false, TestName = "VariableNameTest05")]
    public bool VariableNameTest(string name)
    {
      return ArcadeIntro.VariableName(name);
    }


    [Test]
    [TestCase("crazy", ExpectedResult = "dsbaz", TestName = "AlphabeticShiftTest01")]
    [TestCase("z", ExpectedResult = "a", TestName = "AlphabeticShiftTest02")]
    [TestCase("aaaabbbccd", ExpectedResult = "bbbbcccdde", TestName = "AlphabeticShiftTest03")]
    [TestCase("fuzzy", ExpectedResult = "gvaaz", TestName = "AlphabeticShiftTest04")]
    [TestCase("codesignal", ExpectedResult = "dpeftjhobm", TestName = "AlphabeticShiftTest05")]
    public string AlphabeticShiftTest(string inputString)
    {
      return ArcadeIntro.AlphabeticShift(inputString);
    }


    [Test]
    [TestCase("A1", "C3", ExpectedResult = true, TestName = "ChessBoardCellColorTest01")]
    [TestCase("A1", "H3", ExpectedResult = false, TestName = "ChessBoardCellColorTest02")]
    [TestCase("A1", "A2", ExpectedResult = false, TestName = "ChessBoardCellColorTest03")]
    [TestCase("A1", "B2", ExpectedResult = true, TestName = "ChessBoardCellColorTest04")]
    public bool ChessBoardCellColorTest(string cell1, string cell2)
    {
      return ArcadeIntro.ChessBoardCellColor(cell1, cell2);
    }


    [Test]
    [TestCase(100, 20, 170, ExpectedResult = 3, TestName = "DepositProfitTest01")]
    public int DepositProfitTest(int deposit, int rate, int threshold)
    {
      return ArcadeIntro.DepositProfit(deposit, rate, threshold);
    }


    [Test]
    [TestCase(new[] {2, 4, 7}, ExpectedResult = 4, TestName = "AbsoluteValuesSumMinimizationTest01")]
    [TestCase(new[] {1, 1, 3, 4}, ExpectedResult = 1, TestName = "AbsoluteValuesSumMinimizationTest02")]
    public int AbsoluteValuesSumMinimizationTest(int[] a)
    {
      return ArcadeIntro.AbsoluteValuesSumMinimization(a);
    }


    [Test]
    public void StringsRearrangementTest()
    {
      string[] inputArray = {"aba", "bbb", "bab"};
      var result = ArcadeIntro.StringsRearrangement(inputArray);

      Assert.AreEqual(false, result);
    }


    [Test]
    [TestCase(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 3, ExpectedResult = new[] {1, 2, 4, 5, 7, 8, 10},
      TestName = "ExtractEachKthTest01")]
    [TestCase(new[] {1, 1, 1, 1, 1}, 1, ExpectedResult = new int[] { }, TestName = "ExtractEachKthTest02")]
    [TestCase(new[] {1, 2, 1, 2, 1, 2, 1, 2}, 2, ExpectedResult = new[] {1, 1, 1, 1},
      TestName = "ExtractEachKthTest03")]
    [TestCase(new[] {1, 2, 1, 2, 1, 2, 1, 2}, 10, ExpectedResult = new[] {1, 2, 1, 2, 1, 2, 1, 2},
      TestName = "ExtractEachKthTest04")]
    public int[] ExtractEachKthTest(int[] inputArray, int k)
    {
      return ArcadeIntro.ExtractEachKth(inputArray, k);
    }


    [Test]
    [TestCase(100, 10, 910, ExpectedResult = 10, TestName = "GrowingPlantTest01")]
    [TestCase(10, 9, 4, ExpectedResult = 1, TestName = "GrowingPlantTest02")]
    public int GrowingPlantTest(int upSpeed, int downSpeed, int desiredHeight)
    {
      return ArcadeIntro.GrowingPlant(upSpeed, downSpeed, desiredHeight);
    }


    [Test]
    [TestCase(5, ExpectedResult = 0, TestName = "DigitDegreeTest01")]
    [TestCase(100, ExpectedResult = 1, TestName = "DigitDegreeTest02")]
    [TestCase(91, ExpectedResult = 2, TestName = "DigitDegreeTest03")]
    [TestCase(99, ExpectedResult = 2, TestName = "DigitDegreeTest04")]
    [TestCase(1000000000, ExpectedResult = 1, TestName = "DigitDegreeTest05")]
    [TestCase(9, ExpectedResult = 0, TestName = "DigitDegreeTest06")]
    public int DigitDegreeTest(int n)
    {
      return ArcadeIntro.DigitDegree(n);
    }


    [Test]
    [TestCase("a1", "c3", ExpectedResult = true, TestName = "BishopAndPawnTest01")]
    [TestCase("h1", "h3", ExpectedResult = false, TestName = "BishopAndPawnTest02")]
    [TestCase("a5", "c3", ExpectedResult = true, TestName = "BishopAndPawnTest03")]
    public bool BishopAndPawnTest(string bishop, string pawn)
    {
      return ArcadeIntro.BishopAndPawn(bishop, pawn);
    }


    [Test]
    [TestCase("bbbaacdafe", ExpectedResult = true, TestName = "IsBeautifulStringTest01")]
    [TestCase("aabbb", ExpectedResult = false, TestName = "IsBeautifulStringTest02")]
    [TestCase("bbc", ExpectedResult = false, TestName = "IsBeautifulStringTest03")]
    [TestCase("bbbaa", ExpectedResult = false, TestName = "IsBeautifulStringTest04")]
    [TestCase("abcdefghijklmnopqrstuvwxyzz", ExpectedResult = false, TestName = "IsBeautifulStringTest05")]
    public bool IsBeautifulStringTest(string inputString)
    {
      return ArcadeIntro.IsBeautifulString(inputString);
    }
    
  }
}