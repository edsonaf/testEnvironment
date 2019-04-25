using NUnit.Framework;

namespace TestEnvironmentUnitTests.CodeSignal.Interview
{
  [TestFixture]
  [Timeout(3000)]
  public class ArraysTests
  {
    [TestCase(new[] {2, 1, 3, 5, 3, 2}, ExpectedResult = 3)]
    [TestCase(new[] {2, 4, 3, 5, 1}, ExpectedResult = -1)]
    [TestCase(new[] {1}, ExpectedResult = -1)]
    public int FirstDuplicateTest(int[] a)
    {
      return TestEnvironment.CodeSignal.Interview.Arrays.FirstDuplicate(a);
    }

    [TestCase("abacabd", ExpectedResult = 'c', TestName = "Test 01")]
    [TestCase("abacabaabacaba", ExpectedResult = '_', TestName = "Test 02")]
    [TestCase("z", ExpectedResult = 'z', TestName = "Test 03")]
    [TestCase("bcccccccb", ExpectedResult = '_', TestName = "Test 05")]
    [TestCase("zzz", ExpectedResult = '_', TestName = "Test 07")]
    [TestCase("bcccccccccccccyb", ExpectedResult = 'y', TestName = "Test 08")]
    [TestCase("ngrhhqbhnsipkcoqjyviikvxbxyphsnjpdxkhtadltsuxbfbrkof", ExpectedResult = 'g', TestName = "Test 10")]
    public char FirstNotRepeatingCharacterTest(string s)
    {
      return TestEnvironment.CodeSignal.Interview.Arrays.FirstNotRepeatingCharacter(s);
    }
  }
}