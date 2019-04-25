using NUnit.Framework;
using TestEnvironment.CompanyChallenges;

namespace TestEnvironmentUnitTests.CompanyChallenges
{
  [TestFixture]
  [Timeout(3000)]
  public class DropboxChallengesTests
  {
//    [TestCase(new[] {21, 10}, new[] {100, 105}, 2, ExpectedResult = new[] {116, 115}, TestName = "Test 01")]
//    [TestCase(new[] {20, 10}, new[] {1, 1}, 1, ExpectedResult = new[] {31, 21}, TestName = "Test 02")]
//    [TestCase(new int[0], new int[0], 100, ExpectedResult = new int[0], TestName = "Test 03")]
//    [TestCase(new[] {10}, new[] {10}, 2, ExpectedResult = new[] {15}, TestName = "Test 04")]
//    [TestCase(new[] {1, 1, 1}, new[] {2, 2, 2}, 3, ExpectedResult = new[] {3, 3, 3}, TestName = "Test 05")]
//    [TestCase(new[] {21, 10}, new[] {100, 105}, 2, ExpectedResult = new[] {116, 115}, TestName = "Test 06")]
//    [TestCase(new[] {21, 10}, new[] {100, 105}, 2, ExpectedResult = new[] {116, 115}, TestName = "Test 07")]
//    [TestCase(new[] {21, 10}, new[] {100, 105}, 2, ExpectedResult = new[] {116, 115}, TestName = "Test 08")]
//    [TestCase(new[] {21, 10}, new[] {100, 105}, 2, ExpectedResult = new[] {116, 115}, TestName = "Test 09")]
    public int[] LoadTimeEstimatorTest(int[] sizes, int[] uploadingStart, int v)
    {
      return DropboxChallenges.LoadTimeEstimator(sizes, uploadingStart, v);
    }
  }
}