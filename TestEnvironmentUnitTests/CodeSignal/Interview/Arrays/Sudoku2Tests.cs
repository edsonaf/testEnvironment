using NUnit.Framework;

namespace TestEnvironmentUnitTests.Interview.Arrays
{
  [TestFixture]
  public class Sudoku2Tests
  {
    [Test]
    public void Test01()
    {
      char[][] grid =
      {
        new[] {'.', '.', '.', '1', '4', '.', '.', '2', '.'},
        new[] {'.', '.', '6', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},

        new[] {'.', '.', '1', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '6', '7', '.', '.', '.', '.', '.', '9'},
        new[] {'.', '.', '.', '.', '.', '.', '8', '1', '.'},

        new[] {'.', '3', '.', '.', '.', '.', '.', '.', '6'},
        new[] {'.', '.', '.', '.', '.', '7', '.', '.', '.'},
        new[] {'.', '.', '.', '5', '.', '.', '.', '7', '.'}
      };

      bool isSudokuCompliant = TestEnvironment.Interview.Arrays.Sudoku2(grid);
      Assert.True(isSudokuCompliant);
    }

    [Test]
    public void Test02()
    {
      char[][] grid =
      {
        new[] {'.', '.', '.', '1', '4', '.', '.', '2', '.'},
        new[] {'.', '.', '6', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '1', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '6', '7', '.', '.', '.', '.', '.', '9'},
        new[] {'.', '.', '.', '.', '.', '.', '8', '1', '.'},
        new[] {'.', '3', '.', '.', '.', '.', '.', '.', '6'},
        new[] {'.', '.', '.', '.', '.', '7', '.', '.', '.'},
        new[] {'.', '.', '.', '5', '.', '.', '.', '7', '.'}
      };


      bool isSudokuCompliant = TestEnvironment.Interview.Arrays.Sudoku2(grid);
      Assert.IsTrue(isSudokuCompliant);
    }
  }
}