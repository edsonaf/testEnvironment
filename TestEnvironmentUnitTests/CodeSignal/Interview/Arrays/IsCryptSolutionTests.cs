using NUnit.Framework;

namespace TestEnvironmentUnitTests.CodeSignal.Interview.Arrays
{
  [TestFixture]
  public class IsCryptSolutionTests
  {
    [Test]
    public void Test01()
    {
      string[] crypt = {"SEND", "MORE", "MONEY"};
      char[][] solution =
      {
        new[] {'O', '0'},
        new[] {'M', '1'},
        new[] {'Y', '2'},
        new[] {'E', '5'},
        new[] {'N', '6'},
        new[] {'D', '7'},
        new[] {'R', '8'},
        new[] {'S', '9'}
      };

      var isCryptSolution = TestEnvironment.CodeSignal.Interview.Arrays.IsCryptSolution(crypt, solution);

      Assert.IsTrue(isCryptSolution);
    }

    [Test]
    public void Test16()
    {
      string[] crypt = {"AAAAAAAAAAAAAA", "BBBBBBBBBBBBBB", "CCCCCCCCCCCCCC"};
      char[][] solution =
      {
        new[] {'A', '1'},
        new[] {'B', '2'},
        new[] {'C', '3'},
      };

      var isCryptSolution = TestEnvironment.CodeSignal.Interview.Arrays.IsCryptSolution(crypt, solution);

      Assert.IsTrue(isCryptSolution);
    }

    [Test]
    public void Test19()
    {
      string[] crypt = {"WASD", "IJKL", "AOPAS"};
      char[][] solution =
      {
        new[] {'W', '2'},
        new[] {'A', '0'},
        new[] {'S', '4'},
        new[] {'D', '1'},
        new[] {'I', '5'},
        new[] {'J', '8'},
        new[] {'K', '6'},
        new[] {'L', '3'},
        new[] {'O', '7'},
        new[] {'P', '9'},
      };

      var isCryptSolution = TestEnvironment.CodeSignal.Interview.Arrays.IsCryptSolution(crypt, solution);

      Assert.IsFalse(isCryptSolution);
    }
  }
}