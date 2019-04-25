using NUnit.Framework;

namespace TestEnvironmentUnitTests.CodeSignal.Interview.Arrays
{
  [TestFixture]
  [Timeout(3000)]
  public class RotateImageTests
  {
    [Test]
    public void Test01()
    {
      int[][] a =
      {
        new[] {1, 2, 3},
        new[] {4, 5, 6},
        new[] {7, 8, 9}
      };
      int[][] rotateImage = TestEnvironment.CodeSignal.Interview.Arrays.RotateImage(a);


      int[][] expected =
      {
        new[] {7, 4, 1},
        new[] {8, 5, 2},
        new[] {9, 6, 3}
      };
      Assert.AreEqual(expected, rotateImage);
    }

    [Test]
    public void Test04()
    {
      int[][] a =
      {
        new[] {40, 12, 15, 37, 33, 11, 45, 13, 25, 3},
        new[] {37, 35, 15, 43, 23, 12, 22, 29, 46, 43},
        new[] {44, 19, 15, 12, 30, 2, 45, 7, 47, 6},
        new[] {48, 4, 40, 10, 16, 22, 18, 36, 27, 48},
        new[] {45, 17, 36, 28, 47, 46, 8, 4, 17, 3},
        new[] {14, 9, 33, 1, 6, 31, 7, 38, 25, 17},
        new[] {31, 9, 17, 11, 29, 42, 38, 10, 48, 6},
        new[] {12, 13, 42, 3, 47, 24, 28, 22, 3, 47},
        new[] {38, 23, 26, 3, 23, 27, 14, 40, 15, 22},
        new[] {8, 46, 20, 21, 35, 4, 36, 18, 32, 3},
      };

      int[][] rotateImage = TestEnvironment.CodeSignal.Interview.Arrays.RotateImage(a);

      int[][] expected =
      {
        new[] {8, 38, 12, 31, 14, 45, 48, 44, 37, 40},
        new[] {46, 23, 13, 9, 9, 17, 4, 19, 35, 12},
        new[] {20, 26, 42, 17, 33, 36, 40, 15, 15, 15},
        new[] {21, 3, 3, 11, 1, 28, 10, 12, 43, 37},
        new[] {35, 23, 47, 29, 6, 47, 16, 30, 23, 33},
        new[] {4, 27, 24, 42, 31, 46, 22, 2, 12, 11},
        new[] {36, 14, 28, 38, 7, 8, 18, 45, 22, 45},
        new[] {18, 40, 22, 10, 38, 4, 36, 7, 29, 13},
        new[] {32, 15, 3, 48, 25, 17, 27, 47, 46, 25},
        new[] {3, 22, 47, 6, 17, 3, 48, 6, 43, 3}
      };

      Assert.AreEqual(expected, rotateImage);
    }
  }
}