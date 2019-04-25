using NUnit.Framework;
using TestEnvironment.QuickChallenges;

namespace TestEnvironmentUnitTests.QuickChallengesTests
{
  [TestFixture]
  [Timeout(3000)]
  public class NewNumeralSystemTests
  {
    [Test]
    [TestCase('G', ExpectedResult = new[] {"A + G", "B + F", "C + E", "D + D"})]
    [TestCase('T', ExpectedResult = new[]
    {
      "A + T", "B + S", "C + R", "D + Q", "E + P",
      "F + O", "G + N", "H + M", "I + L", "J + K"
    })]
    public static string[] GetPairsWhichSumIsNumberTest(char number)
    {
      return NewNumeralSystem.GetPairsWhichSumIsNumber(number);
    }
  }
}